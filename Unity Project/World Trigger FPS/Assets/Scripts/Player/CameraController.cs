using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Parameters
    [SerializeField]
    protected bool InverseY = false;
    protected float Inverse = 1;
    [SerializeField]
    protected Vector2 MouseSensitivity = Vector2.one;
    [SerializeField]
    protected Vector2 ControlSensitivity = Vector2.one;

    // Objects
    [SerializeField]
    private Agent EntityAgent;
    [SerializeField]
    private Camera Cam;
    private Transform EntityTransform;
    [SerializeField]
    private Transform EyeTransform;

    // Variables
    protected float EyePitch = 0;
    protected float EyeYaw = 0;
    public Vector3 CameraRotation = new Vector3();

    protected virtual void Awake()
    {
        EntityTransform = EntityAgent.transform;
        UpdateInverse(InverseY);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void MouseMoveCamera(Vector2 Inputs)
    {
        EyePitch = -Inputs.y * Inverse * EntityAgent.CurrentRotationSpeed.Pitch * GameClock.DeltaTime * MouseSensitivity.y / 1000;
        EyeYaw = Inputs.x * EntityAgent.CurrentRotationSpeed.Yaw * GameClock.DeltaTime * MouseSensitivity.x / 1000;

        Rotate();
        //Debug.Log("MouseMoveCamera");
    }

    public void ControllerMoveCamera(Vector2 Inputs)
    {
        EyePitch = -Inputs.y * Inverse * EntityAgent.CurrentRotationSpeed.Pitch * GameClock.DeltaTime * ControlSensitivity.y;
        EyeYaw = Inputs.x * EntityAgent.CurrentRotationSpeed.Yaw * GameClock.DeltaTime * ControlSensitivity.x;

        Rotate();
        //Debug.Log("ControllerMoveCamera");
    }

    private void Rotate()
    {
        EntityTransform.Rotate(new Vector3(0, EyeYaw, 0), Space.World);
        CameraRotation.x += EyePitch;
        CameraRotation.x = Mathf.Clamp(CameraRotation.x, -90, 90);
        EyeTransform.localEulerAngles = CameraRotation;
    }

    float LocalAngleX(Transform obj, Transform Parent)
    {
        Vector3 objFwd = obj.forward;
        float angle = Vector3.Angle(objFwd, Parent.forward);
        float sign = Mathf.Sign(Vector3.Cross(objFwd, Parent.forward).y);
        return angle * sign;
    }

    public void UpdateInverse(bool Set)
    {
        InverseY = Set;
        Inverse = InverseY ? -1 : 1;
    }
}
