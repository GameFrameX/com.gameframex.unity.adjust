<div align="center">

![GameFrameX Logo](https://download.alianblank.com/gameframex/gameframex_logo_320.png)

# GameFrameX Adjust 組件

[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.adjust)](https://github.com/GameFrameX/com.gameframex.unity.adjust)
[![Unity](https://img.shields.io/badge/Unity-2019.4+-green.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/license-MIT+Apache%202.0-orange.svg)](LICENSE.md)
[![Documentation](https://img.shields.io/badge/docs-gameframex.doc.alianblank.com-brightgreen.svg)](https://gameframex.doc.alianblank.com)

**獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使**

[📖 文檔](https://gameframex.doc.alianblank.com) | [🚀 快速開始](#快速開始) | [💬 QQ群: 467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)

---

🌐 **語言**: [English](./README.md) | [简体中文](./README.zh-CN.md) | **繁體中文** | [日本語](./README.ja.md) | [한국어](./README.ko.md)

---

</div>

## 📑 目錄導航

- [項目簡介](#項目簡介)
- [快速開始](#快速開始)
- [使用範例](#使用範例)
- [文檔與資源](#文檔與資源)
- [社區與支援](#社區與支援)
- [開源協議](#開源協議)

---

## 項目簡介

GameFrameX Adjust 是一個基於 GameFrameX 框架的 Adjust SDK Unity 包裝器，為 Unity 遊戲提供移動應用歸因和營銷分析功能。

### 核心特性

- 🎯 **移動應用歸因** - 追蹤用戶獲取來源和營銷活動效果
- 📊 **營銷分析** - 提供詳細的用戶行為和轉化數據
- 🔧 **簡單集成** - 基於 GameFrameX 框架的組件化設計
- 📱 **跨平台支援** - 同時支援 iOS 和 Android 平台
- 🛡️ **隱私合規** - 內置用戶同意管理機制

### 系統需求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本
- Adjust Unity SDK 4.38.0

---

## 快速開始

### 安裝方式

#### 方式一：Unity Package Manager（推薦）

1. 打開 Unity Package Manager
2. 點擊 `+` 按鈕，選擇 `Add package from git URL`
3. 輸入以下 URL：
   ```
   https://github.com/gameframex/com.gameframex.unity.adjust.git
   ```

#### 方式二：手動安裝

1. 下載或克隆此倉庫
2. 將包文件夾複製到你的 Unity 項目的 `Packages` 目錄中

### 配置

#### 1. 添加 Adjust 組件

在場景中的某個 GameObject 上添加 `AdJustComponent` 組件。

#### 2. 配置開發者密鑰和應用ID

在 `AdJustComponent` 組件中配置以下參數：

- **App Token**: 從 Adjust 控制台獲取的應用 Token
- **Log Level**: Adjust 日誌級別
- **Environment**: Adjust 運行環境

#### 3. 啟用調試模式（可選）

勾選 `Debug` 選項以啟用 Adjust SDK 的調試日誌輸出。

---

## 使用範例

### 基本初始化

Adjust 組件會在遊戲啟動時自動初始化。確保在場景中添加了 `AdJustComponent` 並正確配置了相關參數。

### 編譯符號

包使用 `ENABLE_GAME_FRAME_X_ADJUST` 編譯符號來控制 Adjust 功能的啟用。確保在項目設置中定義了此符號。

### 項目結構

```
Runtime/
├── AdJustComponent.cs          # Adjust Unity 組件
├── AdJustManager.cs            # Adjust 管理器實現
├── IAdJustManager.cs           # Adjust 管理器介面
└── GameFrameXAdJustCroppingHelper.cs  # 代碼裁剪輔助類

Editor/
├── AdJustComponentInspector.cs # 組件檢視器
└── GameFrameX.AdJust.Editor.asmdef  # 編輯器程序集定義
```

---

## 文檔與資源

- 📖 **完整文檔**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **問題反饋**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.adjust/issues)

---

## 社區與支援

- 💬 **QQ 討論群**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **功能建議**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.adjust/discussions)

---

## 開源協議

本項目採用 **MIT License** 與 **Apache License 2.0** 雙許可證分發。

完整許可證文本請參見: [LICENSE.md](LICENSE.md)

---

<div align="center">

**如果這個項目對你有幫助，請給我們一個 ⭐ Star！**

</div>
