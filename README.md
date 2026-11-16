# KDOS
My COSMOS C# OS built pretty much from scratch. It's very bare-bones now but i do have more plans



As of now, I only have installation guides for Linux, but there will be more soon!

## Installation (Linux)

## Install .NET 10 and git for RHEL-based Linux
```bash
sudo dnf install -y dotnet-sdk-10.0
sudo dnf install git
```

## Install .NET 10 and git for Debian-based Linux
```bash
sudo apt update
sudo apt install -y dotnet-sdk-10.0
sudo apt install git
```

After you install dotnet and git for your distro, everything else is the same:

```bash
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

