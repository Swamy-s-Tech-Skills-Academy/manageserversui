# Quick Start Guide

Get **ServerHub** up and running in just a few minutes!

## 🚀 Prerequisites

Before you begin, ensure you have:

- **.NET 10.0 SDK** installed
- **Visual Studio 2022** or **VS Code** with C# extension
- **Git** for cloning the repository

## 📥 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/your-org/serverhub.git
cd serverhub
```

### 2. Restore Dependencies

```bash
dotnet restore
```

### 3. Build the Project

```bash
dotnet build
```

### 4. Run the Application

```bash
cd src/ServersManagement
dotnet run
```

## 🌐 Access the Application

Once the application starts, open your browser and navigate to:

- **HTTPS**: `https://localhost:7150`
- **HTTP**: `http://localhost:5234`

## 🎯 First Steps

### 1. Explore the Dashboard

- **Home Page**: Overview of ServerHub capabilities
- **Servers Page**: View sample server cards with status indicators

### 2. Navigate the Interface

**Sidebar Navigation:**

- **Dashboard**: Main overview page
- **Servers**: Server management interface
- **Analytics**: Performance monitoring (Weather demo)
- **System Logs**: Log management
- **Alerts**: Notification center
- **Configuration**: Settings panel

**Top Navigation:**

- **Notifications**: Bell icon with alert dropdown
- **User Menu**: Profile and settings
- **Help**: Documentation links

### 3. Understand the Sample Data

The application includes sample servers from different cities:

- **Web Server 01** (New York) - Online
- **Database Server** (London) - Online
- **API Gateway** (Tokyo) - Offline
- **Cache Server** (Sydney) - Online
- **File Server** (Toronto) - Online
- **Mail Server** (Mumbai) - Offline

## 🔧 Development Mode

### Hot Reload

The application supports hot reload for development:

```bash
dotnet watch run
```

### Development Tools

- **Browser DevTools**: F12 for debugging
- **Blazor DevTools**: Available in supporting browsers
- **Visual Studio Debugger**: Set breakpoints in C# code

## 🎨 UI Features

### Modern Design Elements

- **Glassmorphism**: Frosted glass effects in navigation
- **Smooth Animations**: Hover effects and transitions
- **Responsive Design**: Works on desktop, tablet, and mobile
- **Dark Sidebar**: Professional gradient navigation
- **Bootstrap Icons**: Rich iconography throughout

### Interactive Components

- **Server Cards**: Status indicators and action buttons
- **Notification System**: Real-time alerts dropdown
- **Dropdown Menus**: User profile and notifications
- **Responsive Grid**: Adaptive server card layout

## ⚡ Next Steps

1. **[Read the Architecture Guide](./architecture.md)** - Understand the codebase
2. **[Explore Components](./components.md)** - Learn about Blazor components
3. **[Customize the UI](./styling-guide.md)** - Modify the design
4. **[Add Real Data](./server-management.md)** - Connect to actual servers

## 🔗 Useful Commands

```bash
# Run in development mode
dotnet watch run

# Build for production
dotnet publish -c Release

# Run tests
dotnet test

# Clean build artifacts
dotnet clean

# Format code
dotnet format
```

## 🆘 Troubleshooting

### Common Issues

**Port Already in Use:**

```bash
# Kill process using port 7150
netstat -ano | findstr :7150
taskkill /PID <process-id> /F
```

**Missing Dependencies:**

```bash
# Clear NuGet cache
dotnet nuget locals all --clear
dotnet restore
```

**Build Errors:**

```bash
# Clean and rebuild
dotnet clean
dotnet build
```

### Get Help

- Check the [Troubleshooting Guide](./troubleshooting.md)
- Review [Common Issues](./troubleshooting.md#common-issues)
- Open an [Issue](../../issues) on GitHub

---

**Ready to dive deeper?** Check out the [Architecture Guide](./architecture.md) to understand how ServerHub is built!
