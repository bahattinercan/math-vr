# math-vr

math-vr is an early-stage Unity prototype experimenting with 3D and VR interaction mechanics, including character locomotion, physics-based object manipulation (grabbing and throwing), and raycast-triggered rotational movement. This repository is a personal prototype/demo project, not a maintained product, with the last substantial work committed in 2023.

## Gameplay

- First-person walking, ground alignment, and jump mechanics using Unity's CharacterController: implemented in `Assets/Scripts/PlayerMovement.cs`.
- First-person mouselook camera controls with vertical pitch clamping: implemented in `Assets/Scripts/MouseLook.cs`.
- Viewport raycast detection and interaction that toggles spin direction on objects tagged `RotateCube`: implemented in `Assets/Eray/Scripts/PlayerCTRL.cs`.
- Continuous Y-axis rotation with dynamic direction reversal on target objects: implemented in `Assets/Eray/Scripts/RotateCube.cs`.
- Proximity detection trigger for grabbable objects tagged `Ball`: implemented in `Assets/Eray/Scripts/Grab.cs`.
- Hand-holding, parenting, and directional physics throwing of ball objects: implemented in `Assets/Eray/Scripts/PlayerGrab.cs`.

## Tech Stack

- **Engine:** Unity `2018.4.36f1` (declared in `ProjectSettings/ProjectVersion.txt`)
- **Key Packages & Dependencies:**
  - Google VR SDK for Unity (Daydream and Cardboard support vendored in `Assets/GoogleVR`)
  - `com.unity.xr.oculus.standalone` (`1.38.4`)
  - `com.unity.xr.openvr.standalone` (`1.0.5`)
  - `com.unity.textmeshpro` (`2.1.1`)
  - `com.unity.ugui` (`1.0.0`)
  - `com.unity.modules.vr` (`1.0.0`) / `com.unity.modules.xr` (`1.0.0`)

## Project Structure

| Path | Contents | Type |
| --- | --- | --- |
| `Assets/Scripts/` | First-person player movement (`PlayerMovement.cs`) and mouse view controller (`MouseLook.cs`) | Own code |
| `Assets/Eray/Scripts/` | VR interaction scripts for raycasting, object manipulation, grabbing, and rotation (`Grab.cs`, `PlayerCTRL.cs`, `PlayerGrab.cs`, `RotateCube.cs`) | Own code |
| `Assets/Eray/Materials/` | Test materials (`Box.mat`, `Grass.mat`) | Data |
| `Assets/Material/` | Environment ground material (`ground.mat`) | Data |
| `Assets/Scenes/` | Prototype testing scenes (`Rowleyes_Gameplay.unity`, `Vr_control_scene.unity`) | Data |
| `Assets/GoogleVR/` | Google VR SDK for Unity (Daydream / Cardboard integration, controllers, reticle, audio, demos) | Third-party |
| `Assets/Joystick Pack/` | On-screen mobile virtual joystick controllers and demo scenes | Third-party |
| `Assets/QuarterView 3D Action BE5/` | 3D models, textures, animations, materials, and demo scene | Third-party |
| `Assets/Suriyun/` | Voxel environment art pack with models, textures, and sample scene | Third-party |
| `Packages/` | Unity Package Manager manifest declaring editor and runtime package dependencies | Configuration / Data |
| `ProjectSettings/` | Unity editor, input, tag, layer, graphics, and quality settings | Configuration / Data |

## Running / Building

1. Install Unity Editor version **2018.4.36f1** via the Unity Hub.
2. In Unity Hub, choose **Add** and select the root directory of this repository (`math-vr`).
3. Open the project in Unity 2018.4.36f1.
4. Open one of the prototype scenes located in `Assets/Scenes/`:
   - `Assets/Scenes/Vr_control_scene.unity`: contains the VR interaction testbed with grabbable ball, rotating cube targets, player controller, and hand trigger.
   - `Assets/Scenes/Rowleyes_Gameplay.unity`: contains the first-person character controller testbed with terrain and jump controls.
   - *Note on entry scene:* `ProjectSettings/EditorBuildSettings.asset` contains an empty scenes array (`m_Scenes: []`), so no default entry scene is registered in build settings.
5. Click the **Play** button in the Unity Editor to run the active scene. Testing VR interactions requires a compatible VR headset (Daydream/OpenVR) or editor input simulation.

## Repository Notes

- **Tests:** No automated test suites or testing frameworks are configured in the project.
- **CI/CD:** No continuous integration or deployment pipelines are present.
- **Commit History:** The repository has 9 commits created between October 2022 and January 2023, reflecting collaborative student/exploratory prototyping.
- **Development Status:** This project is an early-stage learning prototype focused on basic VR and first-person interaction tests. Despite the repository name `math-vr`, math-specific gameplay loops or educational systems were not implemented.

## Third-Party Assets

| Folder Path | Description | Licence Status |
| --- | --- | --- |
| `Assets/GoogleVR` | Google VR SDK for Unity providing Daydream and Cardboard support, head tracking, and input systems. | Apache License 2.0 (licence file present at `Assets/GoogleVR/LICENSE`). |
| `Assets/Joystick Pack` | Virtual on-screen dynamic, variable, and fixed joystick components for Unity. | No licence file present in repository (includes `Documentaion.pdf`). |
| `Assets/QuarterView 3D Action BE5` | 3D environment and character asset pack containing models, prefabs, materials, and animations. | No licence file present in repository. |
| `Assets/Suriyun` | Voxel environment asset pack containing 3D models, textures, animations, and sample scenes. | No licence file present in repository. |
