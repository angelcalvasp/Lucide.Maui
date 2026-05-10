
[![NuGet](https://img.shields.io/nuget/v/Lucide.Maui.svg?label=NuGet)](https://www.nuget.org/packages/Lucide.Maui)

# Lucide.Maui

`Lucide.Maui` ships the `Lucide.ttf` icon font for .NET MAUI. It registers the font across supported targets when you call `UseLucideIcons()` and exposes strongly-typed glyph constants via `LucideIcons` to simplify XAML and C# usage.

## ✨ Features
- ⚙️ **One-line setup**: call `builder.UseLucideIcons()` in `MauiProgram`
- 🔤 **Strongly-typed glyphs** via `LucideIcons.*
- 🧰 **Helper APIs**: `LucideIcons.Create()` for `FontImageSource`
- 📱 **Supported targets**: Android, iOS, Mac Catalyst, Windows

## 📦 Install
```bash
dotnet add package Lucide.Maui
```

## 🚀 Getting Started

### Register
```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseLucideIcons();
```

### XAML usage
```xaml
xmlns:icons="clr-namespace:Lucide.Maui;assembly=Lucide.Maui"

<Image WidthRequest="24" HeightRequest="24">
    <Image.Source>
        <FontImageSource Glyph="{x:Static icons:LucideIcons.AirVent}"
        FontFamily="{x:Static icons:LucideIconsConfig.FontFamily}"
        Color="#2563EB"
        Size="32" />
    </Image.Source>
</Image>

```

or

```xaml
xmlns:icons="clr-namespace:Lucide.Maui;assembly=Lucide.Maui"
xmlns:lucide="clr-namespace:Lucide.Maui.Components;assembly=Lucide.Maui"

<lucide:LucideIcon Icon="{x:Static icons:LucideIcons.AirVent}"
                                   Color="#2563EB"
                                   Size="32"/>

```


### C# usage
```csharp
using Lucide.Maui;

// Create a FontImageSource for any glyph
var source = LucideIconsConfig.Create(LucideIcons.AirVent, Colors.Orange, 32);
```

## 🧩 Platforms
| Platform | Minimum |
|----------|---------|
| Android  | 21+     |
| iOS      | 15+     |
| macOS    | 12+     |
| Windows  | 10 1809 |

## 📄 License
- **Library:** MIT (or your license)
- **Font:** MIT License (confirm redistribution rights; see [license](https://lucide.dev/license))

## 🙏 Attribution
- Lucide font: MIT License © respective owners
- This project is not affiliated with or endorsed by Lucide.
- This project was heavily influenced by https://github.com/jfversluis/IconFont.Maui.FluentIcons and their template repo https://github.com/jfversluis/IconFont.Maui.Template
