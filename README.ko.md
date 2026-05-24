<div align="center">

![GameFrameX Logo](https://download.alianblank.com/gameframex/gameframex_logo_320.png)

# GameFrameX Adjust 패키지

[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.adjust)](https://github.com/GameFrameX/com.gameframex.unity.adjust)
[![Unity](https://img.shields.io/badge/Unity-2019.4+-green.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/license-MIT+Apache%202.0-orange.svg)](LICENSE.md)
[![Documentation](https://img.shields.io/badge/docs-gameframex.doc.alianblank.com-brightgreen.svg)](https://gameframex.doc.alianblank.com)

**인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현**

[📖 문서](https://gameframex.doc.alianblank.com) | [🚀 빠른 시작](#빠른-시작) | [💬 QQ 그룹: 467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)

---

🌐 **언어**: [English](./README.md) | [简体中文](./README.zh-CN.md) | [繁體中文](./README.zh-TW.md) | [日本語](./README.ja.md) | **한국어**

---

</div>

## 📑 목차

- [프로젝트 개요](#프로젝트-개요)
- [빠른 시작](#빠른-시작)
- [사용 예시](#사용-예시)
- [문서 및 자료](#문서-및-자료)
- [커뮤니티 및 지원](#커뮤니티-및-지원)
- [라이선스](#라이선스)

---

## 프로젝트 개요

GameFrameX Adjust는 GameFrameX 프레임워크 기반의 Adjust SDK Unity 래퍼로, Unity 게임에 모바일 앱 어트리뷰션 및 마케팅 분석 기능을 제공합니다.

### 주요 기능

- 🎯 **모바일 앱 어트리뷰션** - 사용자 획득 출처 및 캠페인 성과 추적
- 📊 **마케팅 분석** - 상세한 사용자 행동 및 전환 데이터
- 🔧 **간편한 통합** - GameFrameX 프레임워크 기반 컴포넌트 설계
- 📱 **크로스 플랫폼** - iOS 및 Android 플랫폼 동시 지원
- 🛡️ **개인정보 보호 준수** - 내장 사용자 동의 관리 메커니즘

### 시스템 요구사항

- Unity 2019.4 이상
- GameFrameX 프레임워크 1.1.1 이상
- Adjust Unity SDK 4.38.0

---

## 빠른 시작

### 설치

#### 방법 1: Unity Package Manager (권장)

1. Unity Package Manager를 엽니다
2. `+` 버튼을 클릭하고 `Add package from git URL`을 선택합니다
3. 다음 URL을 입력합니다:
   ```
   https://github.com/gameframex/com.gameframex.unity.adjust.git
   ```

#### 방법 2: 수동 설치

1. 이 저장소를 다운로드하거나 클론합니다
2. 패키지 폴더를 Unity 프로젝트의 `Packages` 디렉토리에 복사합니다

### 설정

#### 1. Adjust 컴포넌트 추가

씬의 GameObject에 `AdJustComponent` 컴포넌트를 추가합니다.

#### 2. 개발자 키 및 앱 ID 설정

`AdJustComponent`에서 다음 매개변수를 설정합니다:

- **App Token**: Adjust 콘솔에서 가져온 앱 토큰
- **Log Level**: Adjust 로그 레벨
- **Environment**: Adjust 환경

#### 3. 디버그 모드 활성화 (선택사항)

`Debug` 옵션을 체크하여 Adjust SDK 디버그 로그 출력을 활성화합니다.

---

## 사용 예시

### 기본 초기화

Adjust 컴포넌트는 게임 시작 시 자동으로 초기화됩니다. 씬에 `AdJustComponent`가 추가되고 올바른 매개변수가 설정되어 있는지 확인하세요.

### 정의 심볼

패키지는 `ENABLE_GAME_FRAME_X_ADJUST` 정의 심볼을 사용하여 Adjust 기능을 제어합니다. 프로젝트 설정에서 이 심볼이 정의되어 있는지 확인하세요.

### 프로젝트 구조

```
Runtime/
├── AdJustComponent.cs          # Adjust Unity 컴포넌트
├── AdJustManager.cs            # Adjust 매니저 구현
├── IAdJustManager.cs           # Adjust 매니저 인터페이스
└── GameFrameXAdJustCroppingHelper.cs  # 코드 크롭핑 헬퍼

Editor/
├── AdJustComponentInspector.cs # 컴포넌트 인스펙터
└── GameFrameX.AdJust.Editor.asmdef  # 에디터 어셈블리 정의
```

---

## 문서 및 자료

- 📖 **전체 문서**: [https://gameframex.doc.alianblank.com](https://gameframex.doc.alianblank.com)
- 🐛 **이슈 트래커**: [GitHub Issues](https://github.com/GameFrameX/com.gameframex.unity.adjust/issues)

---

## 커뮤니티 및 지원

- 💬 **QQ 그룹**: [467608841](https://qm.qq.com/cgi-bin/qm/qr?k=sYFd1nv6m2KZIWFLorZ5pBR0AE5ZhbuL&jump_from=webapi&authKey=oCu+uoL3n35fT5SEt7iLgGtROPxh31n/rHUxRlp0w1f+j38W4tKBuWyRH3KEdwHN)
- 💡 **기능 요청**: [GitHub Discussions](https://github.com/GameFrameX/com.gameframex.unity.adjust/discussions)

---

## 라이선스

이 프로젝트는 **MIT 라이선스** 및 **Apache 라이선스 2.0** 이중 라이선스로 배포됩니다.

전체 라이선스 텍스트 보기: [LICENSE.md](LICENSE.md)

---

<div align="center">

**이 프로젝트가 도움이 되셨다면, ⭐ 별을 주세요!**

</div>
