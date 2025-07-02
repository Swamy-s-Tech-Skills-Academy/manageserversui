# Installation Guide

Get your development environment set up to work with ServerHub.

## Prerequisites

Before installing ServerHub, ensure you have the following installed:

### Required Software

**.NET 10.0 SDK**

- Download from: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- Verify installation: `dotnet --version`
- Required version: 10.0 or later

**Development Environment (Choose one)**

- **Visual Studio 2022** (Recommended)
  - Community, Professional, or Enterprise edition
  - Ensure ASP.NET and web development workload is installed
- **Visual Studio Code**
  - Install C# extension by Microsoft
  - Install C# Dev Kit extension (optional but recommended)

**Git** (Optional but recommended)

- For cloning the repository
- Download from: [https://git-scm.com/](https://git-scm.com/)

### System Requirements

**Operating System**

- Windows 10/11 (recommended)
- macOS 10.15 or later
- Linux (Ubuntu 20.04+, Debian 10+, or similar)

**Hardware**

- **RAM**: 4GB minimum, 8GB recommended
- **Storage**: 500MB for project + SDK space
- **CPU**: Any modern processor (x64, ARM64 supported)

## Installation Steps

### Method 1: Clone from Repository (Recommended)

```bash
# Clone the repository
git clone <repository-url>
cd manageserversui

# Restore NuGet packages
dotnet restore

# Build the solution
dotnet build

# Run the application
cd src/ServersManagement
dotnet run
```

### Method 2: Download ZIP

1. Download the project ZIP file
2. Extract to your desired location
3. Open terminal/command prompt in the extracted folder
4. Run the following commands:

```bash
dotnet restore
dotnet build
cd src/ServersManagement
dotnet run
```

## Project Setup

### Package Management

ServerHub uses **Central Package Management** for consistent dependency versions:

- **Directory.Packages.props** - Defines package versions
- **Directory.Build.props** - Shared MSBuild properties
- Individual project files reference packages without versions

### Build Configuration

The project is configured with:

- **Target Framework**: .NET 10.0
- **Nullable Reference Types**: Enabled
- **Implicit Usings**: Enabled
- **Treat Warnings as Errors**: Enabled for code quality

## Development Tools Setup

### Visual Studio 2022

**Required Workloads**:

- ASP.NET and web development
- .NET Cross-platform development (optional)

**Recommended Extensions**:

- Web Compiler (for CSS/JS minification)
- Productivity Power Tools
- GitLens (if using Git integration)

### Visual Studio Code

**Required Extensions**:

- C# (ms-dotnettools.csharp)
- C# Dev Kit (ms-dotnettools.csdevkit)

**Recommended Extensions**:

- Auto Rename Tag
- Bracket Pair Colorizer
- GitLens
- Thunder Client (for API testing)

## Environment Configuration

### Development Settings

The application includes two configuration files:

**appsettings.json** (Production)

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

**appsettings.Development.json** (Development)

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Information"
    }
  }
}
```

### Launch Settings

The application is configured to run on:

- **HTTPS**: `https://localhost:7150`
- **HTTP**: `http://localhost:5234`

## Verification

### Test the Installation

1. **Start the application**:

   ```bash
   cd src/ServersManagement
   dotnet run
   ```

2. **Open browser** and navigate to:

   - `https://localhost:7150` (HTTPS - recommended)
   - `http://localhost:5234` (HTTP)

3. **Verify functionality**:
   - Dashboard page loads correctly
   - Navigation works smoothly
   - Servers page shows 6 demo servers
   - Responsive design works on different screen sizes

### Expected Output

You should see:

```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7150
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5234
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
```

## Troubleshooting

### Common Issues

**Port Already in Use**

- Change ports in `Properties/launchSettings.json`
- Or stop other applications using those ports

**SSL Certificate Issues**

- Run: `dotnet dev-certs https --trust`
- Restart your browser

**Build Errors**

- Ensure .NET 10.0 SDK is installed
- Clear NuGet cache: `dotnet nuget locals all --clear`
- Restore packages: `dotnet restore`

**Package Restore Failures**

- Check internet connection
- Clear NuGet cache
- Verify package sources: `dotnet nuget list source`

### Getting Help

If you encounter issues:

1. **Check Prerequisites** - Ensure all required software is installed
2. **Verify Versions** - Use `dotnet --version` to confirm .NET version
3. **Clean Build** - Delete `bin` and `obj` folders, then rebuild
4. **Check Logs** - Look at console output for specific error messages

## Next Steps

Once installation is complete:

1. **Explore the Code** - Check out the [Component Reference](./components.md)
2. **Understand Architecture** - Read the [Project Overview](./overview.md)
3. **Learn the UI** - Follow the [User Interface Guide](./ui-guide.md)
4. **Start Customizing** - Modify sample data or styling to make it your own

You're now ready to start developing with ServerHub!
