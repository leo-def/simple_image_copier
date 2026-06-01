# Simple Image Copier - Technical Specification

> Technical specification for the multi-threaded image pixel copier utility.
> Reference for understanding thread-based concurrent image processing.

## Executive Summary

- **Project**: Simple Image Copier
- **Type**: Command-line image processing utility
- **Language**: Java (Classic threads, no framework)
- **Status**: Active Development
- **Owner**: Development team

---

## 1. Problem Statement

### Context
Simple Image Copier is a lightweight utility that demonstrates multi-threaded pixel-by-pixel image processing. It copies images using configurable thread pools to process pixels in parallel.

### Goals
- **Primary**: Copy images pixel-by-pixel using thread pools
- **Secondary**: Demonstrate thread synchronization and concurrent processing
- **Tertiary**: Provide configurable performance tuning (thread count)

### Success Metrics
- [x] Multi-threaded pixel processing
- [x] Configurable thread count
- [x] Support for common image formats (BMP, PNG, JPG)
- [x] Simple command-line interface
- [ ] Performance >10x faster than single-threaded on 8-core CPU
- [ ] Memory efficient for large images (4K+)

---

## 2. Technology Stack

| Component | Technology | Version | Rationale |
|-----------|-----------|---------|-----------|
| Language | Java | 8+ | Native multi-threading support |
| Threading | java.util.concurrent | Built-in | Thread pools, synchronization |
| Image I/O | javax.imageio.* | Built-in | Image reading/writing |
| Build | Maven or Gradle | Latest | Project management |

### Key Java APIs
- `BufferedImage`: In-memory image representation
- `ExecutorService`: Thread pool management
- `Thread`: Concurrent execution
- `ImageIO`: Read/write image files
- `Color`: Pixel manipulation

---

## 3. Architecture

### High-Level Processing Flow

```
┌────────────────────────────────────┐
│  Load Image (ImageIO.read)         │
└────────────────────────────────────┘
                  ↓
┌────────────────────────────────────┐
│  Initialize Thread Pool            │
│  (ExecutorService with N threads)  │
└────────────────────────────────────┘
                  ↓
┌────────────────────────────────────┐
│  Partition Pixels into Chunks      │
│  (Each thread gets row/column set) │
└────────────────────────────────────┘
                  ↓
┌────────────────────────────────────┐
│  Concurrent Pixel Processing       │
│  (Thread 1 → Chunk 1)              │
│  (Thread 2 → Chunk 2)              │
│  (Thread N → Chunk N)              │
└────────────────────────────────────┘
                  ↓
┌────────────────────────────────────┐
│  Synchronize & Write Output        │
│  (ImageIO.write)                   │
└────────────────────────────────────┘
```

### Thread Work Distribution

```
Image Grid (8x8 pixels)

Single Thread:
[0,0] [1,0] [2,0] ... [7,7]  <- Sequential

Multi-threaded (4 threads):
Thread 1: [0-1, 0-7]
Thread 2: [2-3, 0-7]
Thread 3: [4-5, 0-7]
Thread 4: [6-7, 0-7]
         (Parallel)
```

---

## 4. Project Structure

```
simple_image_copier/
├── execute.bat                # Windows entry point
├── execute.sh                 # Unix entry point
├── src/
│   ├── main/java/
│   │   ├── ImageCopier.java           # Main application
│   │   ├── PixelProcessor.java        # Worker thread task
│   │   ├── ImageLoader.java           # Image I/O utilities
│   │   └── ThreadPool.java            # Thread pool management
│   └── test/java/
│       ├── ImageCopierTest.java
│       └── PixelProcessorTest.java
├── images/
│   ├── input/                # Test images
│   └── output/               # Processed images
├── pom.xml (or build.gradle)
└── README.md
```

---

## 5. Key Components

### ImageCopier (Main)
```java
public class ImageCopier {
  public static void main(String[] args) {
    int threadCount = Integer.parseInt(args[0]); // e.g., 4
    String inputPath = args[1];
    String outputPath = args[2];
    
    BufferedImage image = ImageLoader.load(inputPath);
    BufferedImage copy = copyWithThreads(image, threadCount);
    ImageLoader.save(copy, outputPath);
  }
}
```

### PixelProcessor (Worker)
```java
public class PixelProcessor implements Runnable {
  private BufferedImage source, destination;
  private int startRow, endRow;
  
  @Override
  public void run() {
    for (int y = startRow; y < endRow; y++) {
      for (int x = 0; x < source.getWidth(); x++) {
        int pixel = source.getRGB(x, y);
        destination.setRGB(x, y, pixel);
      }
    }
  }
}
```

---

## 6. Performance Considerations

### Optimization Strategies
- **Chunk Size**: Balance between thread overhead and workload
- **Thread Count**: Optimal is usually CPU core count ± 1
- **Buffering**: Use BufferedImage for efficient pixel access
- **Memory**: Pre-allocate output image before threading

### Warnings
- Don't use too many threads (diminishing returns, overhead)
- Large images (4K+) may require special handling
- Memory usage = N × Image Size (N threads)

