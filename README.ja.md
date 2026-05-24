<div align="center">

![GameFrameX Logo](https://download.alianblank.com/gameframex/gameframex_logo_320.png)

# GameFrameX Adjust パッケージ

[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.adjust)](https://github.com/GameFrameX/com.gameframex.unity.adjust)
[![Unity](https://img.shields.io/badge/Unity-2019.4+-green.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/license-MIT+Apache%202.0-orange.svg)](LICENSE.md)
[![Documentation](https://img.shields.io/badge/docs-gameframex.doc.alianblank.com-brightgreen.svg)](https://gameframex.doc.alianblank.com)

**インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援**

[📖 ドキュメント](https://gameframex.doc.alianblank.com) | [🚀 クイックスタート](#クイックスタート) | [💬 QQグループ: 467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)

---

🌐 **言語**: [English](./README.md) | [简体中文](./README.zh-CN.md) | [繁體中文](./README.zh-TW.md) | **日本語** | [한국어](./README.ko.md)

---

</div>

## 📑 目次

- [プロジェクト概要](#プロジェクト概要)
- [クイックスタート](#クイックスタート)
- [使用例](#使用例)
- [ドキュメントとリソース](#ドキュメントとリソース)
- [コミュニティとサポート](#コミュニティとサポート)
- [ライセンス](#ライセンス)

---

## プロジェクト概要

GameFrameX Adjustは、GameFrameXフレームワークに基づくAdjust SDK Unityラッパーで、Unityゲームにモバイルアプリのアトリビューションとマーケティング分析機能を提供します。

### 主な機能

- 🎯 **モバイルアプリアトリビューション** - ユーザー獲得ソースとキャンペーン効果の追跡
- 📊 **マーケティング分析** - 詳細なユーザー行動とコンバージョンデータ
- 🔧 **簡単統合** - GameFrameXフレームワークのコンポーネントベース設計
- 📱 **クロスプラットフォーム** - iOSとAndroidプラットフォームの両方をサポート
- 🛡️ **プライバシー準拠** - 組み込みのユーザー同意管理メカニズム

### システム要件

- Unity 2019.4以上
- GameFrameXフレームワーク 1.1.1以上
- Adjust Unity SDK 4.38.0

---

## クイックスタート

### インストール

#### 方法1: Unity Package Manager（推奨）

1. Unity Package Managerを開く
2. `+`ボタンをクリックし、`Add package from git URL`を選択
3. 次のURLを入力：
   ```
   https://github.com/gameframex/com.gameframex.unity.adjust.git
   ```

#### 方法2: 手動インストール

1. このリポジトリをダウンロードまたはクローン
2. パッケージフォルダをUnityプロジェクトの`Packages`ディレクトリにコピー

### 設定

#### 1. Adjustコンポーネントの追加

シーン内のGameObjectに`AdJustComponent`コンポーネントを追加します。

#### 2. 開発者キーとアプリIDの設定

`AdJustComponent`で以下のパラメータを設定します：

- **App Token**: Adjustコンソールから取得したアプリトークン
- **Log Level**: Adjustログレベル
- **Environment**: Adjust環境

#### 3. デバッグモードの有効化（オプション）

`Debug`オプションをチェックして、Adjust SDKのデバッグログ出力を有効にします。

---

## 使用例

### 基本的な初期化

Adjustコンポーネントはゲーム起動時に自動的に初期化されます。シーンに`AdJustComponent`が追加され、正しいパラメータが設定されていることを確認してください。

### 定義シンボル

パッケージは`ENABLE_GAME_FRAME_X_ADJUST`定義シンボルを使用してAdjust機能を制御します。プロジェクト設定でこのシンボルが定義されていることを確認してください。

### プロジェクト構造

```
Runtime/
├── AdJustComponent.cs          # Adjust Unityコンポーネント
├── AdJustManager.cs            # Adjustマネージャー実装
├── IAdJustManager.cs           # Adjustマネージャーインターフェース
└── GameFrameXAdJustCroppingHelper.cs  # コードクロッピングヘルパー

Editor/
├── AdJustComponentInspector.cs # コンポーネントインスペクタ
└── GameFrameX.AdJust.Editor.asmdef  # エディタアセンブリ定義
```

---

## ドキュメントとリソース

- 📖 **ドキュメント**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **イシュートラッカー**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.adjust/issues)

---

## コミュニティとサポート

- 💬 **QQグループ**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **機能リクエスト**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.adjust/discussions)

---

## ライセンス

このプロジェクトは**MIT License**と**Apache License 2.0**の二重ライセンスで配布されています。

完全なライセンステキスト: [LICENSE.md](LICENSE.md)

---

<div align="center">

**このプロジェクトが役立ったら、⭐ をください！**

</div>
