<div align="center">

![GameFrameX Logo](https://download.alianblank.com/gameframex/gameframex_logo_320.png)

# GameFrameX Adjust 组件

[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.adjust)](https://github.com/GameFrameX/com.gameframex.unity.adjust)
[![Unity](https://img.shields.io/badge/Unity-2019.4+-green.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/license-MIT+Apache%202.0-orange.svg)](LICENSE.md)
[![Documentation](https://img.shields.io/badge/docs-gameframex.doc.alianblank.com-brightgreen.svg)](https://gameframex.doc.alianblank.com)

**独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使**

[📖 文档](https://gameframex.doc.alianblank.com) | [🚀 快速开始](#快速开始) | [💬 QQ群: 467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)

---

🌐 **语言**: [English](./README.md) | **简体中文** | [繁體中文](./README.zh-TW.md) | [日本語](./README.ja.md) | [한국어](./README.ko.md)

---

</div>

## 📑 目录导航

- [项目简介](#项目简介)
- [快速开始](#快速开始)
- [使用示例](#使用示例)
- [文档与资源](#文档与资源)
- [社区与支持](#社区与支持)
- [开源协议](#开源协议)

---

## 项目简介

GameFrameX Adjust 是一个基于 GameFrameX 框架的 Adjust SDK Unity 包装器，为 Unity 游戏提供移动应用归因和营销分析功能。

### 核心特性

- 🎯 **移动应用归因** - 跟踪用户获取来源和营销活动效果
- 📊 **营销分析** - 提供详细的用户行为和转化数据
- 🔧 **简单集成** - 基于 GameFrameX 框架的组件化设计
- 📱 **跨平台支持** - 同时支持 iOS 和 Android 平台
- 🛡️ **隐私合规** - 内置用户同意管理机制

### 系统要求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本
- Adjust Unity SDK 4.38.0

---

## 快速开始

### 安装方式

#### 方式一：Unity Package Manager（推荐）

1. 打开 Unity Package Manager
2. 点击 `+` 按钮，选择 `Add package from git URL`
3. 输入以下 URL：
   ```
   https://github.com/gameframex/com.gameframex.unity.adjust.git
   ```

#### 方式二：手动安装

1. 下载或克隆此仓库
2. 将包文件夹复制到你的 Unity 项目的 `Packages` 目录中

### 配置

#### 1. 添加 Adjust 组件

在场景中的某个 GameObject 上添加 `AdJustComponent` 组件。

#### 2. 配置开发者密钥和应用ID

在 `AdJustComponent` 组件中配置以下参数：

- **App Token**: 从 Adjust 控制台获取的应用 Token
- **Log Level**: Adjust 日志级别
- **Environment**: Adjust 运行环境

#### 3. 启用调试模式（可选）

勾选 `Debug` 选项以启用 Adjust SDK 的调试日志输出。

---

## 使用示例

### 基本初始化

Adjust 组件会在游戏启动时自动初始化。确保在场景中添加了 `AdJustComponent` 并正确配置了相关参数。

### 编译符号

包使用 `ENABLE_GAME_FRAME_X_ADJUST` 编译符号来控制 Adjust 功能的启用。确保在项目设置中定义了此符号。

### 项目结构

```
Runtime/
├── AdJustComponent.cs          # Adjust Unity 组件
├── AdJustManager.cs            # Adjust 管理器实现
├── IAdJustManager.cs           # Adjust 管理器接口
└── GameFrameXAdJustCroppingHelper.cs  # 代码裁剪辅助类

Editor/
├── AdJustComponentInspector.cs # 组件检查器
└── GameFrameX.AdJust.Editor.asmdef  # 编辑器程序集定义
```

---

## 文档与资源

- 📖 **完整文档**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **问题反馈**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.adjust/issues)

---

## 社区与支持

- 💬 **QQ 讨论群**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **功能建议**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.adjust/discussions)

---

## 开源协议

本项目采用 **MIT License** 与 **Apache License 2.0** 双许可证分发。

完整许可证文本请参见: [LICENSE.md](LICENSE.md)

---

<div align="center">

**如果这个项目对你有帮助，请给我们一个 ⭐ Star！**

</div>
