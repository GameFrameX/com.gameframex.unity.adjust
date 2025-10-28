# Game Frame X AdJust

Game Frame X AdJust 是一个基于 GameFrameX 框架的 AdJust SDK Unity 包装器，为 Unity 游戏提供移动应用归因和营销分析功能。

## 功能特性

- 🎯 **移动应用归因**: 跟踪用户获取来源和营销活动效果
- 📊 **营销分析**: 提供详细的用户行为和转化数据
- 🔧 **简单集成**: 基于 GameFrameX 框架的组件化设计
- 📱 **跨平台支持**: 同时支持 iOS 和 Android 平台
- 🛡️ **隐私合规**: 内置用户同意管理机制

## 系统要求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本
- AdJust Unity SDK 4.38.0

## 安装

### 通过 Unity Package Manager 安装

1. 打开 Unity Package Manager
2. 点击 "+" 按钮，选择 "Add package from git URL"
3. 输入以下 URL：
   ```
   https://github.com/gameframex/com.gameframex.unity.adjust.git
   ```

### 手动安装

1. 下载或克隆此仓库
2. 将包文件夹复制到你的 Unity 项目的 `Packages` 目录中

## 配置

### 1. 添加 AdJust 组件

在场景中的某个 GameObject 上添加 `AdJustComponent` 组件。

### 2. 配置开发者密钥和应用ID

在 `AdJustComponent` 组件中配置以下参数：

- **App Token**: 从 AdJust 控制台获取的应用 Token
- **Log Level**: AdJust 日志级别
- **Environment**: AdJust 运行环境

### 3. 启用调试模式（可选）

勾选 `Debug` 选项以启用 AdJust SDK 的调试日志输出。

## 使用方法

### 基本初始化

AdJust 组件会在游戏启动时自动初始化。确保在场景中添加了 `AdJustComponent` 并正确配置了相关参数。

### 编译符号

包使用 `ENABLE_GAME_FRAME_X_ADJUST` 编译符号来控制 AdJust 功能的启用。确保在项目设置中定义了此符号。

## 项目结构

```
Runtime/
├── AdJustComponent.cs          # AdJust Unity 组件
├── AdJustManager.cs            # AdJust 管理器实现
├── IAdJustManager.cs           # AdJust 管理器接口
└── GameFrameXAdJustCroppingHelper.cs  # 代码裁剪辅助类

Editor/
├── AdJustComponentInspector.cs # 组件检查器
└── GameFrameX.AdJust.Editor.asmdef  # 编辑器程序集定义
```

## 依赖项

- `com.gameframex.unity`: GameFrameX 核心框架
- `com.adjust.sdk`: AdJust Unity SDK

## 许可证

本项目遵循 MIT 许可证和 Apache 许可证（版本 2.0）。详细信息请查看 [LICENSE](LICENSE.md) 文件。

## 支持

- 文档地址: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/gameframex/com.gameframex.unity.adjust
- 问题反馈: https://github.com/gameframex/com.gameframex.unity.adjust/issues

## 作者

- **Blank** - [alianblank@outlook.com](mailto:alianblank@outlook.com)

---

*独立游戏前后端一体化解决方案，独立游戏开发者的圆梦大使。*
