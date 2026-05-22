# Variables
DOTNET = dotnet

.PHONY: all
all: build

# Build .NET Solution
.PHONY: build
build:
	$(DOTNET) build CopierImages.sln --configuration Release

# Clean compiled binaries and caches
.PHONY: clean
clean:
	rm -rf CopierImages/bin/ CopierImages/obj/
	find . -type f -name "*.suo" -delete
	find . -type f -name "*.user" -delete
