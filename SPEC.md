# Simple Image Copier - Technical Specification

> C# Windows Forms application for pixel-by-pixel image copying with position tracking.
> Demonstrates WinForms UI, GDI+ Bitmap manipulation, and position state management.

## Executive Summary

Simple Image Copier is a **C# .NET Windows Forms** application that copies an image pixel by pixel, tracking which pixels have been "painted." The `CopyController` manages a boolean grid tracking painted positions. The `ImagePanel` is a custom WinForms control for displaying the image. The `Modifier` class handles image transformations. This appears to be an artistic/educational tool demonstrating iterative image reproduction.

---

## 1. Problem Statement

### Context
A Windows desktop tool for progressively copying/reproducing an image pixel by pixel, with state tracking for which pixels have been processed.

### Goals
- Load a source image (Bitmap)
- Track which pixels have been "painted" via a boolean grid
- Display painting progress via a custom WinForms panel
- Complete detection (all pixels painted)

### Success Metrics
- [x] CopyController with pixel position tracking
- [x] Custom ImagePanel control
- [x] Modifier for image transformations
- [x] WinForms UI (Form1)
- [ ] Actual pixel-copying visual output
- [ ] File save/export

---

## 2. Technology Stack

| Component | Technology | Version |
|-----------|-----------|---------|
| Language | C# | .NET Framework 4.x |
| UI | Windows Forms (WinForms) | .NET 4.x |
| Graphics | GDI+ (System.Drawing) | Built-in |
| Build | Visual Studio 2012+ | - |

---

## 3. Architecture

```
Form1 (WinForms main window)
    ├── ImagePanel (custom panel — displays image)
    └── CopyController (state manager)
            ├── bool[,] _positions  (tracks painted pixels)
            └── int _cont           (count of painted pixels)

Modifier (image transformation utilities)
```

---

## 4. Module Structure

```
CopierImages/
  Program.cs            # Entry point (Application.Run)
  Form1.cs              # Main form
  Form1.Designer.cs     # WinForms designer-generated layout
  ImagePanel.cs         # Custom Panel with image rendering
  ImagePanel.Designer.cs
  CopyController.cs     # Core position-tracking state machine
  Modifier.cs           # Image transformation utilities
  App.config            # .NET application config
  Properties/
    AssemblyInfo.cs
    Resources.resx
    Settings.settings
```

---

## 5. Core Logic — CopyController

```csharp
public class CopyController {
    private bool[,] _positions;   // Tracks which pixels have been set
    private int _cont;            // Count of pixels set
    private int _pixels;          // Total pixel count (Width × Height)

    // Returns true when all pixels have been set
    public bool IsFinished() => (_cont >= _pixels);

    // Marks a pixel as painted (idempotent — double-setting does nothing)
    public void SetPosition(Point point) {
        if (_positions[point.X, point.Y]) return;
        _positions[point.X, point.Y] = true;
        _cont++;
    }
}
```

---

## 6. Deployment & Operations

```bash
# Build with Visual Studio
CopierImages.sln → Build Solution

# Run
execute.bat    # Launches the compiled executable
```

---

## 7. Issues Found

### Code Quality
- **Commented-out code in `CopyController.SetPosition`** — return value logic is commented out (`//return true;`, `//return false;`). The method signature returns `void` but the comments suggest it was originally `bool`. This should be cleaned up.
- **`StartController` and constructor both call `_cont = 0; Original = bitmap;`** — `StartController` is called from the constructor, creating a dual-initialization pattern. The constructor should just call `StartController`.

### Platform
- **Windows-only** — WinForms does not run on macOS or Linux without Mono or Wine. Not portable. Consider .NET MAUI or a web-based tool for cross-platform reach.
- **`CopierImages.v12.suo`** (Visual Studio user options file) is committed — should be in `.gitignore`.

### Missing
- No file picker UI to load the source image.
- No save/export functionality to save the copied image.
- No progress indicator showing percentage complete.
