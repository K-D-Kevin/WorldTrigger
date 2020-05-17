// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/WorldTriggerCombatantActions/World Trigger.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace FPS.Input
{
    public class @WorldTriggerInputs : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @WorldTriggerInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""World Trigger"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""f2eb7ba8-2647-41d3-9b56-c974590a2ed1"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""c3766540-8b4e-4f42-b675-21e1eaeb5bbb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""4bbb2580-daf8-4ca4-a2cc-13c4c10ede64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""e834420d-cd99-4484-993f-b710a312a5f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e0d5f8c4-4c4f-4b0a-b603-52189fdd4289"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d464d145-2d82-4bc9-9560-f743c8259d6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""32d7e976-06e0-40e6-9d63-b86c0356cfe6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a811359-1d07-44c8-814e-2c7d0eac6042"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3470c4ea-d788-4ef6-9fea-8f7f18bef51a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""919e9a93-838e-423d-a0a4-9704718d669f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""013227e4-f3c4-4d15-991b-0e6b3b98ecf6"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceSelect"",
                    ""type"": ""PassThrough"",
                    ""id"": ""647bb895-a43a-47eb-8615-7a8d87e0a8c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2,StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad;Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b538604f-0cbd-4b88-bf75-fb5fa1206354"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef57bd6b-9e5d-42cc-bebc-91c32292bdbd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4478f548-15b5-4e00-b2e7-858ff3fa866b"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""932fe797-a0a9-4eef-bd2d-556b362e08d0"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""a4eec388-7afb-4ea0-a83a-cfec130b0a46"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c8ecb446-d80f-4ec6-a6ca-3a38065822ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4be741f9-2449-4de3-9940-998e7003917d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""28e4b330-df63-41ba-b664-895951eb0b0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b8c4fe2b-67c6-4917-ae56-20a3bd39e3fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lean Left"",
                    ""type"": ""Button"",
                    ""id"": ""7c244792-c87f-435f-896d-ef353fd19ac7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lean Right"",
                    ""type"": ""Button"",
                    ""id"": ""e0a618f4-35e2-4260-bf6c-8b888c7766af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attach"",
                    ""type"": ""Button"",
                    ""id"": ""0a643211-81ed-4fb0-b5a3-de5529aec017"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""Button"",
                    ""id"": ""aef8fd8b-c998-4971-b6c4-389ccbab6364"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""fb8c0f78-d85d-4db6-b5ab-0f4268784e2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap To Main Trigger Slot 1"",
                    ""type"": ""Button"",
                    ""id"": ""cac78d34-113e-4ead-bebb-6c7eea2f960a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap To Main Trigger Slot 2"",
                    ""type"": ""Button"",
                    ""id"": ""321ba2f4-55e0-4162-be2b-6bbde598d3a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap To Main Trigger Slot 3"",
                    ""type"": ""Button"",
                    ""id"": ""dcfdfc6d-8131-4988-a012-0bb5586308dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap To Main Trigger Slot 4"",
                    ""type"": ""Button"",
                    ""id"": ""f925b867-4e82-495f-afc5-845cd72f7fa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Swap Right Main Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""86a8332c-9bfc-486d-a583-d5a30dee1067"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Swap Left Main Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""37a87cdb-848f-4654-9607-b172c582f590"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Swap Right Sub Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""289eb92d-a1b4-4ba5-9795-529465ccc537"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Swap Left Sub Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""42c5bcf0-f4fe-4e7b-8754-5bad33016c8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap to Sub Trigger 1"",
                    ""type"": ""Button"",
                    ""id"": ""c4d5e38a-fc95-4724-96f6-5f48ef9bc978"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap to Sub Trigger 2"",
                    ""type"": ""Button"",
                    ""id"": ""0473637e-8efe-499a-8e2d-c3e72c6813e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap to Sub Trigger 3"",
                    ""type"": ""Button"",
                    ""id"": ""4a6a6c03-86df-4910-9b41-4332b07e2a99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap to Sub Trigger 4"",
                    ""type"": ""Button"",
                    ""id"": ""da723daa-64e1-47f9-8792-e729ea99f0a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Info"",
                    ""type"": ""Button"",
                    ""id"": ""606d695c-e870-4944-a3c5-1c511dc48878"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""986c088d-176f-4f54-a3a0-bb0d57d7dc11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""a1f614d8-a1aa-4719-aa42-24689d85bfc0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8180e8bd-4097-4f4e-ab88-4523101a6ce9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c5327b5-f71c-4f60-99c7-4e737386f1d1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e46982e-44cc-431b-9f0b-c11910bf467a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77bff152-3580-4b21-b6de-dcd0c7e41164"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1635d3fe-58b6-4ba9-a4e2-f4b964f6b5c8"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea4d645-4504-4529-b061-ab81934c3752"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Keyboard&Mouse;Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Game Cube Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c7cb130-bcd2-477b-866e-b7a42fb52207"",
                    ""path"": ""<SwitchProControllerHID>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Game Cube Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Touch;Gamepad;Game Cube Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5f5442-8668-4b27-a940-df99bad7e831"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Keyboard&Mouse;Gamepad;Game Cube Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd29d071-3c2d-400d-aa2a-5cadb0a8798e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc17b901-186f-4cf1-9d84-687485943df1"",
                    ""path"": ""<Mouse>/backButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Game Cube Controller"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4d8db61-7a06-445b-9309-fdd5fadca29f"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f916b7f-337b-4000-bc7b-1937941b381c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap To Main Trigger Slot 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a977b7cc-a5be-4975-aeae-4217f7ddf74b"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap To Main Trigger Slot 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e531fafb-d797-46c8-a4f5-9184a4706145"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap To Main Trigger Slot 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82953fe2-59d9-4b39-9d99-90781c659bee"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap To Main Trigger Slot 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68e66519-5032-4ea2-b262-05e7e694ed30"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Toggle Swap Right Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""381f6ec4-edf4-48a1-8c48-dc23ebeb41a8"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Right Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0ac7fea-d6ef-4cec-be92-cc1888c823d9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Right Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ac1d70c2-8c17-4bab-94fe-e7d44104bba8"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Swap Right Sub Trigger"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""9a6860c4-5e1d-4e6b-96bc-926e9362c947"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Toggle Swap Right Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""de94e9c6-4425-419c-8f5c-9ed787f8c104"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Right Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1a8d2056-c44c-4346-8d2a-a635386549f8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Right Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b468a707-81fc-4c91-bb04-51ab4a6ed181"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Toggle Swap Left Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95447f6a-5d78-4c44-af6b-3d0859f424f2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Left Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""2506b56e-89e3-407b-a7b1-956e734c996c"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Swap Left Sub Trigger"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""22423d88-c1bd-4385-8746-6d2ee482f271"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Toggle Swap Left Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""67fd0bc6-ebd3-4b38-b5b4-df6e3d3f841b"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Left Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d335e525-f79d-458a-87bd-d914e06a6a70"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Toggle Swap Left Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11d6eff3-14b9-4d58-bc0f-68c8ec8e3c74"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""445a0fb3-9889-430b-9264-650271901c9a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ad68b86d-4d91-44de-8dcc-6c1be48cb172"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap to Sub Trigger 1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""5984ae15-7bd1-47ab-b313-c15cbbfaa327"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Swap to Sub Trigger 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""a1904f6b-13a5-4108-9499-37601ded9059"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3e01ccca-6a50-4aa8-922e-844ef3f85547"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0ca442a0-e230-4133-9649-9cfd3d69a122"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap to Sub Trigger 2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""c7847b9d-4e15-4f8a-8c56-0988ec93fd83"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Swap to Sub Trigger 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""b233766b-d619-4b40-9641-7ce58d586c38"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f9eeb5a5-ca42-4385-8de7-49f00b17abd1"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c80aed8d-fcfd-4579-87fd-6e178eeeef72"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap to Sub Trigger 3"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""e1637f0f-1a2f-4ca3-9a77-7b2f073ce56a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Swap to Sub Trigger 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""1976e2f6-1a7b-439c-a4c1-7fe68a1e3b46"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f507b5f2-5106-4c89-9808-ec063896fd81"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""8aa3a168-5d01-4aab-9e63-c3299d1b50cc"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap to Sub Trigger 4"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""af0cee72-717a-4a0f-9a80-51a9ba3995a5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Swap to Sub Trigger 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""7e7a8bce-760c-46c7-9ebc-92f75da5bd8c"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d966731b-8cbb-44d2-b88c-03ae933a55d3"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Swap to Sub Trigger 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7339c606-e949-4e9e-94b3-8c626bd36fc2"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Info"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed7ec9e2-d92f-4d0c-aefe-a007cc41fb90"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Info"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06478b69-4c55-4151-bb76-3f98ff7eeeae"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a497dda-dcba-431c-9bc7-58b7b0b27250"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdc507e8-88aa-45e8-a7c4-cf5566558fc0"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""211b2478-90d5-4d70-900d-b2cc457bbad9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""695a57cc-3fa7-4b5e-aba0-8501a4076113"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""402eed88-c6ec-4f88-a983-9ad6a255d888"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": ""Hold(duration=0.6)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afb88195-8a50-4af8-8fa4-8775239359ee"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49e10c0f-b792-4c3e-ac0c-1799ff995c5c"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Hold(duration=0.6)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Touch;Game Cube Controller"",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad6ad4b2-025f-4bbb-afc5-5852879ef9b6"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": ""Hold(duration=0.6)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""574bda5b-bcaa-4e47-b537-367ff1e18b36"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Lean Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b7e9a45-eb7d-4154-8638-c312fa0270c9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Lean Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a10d94d-8449-4c25-9754-a6e9483b1942"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Lean Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e1fcc6f-eecf-4c18-b4a4-469047a26505"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Lean Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9ba539aa-24bc-4752-b425-396f5fdde26c"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attach"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ae0d2738-0f88-4f07-86fa-9598476c84dd"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Attach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""73dc5bfe-2dba-4074-9a4a-346857838558"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Attach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""bddc123f-0320-4ddf-8808-2c53cc20fc91"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attach"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""e649a8f9-eb95-46e8-98a5-c8d8bd7e2069"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Attach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ff39f751-fa4e-4cf7-8f2b-b584388bcc3b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Attach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ca40a9b6-c223-4f13-8a44-15c9cef60c42"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4a945ae-828f-4039-9cc0-07757b804501"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MapPlayer"",
            ""id"": ""a0bbdacf-3928-44f5-947d-e2df44231576"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a978e993-3a08-44e6-8bf1-ed51c6f4bb6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3d30d91-5437-42c4-bc06-f295ae7e215b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""90e5274b-14a1-44c6-8083-cf61fc8572fc"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e758cdfa-48d9-40da-9aff-982296c141d8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3fe97724-520a-423b-b128-80dd3310c3d6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aa80bcc7-f5b3-4214-b6c2-f8910fe8f7d6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""42d3ef46-a335-435b-b0c1-eb63acceecab"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7e6b2857-36b6-45a9-be0c-7c309270453b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""df4b3f52-df79-41e3-ac19-c27c3a1b9439"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""59984cb8-4852-45f1-b96b-9f673c818e0f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6c7215b6-4f48-4df5-a694-c60d6728d65e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad;Joystick;Game Cube Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""85b06d7e-648a-477c-a3a3-91681c2880ed"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""383d6758-ea92-4162-80c4-9af80589d886"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Keyboard&Mouse;Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Astroid"",
            ""id"": ""0b7e18d8-492c-495d-aabe-f2b22599bef6"",
            ""actions"": [
                {
                    ""name"": ""Astroid Charge - Main Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""bb7cf9fa-b11d-4448-8f2f-cec10b64ec2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Astroid Fire- Main Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""71d62ec1-9611-4c95-b0af-2752659befe2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Astroid Charge - Sub Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""ee7f41f7-f2fe-49f9-b3e3-20ab87e1e49c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Astroid Fire - Sub Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""c4a631cd-a297-406a-b165-942d1fc31620"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Astroid Cancel - Main Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""f3ccefac-85b5-4037-b9b0-f9fc1ae73335"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Astroid Cancel - Sub Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""7295eaf4-165b-40d6-b1c5-85b590052cf9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""0688d011-baff-4ca8-b792-b7d452436ee2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7535506-bfa1-48ca-9cde-d084d1200889"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Charge - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acd4ac66-26bd-44d2-8c8f-d7e74af2b8f9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Charge - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfca6c3d-6d5e-43ee-aff4-efc6899e566c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Charge - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e880ed38-9286-4bb4-81c0-19aa93d6b6dc"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Charge - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ab789e0-0bef-412d-91be-ee453aa64fdd"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Fire- Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0557b02c-23a1-4141-9cf1-4d485e35a69a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Fire- Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""875423d2-29e1-4513-afc8-8d2a144c61ef"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Fire - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d49b1219-8362-4c86-b8c7-c011bc1e9ebd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Fire - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16b6f7c0-4246-42a0-a768-c62024bd2873"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7692fee-6505-42f4-b069-cfae8772ccc4"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bc50244-0302-4f89-a80a-9f7696dc2483"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17774983-3ffc-4af8-b7a7-4023abd4d5b3"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e38e8db9-35ef-4008-bbe6-901a139781b4"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Main Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1058807-bacd-4d31-a9a5-3ec89ab6813b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9348f3a4-3644-49b6-a163-eaf2691cc43b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LShift / T"",
                    ""id"": ""fab36a4f-420e-4f7d-90f6-1e2b25f15c30"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""a2195d84-4e89-4179-b902-0e0527dda6fa"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""eb0103e6-733c-4991-a967-8bf9bda31975"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LShift / Y"",
                    ""id"": ""838c302c-f1bd-4c1d-98b4-943a0edc0742"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8f4edea3-19d4-42ea-be4c-7b90046cafff"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""7aff8ae1-c33a-47e9-9a3a-d4d31c0a4a2b"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Gamepad"",
                    ""action"": ""Astroid Cancel - Sub Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""50c83e37-6e82-4f98-8dc8-3ccced495f1c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse;Game Cube Controller"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b614aeff-c317-4a4b-816b-659c3db8fd07"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard&Mouse"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Game Cube Controller"",
            ""bindingGroup"": ""Game Cube Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<SwitchProControllerHID>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
            m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
            m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
            m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
            m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
            m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
            m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
            m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
            m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
            m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
            m_UI_TrackedDeviceSelect = m_UI.FindAction("TrackedDeviceSelect", throwIfNotFound: true);
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
            m_Player_Melee = m_Player.FindAction("Melee", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_LeanLeft = m_Player.FindAction("Lean Left", throwIfNotFound: true);
            m_Player_LeanRight = m_Player.FindAction("Lean Right", throwIfNotFound: true);
            m_Player_Attach = m_Player.FindAction("Attach", throwIfNotFound: true);
            m_Player_Prone = m_Player.FindAction("Prone", throwIfNotFound: true);
            m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
            m_Player_SwapToMainTriggerSlot1 = m_Player.FindAction("Swap To Main Trigger Slot 1", throwIfNotFound: true);
            m_Player_SwapToMainTriggerSlot2 = m_Player.FindAction("Swap To Main Trigger Slot 2", throwIfNotFound: true);
            m_Player_SwapToMainTriggerSlot3 = m_Player.FindAction("Swap To Main Trigger Slot 3", throwIfNotFound: true);
            m_Player_SwapToMainTriggerSlot4 = m_Player.FindAction("Swap To Main Trigger Slot 4", throwIfNotFound: true);
            m_Player_ToggleSwapRightMainTrigger = m_Player.FindAction("Toggle Swap Right Main Trigger", throwIfNotFound: true);
            m_Player_ToggleSwapLeftMainTrigger = m_Player.FindAction("Toggle Swap Left Main Trigger", throwIfNotFound: true);
            m_Player_ToggleSwapRightSubTrigger = m_Player.FindAction("Toggle Swap Right Sub Trigger", throwIfNotFound: true);
            m_Player_ToggleSwapLeftSubTrigger = m_Player.FindAction("Toggle Swap Left Sub Trigger", throwIfNotFound: true);
            m_Player_SwaptoSubTrigger1 = m_Player.FindAction("Swap to Sub Trigger 1", throwIfNotFound: true);
            m_Player_SwaptoSubTrigger2 = m_Player.FindAction("Swap to Sub Trigger 2", throwIfNotFound: true);
            m_Player_SwaptoSubTrigger3 = m_Player.FindAction("Swap to Sub Trigger 3", throwIfNotFound: true);
            m_Player_SwaptoSubTrigger4 = m_Player.FindAction("Swap to Sub Trigger 4", throwIfNotFound: true);
            m_Player_Info = m_Player.FindAction("Info", throwIfNotFound: true);
            m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
            m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
            // MapPlayer
            m_MapPlayer = asset.FindActionMap("MapPlayer", throwIfNotFound: true);
            m_MapPlayer_Move = m_MapPlayer.FindAction("Move", throwIfNotFound: true);
            // Astroid
            m_Astroid = asset.FindActionMap("Astroid", throwIfNotFound: true);
            m_Astroid_AstroidChargeMainTrigger = m_Astroid.FindAction("Astroid Charge - Main Trigger", throwIfNotFound: true);
            m_Astroid_AstroidFireMainTrigger = m_Astroid.FindAction("Astroid Fire- Main Trigger", throwIfNotFound: true);
            m_Astroid_AstroidChargeSubTrigger = m_Astroid.FindAction("Astroid Charge - Sub Trigger", throwIfNotFound: true);
            m_Astroid_AstroidFireSubTrigger = m_Astroid.FindAction("Astroid Fire - Sub Trigger", throwIfNotFound: true);
            m_Astroid_AstroidCancelMainTrigger = m_Astroid.FindAction("Astroid Cancel - Main Trigger", throwIfNotFound: true);
            m_Astroid_AstroidCancelSubTrigger = m_Astroid.FindAction("Astroid Cancel - Sub Trigger", throwIfNotFound: true);
            m_Astroid_Reload = m_Astroid.FindAction("Reload", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_Navigate;
        private readonly InputAction m_UI_Submit;
        private readonly InputAction m_UI_Cancel;
        private readonly InputAction m_UI_Point;
        private readonly InputAction m_UI_Click;
        private readonly InputAction m_UI_ScrollWheel;
        private readonly InputAction m_UI_MiddleClick;
        private readonly InputAction m_UI_RightClick;
        private readonly InputAction m_UI_TrackedDevicePosition;
        private readonly InputAction m_UI_TrackedDeviceOrientation;
        private readonly InputAction m_UI_TrackedDeviceSelect;
        public struct UIActions
        {
            private @WorldTriggerInputs m_Wrapper;
            public UIActions(@WorldTriggerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
            public InputAction @Submit => m_Wrapper.m_UI_Submit;
            public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
            public InputAction @Point => m_Wrapper.m_UI_Point;
            public InputAction @Click => m_Wrapper.m_UI_Click;
            public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
            public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
            public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
            public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
            public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
            public InputAction @TrackedDeviceSelect => m_Wrapper.m_UI_TrackedDeviceSelect;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceSelect.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceSelect;
                    @TrackedDeviceSelect.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceSelect;
                    @TrackedDeviceSelect.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceSelect;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @ScrollWheel.started += instance.OnScrollWheel;
                    @ScrollWheel.performed += instance.OnScrollWheel;
                    @ScrollWheel.canceled += instance.OnScrollWheel;
                    @MiddleClick.started += instance.OnMiddleClick;
                    @MiddleClick.performed += instance.OnMiddleClick;
                    @MiddleClick.canceled += instance.OnMiddleClick;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                    @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                    @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceSelect.started += instance.OnTrackedDeviceSelect;
                    @TrackedDeviceSelect.performed += instance.OnTrackedDeviceSelect;
                    @TrackedDeviceSelect.canceled += instance.OnTrackedDeviceSelect;
                }
            }
        }
        public UIActions @UI => new UIActions(this);

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_Look;
        private readonly InputAction m_Player_Melee;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_LeanLeft;
        private readonly InputAction m_Player_LeanRight;
        private readonly InputAction m_Player_Attach;
        private readonly InputAction m_Player_Prone;
        private readonly InputAction m_Player_Crouch;
        private readonly InputAction m_Player_SwapToMainTriggerSlot1;
        private readonly InputAction m_Player_SwapToMainTriggerSlot2;
        private readonly InputAction m_Player_SwapToMainTriggerSlot3;
        private readonly InputAction m_Player_SwapToMainTriggerSlot4;
        private readonly InputAction m_Player_ToggleSwapRightMainTrigger;
        private readonly InputAction m_Player_ToggleSwapLeftMainTrigger;
        private readonly InputAction m_Player_ToggleSwapRightSubTrigger;
        private readonly InputAction m_Player_ToggleSwapLeftSubTrigger;
        private readonly InputAction m_Player_SwaptoSubTrigger1;
        private readonly InputAction m_Player_SwaptoSubTrigger2;
        private readonly InputAction m_Player_SwaptoSubTrigger3;
        private readonly InputAction m_Player_SwaptoSubTrigger4;
        private readonly InputAction m_Player_Info;
        private readonly InputAction m_Player_Menu;
        private readonly InputAction m_Player_Sprint;
        public struct PlayerActions
        {
            private @WorldTriggerInputs m_Wrapper;
            public PlayerActions(@WorldTriggerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @Look => m_Wrapper.m_Player_Look;
            public InputAction @Melee => m_Wrapper.m_Player_Melee;
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @LeanLeft => m_Wrapper.m_Player_LeanLeft;
            public InputAction @LeanRight => m_Wrapper.m_Player_LeanRight;
            public InputAction @Attach => m_Wrapper.m_Player_Attach;
            public InputAction @Prone => m_Wrapper.m_Player_Prone;
            public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
            public InputAction @SwapToMainTriggerSlot1 => m_Wrapper.m_Player_SwapToMainTriggerSlot1;
            public InputAction @SwapToMainTriggerSlot2 => m_Wrapper.m_Player_SwapToMainTriggerSlot2;
            public InputAction @SwapToMainTriggerSlot3 => m_Wrapper.m_Player_SwapToMainTriggerSlot3;
            public InputAction @SwapToMainTriggerSlot4 => m_Wrapper.m_Player_SwapToMainTriggerSlot4;
            public InputAction @ToggleSwapRightMainTrigger => m_Wrapper.m_Player_ToggleSwapRightMainTrigger;
            public InputAction @ToggleSwapLeftMainTrigger => m_Wrapper.m_Player_ToggleSwapLeftMainTrigger;
            public InputAction @ToggleSwapRightSubTrigger => m_Wrapper.m_Player_ToggleSwapRightSubTrigger;
            public InputAction @ToggleSwapLeftSubTrigger => m_Wrapper.m_Player_ToggleSwapLeftSubTrigger;
            public InputAction @SwaptoSubTrigger1 => m_Wrapper.m_Player_SwaptoSubTrigger1;
            public InputAction @SwaptoSubTrigger2 => m_Wrapper.m_Player_SwaptoSubTrigger2;
            public InputAction @SwaptoSubTrigger3 => m_Wrapper.m_Player_SwaptoSubTrigger3;
            public InputAction @SwaptoSubTrigger4 => m_Wrapper.m_Player_SwaptoSubTrigger4;
            public InputAction @Info => m_Wrapper.m_Player_Info;
            public InputAction @Menu => m_Wrapper.m_Player_Menu;
            public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Melee.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                    @Melee.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                    @Melee.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                    @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @LeanLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeanLeft;
                    @LeanLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeanLeft;
                    @LeanLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeanLeft;
                    @LeanRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeanRight;
                    @LeanRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeanRight;
                    @LeanRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeanRight;
                    @Attach.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttach;
                    @Attach.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttach;
                    @Attach.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttach;
                    @Prone.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnProne;
                    @Prone.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnProne;
                    @Prone.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnProne;
                    @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @SwapToMainTriggerSlot1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot1;
                    @SwapToMainTriggerSlot1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot1;
                    @SwapToMainTriggerSlot1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot1;
                    @SwapToMainTriggerSlot2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot2;
                    @SwapToMainTriggerSlot2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot2;
                    @SwapToMainTriggerSlot2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot2;
                    @SwapToMainTriggerSlot3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot3;
                    @SwapToMainTriggerSlot3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot3;
                    @SwapToMainTriggerSlot3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot3;
                    @SwapToMainTriggerSlot4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot4;
                    @SwapToMainTriggerSlot4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot4;
                    @SwapToMainTriggerSlot4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwapToMainTriggerSlot4;
                    @ToggleSwapRightMainTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapRightMainTrigger;
                    @ToggleSwapRightMainTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapRightMainTrigger;
                    @ToggleSwapRightMainTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapRightMainTrigger;
                    @ToggleSwapLeftMainTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapLeftMainTrigger;
                    @ToggleSwapLeftMainTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapLeftMainTrigger;
                    @ToggleSwapLeftMainTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapLeftMainTrigger;
                    @ToggleSwapRightSubTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapRightSubTrigger;
                    @ToggleSwapRightSubTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapRightSubTrigger;
                    @ToggleSwapRightSubTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapRightSubTrigger;
                    @ToggleSwapLeftSubTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapLeftSubTrigger;
                    @ToggleSwapLeftSubTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapLeftSubTrigger;
                    @ToggleSwapLeftSubTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleSwapLeftSubTrigger;
                    @SwaptoSubTrigger1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger1;
                    @SwaptoSubTrigger1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger1;
                    @SwaptoSubTrigger1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger1;
                    @SwaptoSubTrigger2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger2;
                    @SwaptoSubTrigger2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger2;
                    @SwaptoSubTrigger2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger2;
                    @SwaptoSubTrigger3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger3;
                    @SwaptoSubTrigger3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger3;
                    @SwaptoSubTrigger3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger3;
                    @SwaptoSubTrigger4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger4;
                    @SwaptoSubTrigger4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger4;
                    @SwaptoSubTrigger4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwaptoSubTrigger4;
                    @Info.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInfo;
                    @Info.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInfo;
                    @Info.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInfo;
                    @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                    @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                    @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                    @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Melee.started += instance.OnMelee;
                    @Melee.performed += instance.OnMelee;
                    @Melee.canceled += instance.OnMelee;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @LeanLeft.started += instance.OnLeanLeft;
                    @LeanLeft.performed += instance.OnLeanLeft;
                    @LeanLeft.canceled += instance.OnLeanLeft;
                    @LeanRight.started += instance.OnLeanRight;
                    @LeanRight.performed += instance.OnLeanRight;
                    @LeanRight.canceled += instance.OnLeanRight;
                    @Attach.started += instance.OnAttach;
                    @Attach.performed += instance.OnAttach;
                    @Attach.canceled += instance.OnAttach;
                    @Prone.started += instance.OnProne;
                    @Prone.performed += instance.OnProne;
                    @Prone.canceled += instance.OnProne;
                    @Crouch.started += instance.OnCrouch;
                    @Crouch.performed += instance.OnCrouch;
                    @Crouch.canceled += instance.OnCrouch;
                    @SwapToMainTriggerSlot1.started += instance.OnSwapToMainTriggerSlot1;
                    @SwapToMainTriggerSlot1.performed += instance.OnSwapToMainTriggerSlot1;
                    @SwapToMainTriggerSlot1.canceled += instance.OnSwapToMainTriggerSlot1;
                    @SwapToMainTriggerSlot2.started += instance.OnSwapToMainTriggerSlot2;
                    @SwapToMainTriggerSlot2.performed += instance.OnSwapToMainTriggerSlot2;
                    @SwapToMainTriggerSlot2.canceled += instance.OnSwapToMainTriggerSlot2;
                    @SwapToMainTriggerSlot3.started += instance.OnSwapToMainTriggerSlot3;
                    @SwapToMainTriggerSlot3.performed += instance.OnSwapToMainTriggerSlot3;
                    @SwapToMainTriggerSlot3.canceled += instance.OnSwapToMainTriggerSlot3;
                    @SwapToMainTriggerSlot4.started += instance.OnSwapToMainTriggerSlot4;
                    @SwapToMainTriggerSlot4.performed += instance.OnSwapToMainTriggerSlot4;
                    @SwapToMainTriggerSlot4.canceled += instance.OnSwapToMainTriggerSlot4;
                    @ToggleSwapRightMainTrigger.started += instance.OnToggleSwapRightMainTrigger;
                    @ToggleSwapRightMainTrigger.performed += instance.OnToggleSwapRightMainTrigger;
                    @ToggleSwapRightMainTrigger.canceled += instance.OnToggleSwapRightMainTrigger;
                    @ToggleSwapLeftMainTrigger.started += instance.OnToggleSwapLeftMainTrigger;
                    @ToggleSwapLeftMainTrigger.performed += instance.OnToggleSwapLeftMainTrigger;
                    @ToggleSwapLeftMainTrigger.canceled += instance.OnToggleSwapLeftMainTrigger;
                    @ToggleSwapRightSubTrigger.started += instance.OnToggleSwapRightSubTrigger;
                    @ToggleSwapRightSubTrigger.performed += instance.OnToggleSwapRightSubTrigger;
                    @ToggleSwapRightSubTrigger.canceled += instance.OnToggleSwapRightSubTrigger;
                    @ToggleSwapLeftSubTrigger.started += instance.OnToggleSwapLeftSubTrigger;
                    @ToggleSwapLeftSubTrigger.performed += instance.OnToggleSwapLeftSubTrigger;
                    @ToggleSwapLeftSubTrigger.canceled += instance.OnToggleSwapLeftSubTrigger;
                    @SwaptoSubTrigger1.started += instance.OnSwaptoSubTrigger1;
                    @SwaptoSubTrigger1.performed += instance.OnSwaptoSubTrigger1;
                    @SwaptoSubTrigger1.canceled += instance.OnSwaptoSubTrigger1;
                    @SwaptoSubTrigger2.started += instance.OnSwaptoSubTrigger2;
                    @SwaptoSubTrigger2.performed += instance.OnSwaptoSubTrigger2;
                    @SwaptoSubTrigger2.canceled += instance.OnSwaptoSubTrigger2;
                    @SwaptoSubTrigger3.started += instance.OnSwaptoSubTrigger3;
                    @SwaptoSubTrigger3.performed += instance.OnSwaptoSubTrigger3;
                    @SwaptoSubTrigger3.canceled += instance.OnSwaptoSubTrigger3;
                    @SwaptoSubTrigger4.started += instance.OnSwaptoSubTrigger4;
                    @SwaptoSubTrigger4.performed += instance.OnSwaptoSubTrigger4;
                    @SwaptoSubTrigger4.canceled += instance.OnSwaptoSubTrigger4;
                    @Info.started += instance.OnInfo;
                    @Info.performed += instance.OnInfo;
                    @Info.canceled += instance.OnInfo;
                    @Menu.started += instance.OnMenu;
                    @Menu.performed += instance.OnMenu;
                    @Menu.canceled += instance.OnMenu;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);

        // MapPlayer
        private readonly InputActionMap m_MapPlayer;
        private IMapPlayerActions m_MapPlayerActionsCallbackInterface;
        private readonly InputAction m_MapPlayer_Move;
        public struct MapPlayerActions
        {
            private @WorldTriggerInputs m_Wrapper;
            public MapPlayerActions(@WorldTriggerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_MapPlayer_Move;
            public InputActionMap Get() { return m_Wrapper.m_MapPlayer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MapPlayerActions set) { return set.Get(); }
            public void SetCallbacks(IMapPlayerActions instance)
            {
                if (m_Wrapper.m_MapPlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MapPlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MapPlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MapPlayerActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_MapPlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public MapPlayerActions @MapPlayer => new MapPlayerActions(this);

        // Astroid
        private readonly InputActionMap m_Astroid;
        private IAstroidActions m_AstroidActionsCallbackInterface;
        private readonly InputAction m_Astroid_AstroidChargeMainTrigger;
        private readonly InputAction m_Astroid_AstroidFireMainTrigger;
        private readonly InputAction m_Astroid_AstroidChargeSubTrigger;
        private readonly InputAction m_Astroid_AstroidFireSubTrigger;
        private readonly InputAction m_Astroid_AstroidCancelMainTrigger;
        private readonly InputAction m_Astroid_AstroidCancelSubTrigger;
        private readonly InputAction m_Astroid_Reload;
        public struct AstroidActions
        {
            private @WorldTriggerInputs m_Wrapper;
            public AstroidActions(@WorldTriggerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @AstroidChargeMainTrigger => m_Wrapper.m_Astroid_AstroidChargeMainTrigger;
            public InputAction @AstroidFireMainTrigger => m_Wrapper.m_Astroid_AstroidFireMainTrigger;
            public InputAction @AstroidChargeSubTrigger => m_Wrapper.m_Astroid_AstroidChargeSubTrigger;
            public InputAction @AstroidFireSubTrigger => m_Wrapper.m_Astroid_AstroidFireSubTrigger;
            public InputAction @AstroidCancelMainTrigger => m_Wrapper.m_Astroid_AstroidCancelMainTrigger;
            public InputAction @AstroidCancelSubTrigger => m_Wrapper.m_Astroid_AstroidCancelSubTrigger;
            public InputAction @Reload => m_Wrapper.m_Astroid_Reload;
            public InputActionMap Get() { return m_Wrapper.m_Astroid; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(AstroidActions set) { return set.Get(); }
            public void SetCallbacks(IAstroidActions instance)
            {
                if (m_Wrapper.m_AstroidActionsCallbackInterface != null)
                {
                    @AstroidChargeMainTrigger.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidChargeMainTrigger;
                    @AstroidChargeMainTrigger.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidChargeMainTrigger;
                    @AstroidChargeMainTrigger.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidChargeMainTrigger;
                    @AstroidFireMainTrigger.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidFireMainTrigger;
                    @AstroidFireMainTrigger.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidFireMainTrigger;
                    @AstroidFireMainTrigger.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidFireMainTrigger;
                    @AstroidChargeSubTrigger.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidChargeSubTrigger;
                    @AstroidChargeSubTrigger.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidChargeSubTrigger;
                    @AstroidChargeSubTrigger.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidChargeSubTrigger;
                    @AstroidFireSubTrigger.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidFireSubTrigger;
                    @AstroidFireSubTrigger.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidFireSubTrigger;
                    @AstroidFireSubTrigger.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidFireSubTrigger;
                    @AstroidCancelMainTrigger.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidCancelMainTrigger;
                    @AstroidCancelMainTrigger.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidCancelMainTrigger;
                    @AstroidCancelMainTrigger.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidCancelMainTrigger;
                    @AstroidCancelSubTrigger.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidCancelSubTrigger;
                    @AstroidCancelSubTrigger.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidCancelSubTrigger;
                    @AstroidCancelSubTrigger.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnAstroidCancelSubTrigger;
                    @Reload.started -= m_Wrapper.m_AstroidActionsCallbackInterface.OnReload;
                    @Reload.performed -= m_Wrapper.m_AstroidActionsCallbackInterface.OnReload;
                    @Reload.canceled -= m_Wrapper.m_AstroidActionsCallbackInterface.OnReload;
                }
                m_Wrapper.m_AstroidActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @AstroidChargeMainTrigger.started += instance.OnAstroidChargeMainTrigger;
                    @AstroidChargeMainTrigger.performed += instance.OnAstroidChargeMainTrigger;
                    @AstroidChargeMainTrigger.canceled += instance.OnAstroidChargeMainTrigger;
                    @AstroidFireMainTrigger.started += instance.OnAstroidFireMainTrigger;
                    @AstroidFireMainTrigger.performed += instance.OnAstroidFireMainTrigger;
                    @AstroidFireMainTrigger.canceled += instance.OnAstroidFireMainTrigger;
                    @AstroidChargeSubTrigger.started += instance.OnAstroidChargeSubTrigger;
                    @AstroidChargeSubTrigger.performed += instance.OnAstroidChargeSubTrigger;
                    @AstroidChargeSubTrigger.canceled += instance.OnAstroidChargeSubTrigger;
                    @AstroidFireSubTrigger.started += instance.OnAstroidFireSubTrigger;
                    @AstroidFireSubTrigger.performed += instance.OnAstroidFireSubTrigger;
                    @AstroidFireSubTrigger.canceled += instance.OnAstroidFireSubTrigger;
                    @AstroidCancelMainTrigger.started += instance.OnAstroidCancelMainTrigger;
                    @AstroidCancelMainTrigger.performed += instance.OnAstroidCancelMainTrigger;
                    @AstroidCancelMainTrigger.canceled += instance.OnAstroidCancelMainTrigger;
                    @AstroidCancelSubTrigger.started += instance.OnAstroidCancelSubTrigger;
                    @AstroidCancelSubTrigger.performed += instance.OnAstroidCancelSubTrigger;
                    @AstroidCancelSubTrigger.canceled += instance.OnAstroidCancelSubTrigger;
                    @Reload.started += instance.OnReload;
                    @Reload.performed += instance.OnReload;
                    @Reload.canceled += instance.OnReload;
                }
            }
        }
        public AstroidActions @Astroid => new AstroidActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        private int m_JoystickSchemeIndex = -1;
        public InputControlScheme JoystickScheme
        {
            get
            {
                if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
                return asset.controlSchemes[m_JoystickSchemeIndex];
            }
        }
        private int m_XRSchemeIndex = -1;
        public InputControlScheme XRScheme
        {
            get
            {
                if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
                return asset.controlSchemes[m_XRSchemeIndex];
            }
        }
        private int m_GameCubeControllerSchemeIndex = -1;
        public InputControlScheme GameCubeControllerScheme
        {
            get
            {
                if (m_GameCubeControllerSchemeIndex == -1) m_GameCubeControllerSchemeIndex = asset.FindControlSchemeIndex("Game Cube Controller");
                return asset.controlSchemes[m_GameCubeControllerSchemeIndex];
            }
        }
        public interface IUIActions
        {
            void OnNavigate(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnScrollWheel(InputAction.CallbackContext context);
            void OnMiddleClick(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
            void OnTrackedDevicePosition(InputAction.CallbackContext context);
            void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
            void OnTrackedDeviceSelect(InputAction.CallbackContext context);
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnMelee(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnLeanLeft(InputAction.CallbackContext context);
            void OnLeanRight(InputAction.CallbackContext context);
            void OnAttach(InputAction.CallbackContext context);
            void OnProne(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnSwapToMainTriggerSlot1(InputAction.CallbackContext context);
            void OnSwapToMainTriggerSlot2(InputAction.CallbackContext context);
            void OnSwapToMainTriggerSlot3(InputAction.CallbackContext context);
            void OnSwapToMainTriggerSlot4(InputAction.CallbackContext context);
            void OnToggleSwapRightMainTrigger(InputAction.CallbackContext context);
            void OnToggleSwapLeftMainTrigger(InputAction.CallbackContext context);
            void OnToggleSwapRightSubTrigger(InputAction.CallbackContext context);
            void OnToggleSwapLeftSubTrigger(InputAction.CallbackContext context);
            void OnSwaptoSubTrigger1(InputAction.CallbackContext context);
            void OnSwaptoSubTrigger2(InputAction.CallbackContext context);
            void OnSwaptoSubTrigger3(InputAction.CallbackContext context);
            void OnSwaptoSubTrigger4(InputAction.CallbackContext context);
            void OnInfo(InputAction.CallbackContext context);
            void OnMenu(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
        }
        public interface IMapPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
        public interface IAstroidActions
        {
            void OnAstroidChargeMainTrigger(InputAction.CallbackContext context);
            void OnAstroidFireMainTrigger(InputAction.CallbackContext context);
            void OnAstroidChargeSubTrigger(InputAction.CallbackContext context);
            void OnAstroidFireSubTrigger(InputAction.CallbackContext context);
            void OnAstroidCancelMainTrigger(InputAction.CallbackContext context);
            void OnAstroidCancelSubTrigger(InputAction.CallbackContext context);
            void OnReload(InputAction.CallbackContext context);
        }
    }
}
