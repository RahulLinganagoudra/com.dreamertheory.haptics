# Haptics - Unity Cross-Platform Haptic Feedback System

The `Haptics` component provides a simple, cross-platform wrapper for triggering native haptic feedback on iOS and Android devices. It allows developers to trigger **low**, **medium**, **heavy**, and **super heavy** feedback with a single static method call.

[![Unity](https://img.shields.io/badge/Unity-2020%2B-white?logo=unity&labelColor=black)](https://unity.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub Repo stars](https://img.shields.io/github/stars/RahulLinganagoudra/com.dreamertheory.haptics)](https://github.com/RahulLinganagoudra/com.dreamertheory.haptics)
[![Made With ❤️](https://img.shields.io/badge/made%20with-%E2%9D%A4-red)](https://github.com/RahulLinganagoudra)

---

## ✨ Features

- One-line API to trigger device-native haptic feedback.
- Auto-platform detection (iOS / Android).
- Optional toggle to enable/disable haptics globally.
- Uses native iOS and Android APIs under the hood.
- Fallback to `Handheld.Vibrate()` for super-heavy feedback.

---

## 🔧 Installation

### Steps

1. Open Unity.
2. Go to **Window → Package Manager**.
3. Click the **+** button (top-left).
4. Select **Add package from Git URL…**.
5. Paste the following:
```bash
https://github.com/RahulLinganagoudra/com.dreamertheory.haptics.git
```
## 🚀Usage
###### Quick Start
Just call any of the static methods from anywhere in your game:
``` cs :
DT.Haptics.Haptics.CanUseHaptics = false; // disables all haptic calls
DT.Haptics.Haptics.PlayLowHaptics();
DT.Haptics.Haptics.PlayMidHaptics();
DT.Haptics.Haptics.PlayHeavyHaptics();
DT.Haptics.Haptics.PlaySuperHeavyHaptics();
```
