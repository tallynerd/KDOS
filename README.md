# KDOS
My COSMOS C# os built pretty much from scratch.


## Installation

As of now, I only have installation rules for Linux, but there will be more soon!

## RHEL-based Linux
```bash
# Install .NET 10 and COSMOS prereqs
sudo dnf install -y dotnet-sdk-10.0 qemu-system-x86 xorriso lld clang


# Install COSMOS
dotnet tool install -g Cosmos.Tools

# Add the dotnet tools to your PATH
export PATH="$PATH:$HOME/.dotnet/tools"
echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bashrc

# Clone the repo
git clone https://github.com/tallynerd/KDOS.git

# Navigate into the directory
cd KDOS

# Check for COSMOS and all prerequisites
cosmos check

# If all is well, build and run
cosmos build
cosmos run

```

