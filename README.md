# PST Morpheo

## Introduction

Morpheo is a virtual reality project which aims to create an immersive experience for its users. The project uses non newtonian fluid to create a platform that can change texture based on user interaction. The project is still in its early stages, but it has the potential to revolutionize haptic feedback in virtual reality.

## How it works

### Hardware

The hardware setup for Morpheo consists of the following components:

- **VR Headset**: A high-resolution virtual reality headset to provide an immersive visual experience and track hands and head movements.
- **Custom-built Platform**: A platform filled with non newtonian fluid (magnetorheological fluid) that can change its texture based on user interactions. It uses an array of electromagnets to alter the fluid's viscosity.
- **Arduino Microcontroller**: An Arduino board to control the electromagnets based on input from the VR system and the game engine.

### Software

The software part consists of:

- **Unity Game Engine**: The main development environment where the VR experience is created. It handles the 3D environment, user interactions, and communication with the Arduino.
- **Arduino IDE**: Used to program the Arduino microcontroller to control the electromagnets based on signals received from Unity.

### Interaction

Users can interact with the virtual environment using their hands, which are tracked by the VR headset. When a user touches or manipulates virtual objects, the Unity engine sends signals to the Arduino to adjust the electromagnets, changing the texture of the non newtonian fluid on the platform to simulate different sensations.
