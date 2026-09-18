# FLUXROLL

### A 3D Rolling-Ball Target Collection Game Built with Unity

**FLUXROLL** is a 3D rolling-ball game developed in **Unity 2022.3.62f3**. The player controls a rolling ball inside themed arenas and must collect all available targets before the countdown timer reaches zero.

The current prototype contains two playable environments: **Neon Level** and **Fire Level** - with a complete menu system, timed gameplay, target tracking, pause/resume functionality, win/lose states, level restart, and return-to-menu functionality.

---

## Download & Play

The current release is available as a standalone **Windows 64-bit build**.

### Download

**[Download & Play FLUXROLL v1.0.0](https://github.com/SadhikaRana/FluxRoll/releases/tag/v1.0.0)**

### Requirements

- Windows 10 or later
- 64-bit Windows system
- No Unity installation required

### Running the Game

1. Download the latest Windows release.
2. Extract the downloaded ZIP file.
3. Open the extracted folder.
4. Run `FluxRoll.exe`.

The Windows build is distributed through GitHub Releases rather than as part of the source-code files. GitHub Releases are intended for distributing compiled software and binary assets. :contentReference[oaicite:1]{index=1}

--- 

### Working Demo

#### Fire Level
<img width="1920" height="1080" alt="fire level ss" src="https://github.com/user-attachments/assets/26d88e9d-f5fb-44a6-8051-aa998a396404" />

#### Theme Selection
<img width="1920" height="1080" alt="Theme Selection" src="https://github.com/user-attachments/assets/8cbc1148-8ad9-4148-82ca-29fc6b9ba0bf" />

#### Neon Level
<img width="1920" height="1080" alt="neon level ss" src="https://github.com/user-attachments/assets/262822b0-43fa-44f0-a5dc-e6eb60cb4410" />

#### Main Menu
<img width="1920" height="1080" alt="Main Screen" src="https://github.com/user-attachments/assets/ba01c7e1-b1a1-4a87-81a5-848a087a84ce" />

---

### Gameplay Workflow
<img width="719" height="1024" alt="Game Flow" src="https://github.com/user-attachments/assets/a5345589-f4b1-40a1-9429-51898f88c268" />

---

### Current Platform

- **Platform:** Windows
- **Architecture:** 64-bit
- **Build Type:** Standalone Windows Application
- **Executable:** `FluxRoll.exe`
- **Engine:** Unity 2022.3.62f3
- **Rendering:** Universal Render Pipeline (URP)

---
## Project Structure

The project follows the standard Unity project structure.

```text
FluxRoll/
│
├── Assets/
│   ├── Scenes/
│   │   ├── MainMenu
│   │   ├── ThemeSelect
│   │   ├── FluxRoll
│   │   ├── FireLevel
│   │   └── HowToPlay
│   │
│   ├── Scripts/
│   │   ├── SceneLoader.cs
│   │   ├── GameManager.cs
│   │   ├── TargetPickup.cs
│   │   └── PauseManager.cs
│   │
│   ├── FireEffect/
│   ├── Materials/
│   ├── Settings/
│   └── TextMesh Pro/
│
├── Packages/
├── ProjectSettings/
└── Builds/
```
--- 

### Unity Components Used

The project uses standard Unity systems and components including:

- Unity Scenes
- GameObjects
- Rigidbody physics
- Colliders and trigger colliders
- Cameras
- Directional Lights
- Point Lights
- Particle Systems
- Materials
- TextMeshPro UI
- Canvas UI
-- Buttons
- EventSystem
- Scene Management
- Time Management

TextMeshPro is used for the game's UI text and provides the text formatting and layout system used throughout the menus and HUD.

---

## Key Features

- 3D rolling-ball gameplay
- Two playable themed environments
- Neon Level
- Fire Level with animated fire particle effects
- Seven collectible targets per level
- 30-second countdown timer
- Real-time target counter
- Pause and resume system
- Level restart functionality
- Win and lose states
- Main Menu navigation
- How To Play screen
- Theme selection system
- Windows 64-bit standalone build
- Unity URP-based rendering

---

## Controls

The current Windows build uses keyboard controls for player movement.

| Action | Control |
|---|---|
| Move / Roll | `W` `A` `S` `D` / Arrow Keys |
| Pause | `PAUSE` button |
| Resume | `RESUME` button |
| Restart | `RESTART` button |
| Return to Menu | `MAIN MENU` button |

### Objective

Collect all **7 targets** before the **30-second timer** reaches zero.

- Collect all 7 targets → **YOU WON!**
- Timer reaches 0 before all targets are collected → **TIME'S UP!**

--- 

## Future Development

FLUXROLL is designed to support expansion into a larger multi-level game.

### More Themes

Additional environments can be added while retaining the existing gameplay framework.

Potential themes include:

- Ice
- Forest
- Space
- Cyberpunk
- Desert
- Water
- Volcanic

### Difficulty Levels

Future versions can introduce multiple difficulty levels:

```text
EASY
MEDIUM
HARD
```

Difficulty could modify:

- Time limit
- Number of targets
- Arena layout
- Obstacles
- Target placement
- Player movement parameters

---

### More Levels

The current two playable environments can be expanded into a larger level-based progression system with unique layouts, environments, and challenges.

---

### Dynamic Obstacles

Future levels could include:

- Moving obstacles
- Rotating platforms
- Barriers
- Traps
- Environmental hazards

---

### Power-Ups

Possible power-ups include:

- Speed boost
- Time extension
- Temporary shield
- Target locator
- Slow motion

---

### Mobile Support

A future mobile version could introduce:

- Touch controls
- Virtual joystick
- Mobile-specific UI scaling
- Landscape mobile layout
- Android APK deployment

> The current release is **Windows-only** and is not currently mobile-ready.

---

### Audio System

Future versions can introduce:

- Background music
- Target collection sounds
- Button sounds
- Win/lose sounds
- Theme-specific ambient audio

---

### Progression System

A larger release could include persistent progress and increasing difficulty:

```text
LEVEL 1
   ↓
LEVEL 2
   ↓
LEVEL 3
   ↓
  ...
   ↓
UNLOCK NEW THEMES
```

## Credits & Asset Attribution

### Game Engine

Developed using **Unity 2022.3.62f3** with the **Universal Render Pipeline (URP)**.

### Third-Party Assets

The Fire Level uses a third-party fire sprite-sheet asset for the animated particle effect.

Third-party assets remain subject to their respective licenses and attribution requirements.

All original gameplay logic, scene configuration, UI implementation, level setup, and project-specific code are part of this project unless otherwise stated.


---

## License

This project is currently provided for **educational and demonstration purposes**.

The source code and original project content remain subject to the rights of the project author unless a separate license is provided.

Third-party assets included in the project remain subject to their respective licenses.

For reuse, redistribution, or modification of third-party assets, refer to their original license terms.
