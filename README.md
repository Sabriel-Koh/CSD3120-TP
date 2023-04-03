
# CSD3120 Team Project (Group 6)
This repository contains an interactive application developed by Team 6 for our `CSD3120 - Introduction to Virtual Reality` team project. It serves as both an immersive application, and a research project to gather qualitative data on user studies to both assess, and enhance the `immersion` of the application.

[Click Here](https://github.com/Sabriel-Koh/CSD3120-TP/wiki) to learn more about our research processes.

[Click Here](https://github.com/Sabriel-Koh/CSD3120-TP/wiki/Application-Development-Log) to learn more about our application development logs.


## Table Of Contents
* [Contributors](#Contributors)
* [Project Brief](#Project-Brief)
* [Project Requirements](#Prerequisites)
* [How To Run The Project](#How-To-Run-The-Project)
* [Project Software Architecture](#Software-Architecture)
* [Application Demo](#Application-Demo)

## Contributors
| Name | SIT ID | Contributions
|--|--|--|
| [Koh Chun Rou Sabriel](https://github.com/Sabriel-Koh) | **2001404** | Art Assets / Deployment |
| [Ning Zailin](https://github.com/zachycardia) | **2000892** | Project Setup + Mechanics |
| [Tan Ping Soon Leroy](https://github.com/xGenie97)  | **2001920** | Research + Documentation |
| [David Patrick Dunross Mendoza](https://github.com/ShhPanda)  | **2001005** | Audio Engineer / User Evaluation |
| [Gatchalian Kyle Vincent Velasco](https://github.com/KyleVincentSummer)  | **2000583** | Interactions Scripter |
| [Conor Seow Jun Xian](https://github.com/ConorSeow)  | **2000734** | Video / User Evaluation |

## Project Brief
This project is currently in-development, and a immersive VR application, developed with `Unity` using the `Virtual Reality Toolkit` extension. Users can experience how it is like being a pizza chef as they get to try making their own pizzas by:
| Feature | Control / Description | Status |
|--|--|--|
| **Teleportation** |  Locomotion `Enhance Natural Interaction` | ✔️ |
| **Working in different pizza workstations** | Head Tilt via HMD `Natural Interaction` | ✔️ |
| **Pressing Dough** | Controller `Natural Interaction` |  WIP💻 |
| **Adding Toppings** | Controller `Natural Interaction` Different topping containers drops different types of toppings when you use them and shake them upside down. There will be different toppings such as ***capsicum***, ***pepperoni***, ***mushroom***, and ***sliced tomato***. | ✔️ |
| **Cheese Dispenser** | Controller `Natural Interaction` There will be a dispenser where you can press a button to dispense cheese for your pizza. | ✔️ |
| **Sauce Gun** | Controller `Natural Interaction` There will be a red sauce gun in the scene. If you trigger the gun, it will shoot out ***ketchup***. | ✔️ |
| **Putting / Removing pizza from oven** | Controller `Natural Interaction` | WIP💻 |
| **Pizza Delivery via throwing into delivery hole** | Controller `Natural Interaction` | ✔️ |

The goal of this application development process is to both create as immersive an application as we could, and to also conduct qualitative user studies to access the level of immersion available in the application. With this information, it better guides us as to how we could improve the levels of immersions of the application through the findings and conclusions we get from said user studies.

## Software Architecture
### Folder Structure
Our application's folder structure is organized as follows:
```
├── Assets/
│   ├── Audio/
│   └── DataObjects/
│   └── Materials/
│   └── Prefabs/
│   └── Samples/
│   └── Scenes/
│   └── Scripts/
│   └── TextMesh Pro/
│   └── XR/
│   └── XRI/
│   └── Materials.meta
│   └── Prefabs.meta
│   └── Samples.meta
│   └── Scenes.meta
│   └── Scripts.meta
│   └── TextMesh Pro.meta
│   └── Textures.meta
│   └── XR.meta
│   └── XRI.meta
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/.../.../
├── UserStudies/
│   ├── Initial Prototype User Testing/
|       ├── Flow Questionnaire Results/
|       └── Presence Questionnaire Results/
|       └── Sickness Questionnaire Results/
│   └── Questionnaires/
|       ├── Custom Game Flow Scale Questionnaire.pdf
|       └── Custom Presence Questionnaire.pdf
|       └── Custom Simulation Sickness Questionnaire.pdf
│   └── Release Prototype User Testing/
|       ├── Flow Questionnaire Results/
|       └── Presence Questionnaire Results/
|       └── Sickness Questionnaire Results/
├── .editorconfig
├── .vsconfig
└── README.md
```
### Folder Descriptions
- `Assets/` : This folder contains all the assets that will be used in the application.
- `Assets/Audio` : This folder contains all the sound effects and background music that we will be using in the application.
- `Assets/DataObjects` : This folder stores data for each scriptable object that we create in the game.
- `Packages/` : Project-generated folder used to store any imported packages used.
- `ProjectSettings/` : Contains the Unity Project Settings.
- `UserStudies/` : This folder contains all necessary files and folders required for the user testing portion of this project.
- `UserStudies/Initial Prototype User Testing/` : Contains the user testing data for our initial prototype build.
- `UserStudies/Questionnaires/` : Contains the custom crafted questionnaires for Presence, Flow, Cybersickness.
- `UserStudies/Release Prototype User Testing/` : Contains the user testing data for our release build.

## Prerequisites
To run this application smoothly and without issues, we recommend that you use an `Oculus Quest 2` and a compatible device that meets the minimum system requirements. We recommend this device as the application has been extensively tested with this device.
You will also need to have `Unity` installed, and have at least `Version 2020.3 or later` as the `XR Interaction Toolkit` is only compatible for these versions.

| Prerequisites | Description |
|--|--|
| **Oculus Quest 2 Recommended** | Should be able to access your browser from your HMD. |
| **Unity Version 2021 LTS or later** | If you want to run our build in Unity. |

## How To Run The Project
// Todo give steps on how users will be able to run the project

## Application Demo
// Todo : Link to ~3 min video w/ commentary of the application
