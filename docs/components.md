# Component Reference

This document provides detailed information about all the Blazor components in the ServerHub application.

## 🧩 Component Overview

The ServerHub application is built using a component-based architecture with reusable, well-structured Blazor components.

### Component Hierarchy

```
App.razor
└── Routes.razor
    └── MainLayout.razor
        ├── NavMenu.razor
        └── Pages
            ├── Home.razor
            ├── Servers.razor
            │   └── ServerComponent.razor (multiple instances)
            └── Error.razor
```

## 📄 Page Components

### Home.razor

**Purpose**: Landing page and dashboard overview

**Location**: `Components/Pages/Home.razor`

**Features**:

- Hero section with gradient background
- Feature cards showcasing platform capabilities
- Call-to-action button linking to servers page
- Responsive grid layout

**Key Elements**:

```html
<!-- Hero section with gradient -->
<div class="hero-section">
  <!-- ServerHub branding and description -->
  <!-- CTA button to /servers -->
</div>

<!-- Feature cards grid -->
<div class="row g-4">
  <!-- Server Monitoring card -->
  <!-- Management Tools card -->
  <!-- Analytics card -->
</div>
```

### Servers.razor

**Purpose**: Server management and overview page

**Location**: `Components/Pages/Servers.razor`

**Parameters**: None

**Dependencies**:

- `ServersManagement.Models.Server`
- `ServerComponent.razor`

**Features**:

- Page header with "Add Server" button
- Grid layout of server cards
- Empty state for when no servers exist
- Sample data with 6 demo servers

**Code Structure**:

```csharp
@page "/servers"
@using ServersManagement.Models

// Page layout and server grid
@foreach (var server in servers)
{
    <ServerComponent ServerData="@server" />
}

@code {
    private List<Server> servers = new() { /* sample data */ };
}
```

### Error.razor

**Purpose**: Error handling and display

**Location**: `Components/Pages/Error.razor`

**Features**:

- Error message display
- Request ID tracking
- Development mode guidance
- Professional error styling

## 🏗️ Layout Components

### MainLayout.razor

**Purpose**: Main application layout structure

**Location**: `Components/Layout/MainLayout.razor`

**Features**:

- Two-column layout (sidebar + main content)
- Responsive design
- Top navigation bar
- Content area with proper spacing

**Structure**:

```html
<div class="page">
  <div class="sidebar">
    <NavMenu />
  </div>
  <main>
    <div class="top-row">
      <!-- Top navigation content -->
    </div>
    <article class="content">@Body</article>
  </main>
</div>
```

**CSS Features**:

- Flexbox layout
- Sticky sidebar and top navigation
- Glassmorphism effects
- Responsive breakpoints

### NavMenu.razor

**Purpose**: Primary navigation component

**Location**: `Components/Layout/NavMenu.razor`

**Features**:

- Branded header with ServerHub logo
- Organized navigation sections
- Icon-based menu items
- Badge indicators for counts
- Responsive hamburger menu

**Navigation Structure**:

**Main Menu**

- Dashboard (Home)
- Servers (with count badge)

**Monitoring**

- Analytics
- System Logs
- Alerts (with warning badge)

**Settings**

- Configuration

**CSS Classes**:

- `.nav-section-header` - Section dividers
- `.nav-item` - Individual navigation items
- `.badge` - Count indicators
- Hover and active state styling

## 🎛️ Control Components

### ServerComponent.razor

**Purpose**: Displays individual server information and actions

**Location**: `Components/Controls/ServerComponent.razor`

**Parameters**:

```csharp
[Parameter] public Server ServerData { get; set; } = new();
```

**Dependencies**:

- `ServersManagement.Models.Server`

**Features**:

- Bootstrap card layout
- Dynamic status indicators
- Server information display
- Action buttons for management

**Visual Elements**:

**Card Header**

- Server icon and name
- Status badge (Online/Offline)
- Color-coded based on server status

**Card Body**

- Location information with geo icon
- Status information with activity icon
- Two-column responsive layout

**Action Buttons**

- Manage (primary)
- Monitor (secondary)
- Details (info)

**Status Logic**:

```csharp
// Status badge classes
@(server.IsOnline ? "bg-success" : "bg-danger")

// Status text classes
@(server.IsOnline ? "text-success" : "text-danger")

// Status text display
@(server.IsOnline ? "Online" : "Offline")
```

**Responsive Behavior**:

- Desktop: Two-column layout for server info
- Mobile: Single-column stacked layout
- Buttons remain horizontal on all screens

## 📊 Data Models

### Server.cs

**Purpose**: Data model for server entities

**Location**: `Models/Server.cs`

**Properties**:

```csharp
public class Server
{
    public int ServerId { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
    public bool IsOnline { get; set; }
}
```

**Constructor Logic**:

- Randomly assigns online/offline status
- Used for demo data generation

## 🎨 Styling Architecture

### Component-Scoped CSS

Each layout component has its own CSS file:

- `MainLayout.razor.css` - Main layout styling
- `NavMenu.razor.css` - Navigation specific styles

### Global Styles

**Location**: `wwwroot/app.css`

**Includes**:

- Animation keyframes
- Global utility classes
- Custom scrollbar styling
- Enhanced button styles

### Bootstrap Integration

**Version**: Bootstrap 5.3
**Icons**: Bootstrap Icons via CDN
**JavaScript**: Bootstrap Bundle for dropdown functionality

## 🔧 Component Usage Examples

### Using ServerComponent

```html
<!-- Single server -->
<ServerComponent ServerData="@myServer" />

<!-- Multiple servers in grid -->
<div class="row">
  @foreach (var server in servers) {
  <div class="col-lg-6 col-xl-4">
    <ServerComponent ServerData="@server" />
  </div>
  }
</div>
```

### Navigation Links

```html
<!-- Standard navigation -->
<NavLink href="/servers">Servers</NavLink>

<!-- With active matching -->
<NavLink href="" Match="NavLinkMatch.All">Dashboard</NavLink>
```

This component architecture provides a solid foundation for building scalable, maintainable Blazor applications with clean separation of concerns and reusable UI patterns.
