# Pipebound

A dark industrial 2D platformer built with Unity, focused on vertical exploration, combat, checkpoints, progression systems, and atmospheric level design.

---

# Overview

Pipebound is a 2D pixel-art platformer set inside a collapsing underground pipe facility. The player navigates abandoned sewer systems, industrial tunnels, and dangerous vertical structures while fighting enemies, collecting gears, unlocking pathways, and progressing through interconnected levels.

The project focuses on gameplay programming, movement systems, combat mechanics, AI behavior, and industrial-themed world design.

---

# Engine & Tools

- Engine: Unity 2022.3.47f1 LTS
- Language: C#
- IDE: JetBrains Rider
- Version Control: GitHub
- Platform: PC

---

# Unity Version

Unity 2022.3.47f1 LTS

This project was developed using the version above.  
Using different Unity versions may cause compatibility issues.

---

# Core Features

## Player Controller

- Left / Right movement
- Jump system
- Ground detection
- Jump cooldown
- Ladder climbing
- Animation state machine
- Health & damage system
- Shooting system
- Death & respawn logic

---

## Combat System

The player can shoot projectiles using the keyboard.

Features include:

- Projectile prefabs
- Enemy collision detection
- Damage handling
- Attack animations
- Continuous shooting support

---

## Health System

- Segmented health bar
- Damage feedback
- Death state
- Respawn recovery
- UI synchronization between scenes

---

## Enemy AI

### Minion Enemy

- Patrol behavior
- Direction switching
- Collision handling
- Player damage system
- Animation integration

---

## Boss System

- Multi-hit health system
- Rage mode behavior
- Death animation
- Key drop system
- Exit unlocking logic

---

## Progression System

Players progress through levels by:

- Collecting gears
- Unlocking exits
- Activating checkpoints
- Defeating enemies
- Solving traversal obstacles

---

## Gear Collection System

- Dynamic gear counter UI
- Progress tracking
- Door unlocking mechanics
- Objective-based progression

---

## Ladder Climbing System

- Tag-based ladder system
- Climbing movement
- Ladder enter/exit handling
- Gravity adjustments during climbing
- Climbing animation support

---

## Respawn & Checkpoints

- Checkpoint saving
- Delayed respawn
- Position restoration
- Death recovery
- Persistent checkpoint framework

---

# Environment & Visual Direction

Pipebound uses a dark industrial atmosphere inspired by underground sewer systems and abandoned industrial facilities.

Visual direction includes:

- Industrial environments
- Pipe-based architecture
- Metallic structures
- Hazard lighting
- Pixel-art visuals
- Vertical level layouts

---

# Current Level Structure

## Chapter_0

Tutorial level introducing:

- Basic movement
- Jump mechanics
- Early traversal systems

---

## Chapter_1_Demo

First playable gameplay level featuring:

- Enemy encounters
- Ladder traversal
- Collectibles
- Combat systems
- Checkpoint mechanics

---

# Controls

| Action | Key |
|---|---|
| Move Left | A |
| Move Right | D |
| Jump | Space |
| Shoot | G |
| Climb Ladder | W / S |

---

# Project Structure

```txt
Assets/
│
├── Animations/
├── Art/
├── Audio/
├── Prefabs/
├── Scenes/
├── Scripts/
├── UI/
├── Tiles/
└── Resources/
