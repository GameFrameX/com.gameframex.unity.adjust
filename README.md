<div align="center">

![GameFrameX Logo](https://download.alianblank.com/gameframex/gameframex_logo_320.png)

# GameFrameX Adjust Package

[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.adjust)](https://github.com/GameFrameX/com.gameframex.unity.adjust)
[![Unity](https://img.shields.io/badge/Unity-2019.4+-green.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/license-MIT+Apache%202.0-orange.svg)](LICENSE.md)
[![Documentation](https://img.shields.io/badge/docs-gameframex.doc.alianblank.com-brightgreen.svg)](https://gameframex.doc.alianblank.com)

**All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams**

[📖 Documentation](https://gameframex.doc.alianblank.com) | [🚀 Quick Start](#quick-start) | [💬 QQ Group: 467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)

---

🌐 **Language**: **English** | [简体中文](./README.zh-CN.md) | [繁體中文](./README.zh-TW.md) | [日本語](./README.ja.md) | [한국어](./README.ko.md)

---

</div>

## 📑 Table of Contents

- [Project Overview](#project-overview)
- [Quick Start](#quick-start)
- [Usage Examples](#usage-examples)
- [Documentation & Resources](#documentation--resources)
- [Community & Support](#community--support)
- [License](#license)

---

## Project Overview

GameFrameX Adjust is an Adjust SDK Unity wrapper based on the GameFrameX framework, providing mobile app attribution and marketing analytics for Unity games.

### Key Features

- 🎯 **Mobile App Attribution** - Track user acquisition sources and campaign performance
- 📊 **Marketing Analytics** - Detailed user behavior and conversion data
- 🔧 **Easy Integration** - Component-based design built on GameFrameX framework
- 📱 **Cross-Platform** - Supports both iOS and Android platforms
- 🛡️ **Privacy Compliance** - Built-in user consent management mechanism

### System Requirements

- Unity 2019.4 or higher
- GameFrameX Framework 1.1.1 or higher
- Adjust Unity SDK 4.38.0

---

## Quick Start

### Installation

#### Method 1: Unity Package Manager (Recommended)

1. Open Unity Package Manager
2. Click the `+` button and select `Add package from git URL`
3. Enter the following URL:
   ```
   https://github.com/gameframex/com.gameframex.unity.adjust.git
   ```

#### Method 2: Manual Installation

1. Download or clone this repository
2. Copy the package folder to your Unity project's `Packages` directory

### Configuration

#### 1. Add Adjust Component

Add the `AdJustComponent` component to a GameObject in your scene.

#### 2. Configure Developer Key and App ID

Configure the following parameters in the `AdJustComponent`:

- **App Token**: Your app token from the Adjust console
- **Log Level**: Adjust log level
- **Environment**: Adjust environment

#### 3. Enable Debug Mode (Optional)

Check the `Debug` option to enable Adjust SDK debug log output.

---

## Usage Examples

### Basic Initialization

The Adjust component will initialize automatically when the game starts. Make sure `AdJustComponent` is added to the scene with correct parameters configured.

### Define Symbol

The package uses the `ENABLE_GAME_FRAME_X_ADJUST` define symbol to control Adjust functionality. Make sure this symbol is defined in your project settings.

### Project Structure

```
Runtime/
├── AdJustComponent.cs          # Adjust Unity Component
├── AdJustManager.cs            # Adjust Manager Implementation
├── IAdJustManager.cs           # Adjust Manager Interface
└── GameFrameXAdJustCroppingHelper.cs  # Code Cropping Helper

Editor/
├── AdJustComponentInspector.cs # Component Inspector
└── GameFrameX.AdJust.Editor.asmdef  # Editor Assembly Definition
```

---

## Documentation & Resources

- 📖 **Documentation**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **Issue Tracker**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.adjust/issues)

---

## Community & Support

- 💬 **QQ Group**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **Feature Requests**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.adjust/discussions)

---

## License

This project is distributed under **MIT License** and **Apache License 2.0** dual licensing.

See full license text: [LICENSE.md](LICENSE.md)

---

<div align="center">

**If this project helps you, please give us a ⭐ Star!**

</div>
