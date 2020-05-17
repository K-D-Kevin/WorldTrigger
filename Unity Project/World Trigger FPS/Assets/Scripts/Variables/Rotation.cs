using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Rotation
{
    /// <summary>
    /// LEFT OFF NOTE: Need to do to this on what we did to movement
    /// </summary>


    // Degrees
    [SerializeField]
    private float pitch;
    public float Pitch
    {
        get { return pitch; }
        set
        {
            pitch = value;
        }
    }
    [SerializeField]
    private float yaw;
    public float Yaw
    {
        get { return yaw; }
        set
        {
            yaw = value;
        }
    }
    [SerializeField]
    private float roll;
    public float Roll
    {
        get { return roll; }
        set
        {
            roll = value;
        }
    }
    public Vector3 Euler { get { return new Vector3(Pitch, Yaw, Roll); } }

    private Vector3 direction;
    public Vector3 Direction { get { return direction; } set { direction = value; } }

    // Radians
    public float PitchRad { get { return Pitch * Mathf.Deg2Rad; } }
    public float YawRad { get { return Yaw * Mathf.Deg2Rad; } }
    public float RollRad { get { return Roll * Mathf.Deg2Rad; } }
    public Vector3 Rad { get { return new Vector3(Pitch, Yaw, Roll); } }

    // Quaternians
    public Quaternion EulerQuat { get { return Quaternion.Euler(PitchRad, YawRad, RollRad); } }
    public float x { get { return EulerQuat.x; } }
    public float y { get { return EulerQuat.y; } }
    public float z { get { return EulerQuat.z; } }
    public float w { get { return EulerQuat.w; } }

    public Rotation(float PitchSpeed = 0, float YawSpeed = 0, float RollSpeed = 0, Vector3 rotationDirection = new Vector3())
    {
        pitch = PitchSpeed;
        yaw = YawSpeed;
        roll = RollSpeed;
        direction = rotationDirection;
    }

    private static Rotation zero = new Rotation();
    public static Rotation Zero { get { return zero; } }

    private static Rotation one = new Rotation(1, 1, 1);
    public static Rotation One { get { return one; } }

    private static Rotation full = new Rotation(360, 360, 360);
    public static Rotation Full { get { return full; } }

    private static Rotation left = new Rotation(0, 1, 0, new Vector3(0, -1, 0));
    public static Rotation Left { get { return left; } }

    private static Rotation right = new Rotation(0, 1, 0, new Vector3(0, 1, 0));
    public static Rotation Right { get { return right; } }

    private static Rotation up = new Rotation(1, 0, 0, new Vector3(1, 0, 0));
    public static Rotation Up { get { return up; } }

    private static Rotation down = new Rotation(1, 0, 0, new Vector3(-1, 0, 0));
    public static Rotation Down { get { return down; } }

    private static Rotation rollRight = new Rotation(0, 0, 1, new Vector3(0, 0, 1));
    public static Rotation RollRight { get { return rollRight; } }

    private static Rotation rollLeft = new Rotation(0, 0, 1, new Vector3(0, 0, -1));
    public static Rotation RollLeft { get { return rollLeft; } }

    // Operators
    // Rottion Operators
    public static Rotation operator +(Rotation a) => a;
    public static Rotation operator +(Rotation a, Rotation b) => new Rotation(a.pitch + b.pitch, a.yaw + b.yaw, a.roll + b.roll, a.direction);
    public static Rotation operator -(Rotation a) => new Rotation(-a.pitch, -a.yaw, -a.roll, -a.direction);
    public static Rotation operator -(Rotation a, Rotation b) => new Rotation(a.pitch - b.pitch, a.yaw - b.yaw, a.roll - b.roll, (a.direction - b.direction).normalized);
    public static Rotation operator *(Rotation a, Rotation b) => new Rotation(a.pitch * b.pitch, a.yaw * b.yaw, a.roll * +b.roll, (a.direction + b.direction).normalized);
    public static Rotation operator /(Rotation a, Rotation b)
    {
        if (b.pitch == 0 || b.yaw == 0 || b.roll == 0)
        {
            throw new DivideByZeroException();
        }
        return new Rotation(a.pitch / b.pitch, a.yaw / b.yaw, a.roll / +b.roll, (a.Direction - b.Direction).normalized);
    }

    // Quaternion Operators
    public static Quaternion operator +(Rotation r, Quaternion q)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = q.z + r.roll * r.direction.z;
        EulerResult.y = q.y + r.yaw * r.direction.y;
        EulerResult.x = q.x + r.pitch * r.direction.x;

        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator -(Rotation r, Quaternion q)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = -q.z + r.roll * r.direction.z;
        EulerResult.y = -q.y + r.yaw * r.direction.y;
        EulerResult.x = -q.x + r.pitch * r.direction.x;

        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator *(Rotation r, Quaternion q)
    {
        Vector3 EulerResult = new Vector3(r.pitch * q.eulerAngles.x, r.yaw * q.eulerAngles.y, r.roll * q.eulerAngles.z);
        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator /(Rotation r, Quaternion q)
    {
        if (q.eulerAngles.x == 0 || q.eulerAngles.y == 0 || q.eulerAngles.z == 0)
        {
            throw new DivideByZeroException();
        }
        Vector3 EulerResult = new Vector3(r.pitch / q.eulerAngles.x, r.yaw / q.eulerAngles.y, r.roll / q.eulerAngles.z);
        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator +(Quaternion q, Rotation r)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = q.z + r.roll * r.direction.z;
        EulerResult.y = q.y + r.yaw * r.direction.y;
        EulerResult.x = q.x + r.pitch * r.direction.x;

        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator -(Quaternion q, Rotation r)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = q.z - r.roll * r.direction.z;
        EulerResult.y = q.y - r.yaw * r.direction.y;
        EulerResult.x = q.x - r.pitch * r.direction.x;

        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator *(Quaternion q, Rotation r)
    {
        Vector3 EulerResult = new Vector3(r.pitch * q.eulerAngles.x, r.yaw * q.eulerAngles.y, r.roll * q.eulerAngles.z);
        return Quaternion.Euler(EulerResult);
    }
    public static Quaternion operator /(Quaternion q, Rotation r)
    {
        if (r.pitch == 0 || r.yaw == 0 || r.roll == 0)
        {
            throw new DivideByZeroException();
        }
        Vector3 EulerResult = new Vector3(q.eulerAngles.x / r.pitch, q.eulerAngles.y / r.yaw, q.eulerAngles.z / r.roll);
        return Quaternion.Euler(EulerResult);
    }

    // Vector3 Operators
    public static Vector3 operator +(Rotation r, Vector3 q)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = q.z + r.roll * r.direction.z;
        EulerResult.y = q.y + r.yaw * r.direction.y;
        EulerResult.x = q.x + r.pitch * r.direction.x;

        return EulerResult;
    }
    public static Vector3 operator -(Rotation r, Vector3 q)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = -q.z + r.roll * r.direction.z;
        EulerResult.y = -q.y + r.yaw * r.direction.y;
        EulerResult.x = -q.x + r.pitch * r.direction.x;

        return EulerResult;
    }
    public static Vector3 operator *(Rotation r, Vector3 q)
    {
        Vector3 EulerResult = new Vector3(r.pitch * q.x, r.yaw * q.y, r.roll * q.z);
        return EulerResult;
    }
    public static Vector3 operator /(Rotation r, Vector3 q)
    {
        if (q.x == 0 || q.y == 0 || q.z == 0)
        {
            throw new DivideByZeroException();
        }
        Vector3 EulerResult = new Vector3(r.pitch / q.x, r.yaw / q.y, r.roll / q.z);
        return EulerResult;
    }
    public static Vector3 operator +(Vector3 q, Rotation r)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = q.z + r.roll * r.direction.z;
        EulerResult.y = q.y + r.yaw * r.direction.y;
        EulerResult.x = q.x + r.pitch * r.direction.x;

        return EulerResult;
    }
    public static Vector3 operator -(Vector3 q, Rotation r)
    {
        Vector3 EulerResult = new Vector3();

        EulerResult.z = q.z - r.roll * r.direction.z;
        EulerResult.y = q.y - r.yaw * r.direction.y;
        EulerResult.x = q.x - r.pitch * r.direction.x;

        return EulerResult;
    }
    public static Vector3 operator *(Vector3 q, Rotation r)
    {
        Vector3 EulerResult = new Vector3(r.pitch * q.x, r.yaw * q.y, r.roll * q.z);
        return EulerResult;
    }
    public static Vector3 operator /(Vector3 q, Rotation r)
    {
        if (r.pitch == 0 || r.yaw == 0 || r.roll == 0)
        {
            throw new DivideByZeroException();
        }
        Vector3 EulerResult = new Vector3(q.x / r.pitch, q.y / r.yaw, q.z / r.roll);
        return EulerResult;
    }

    // Int Operators
    public static Rotation operator *(Rotation r, int q)
    {
        Rotation EulerResult = new Rotation(r.pitch * q, r.yaw * q, r.roll * q, r.direction);
        return EulerResult;
    }
    public static Rotation operator /(Rotation r, int q)
    {
        if (q == 0)
        {
            throw new DivideByZeroException();
        }
        Rotation EulerResult = new Rotation(r.pitch / q, r.yaw / q, r.roll / q, r.direction);
        return EulerResult;
    }
    public static Rotation operator *(int q, Rotation r)
    {
        Rotation EulerResult = new Rotation(r.pitch * q, r.yaw * q, r.roll * q, r.direction);
        return EulerResult;
    }
    public static Rotation operator /(int q, Rotation r)
    {
        if (r.pitch == 0 || r.yaw == 0 || r.roll == 0)
        {
            throw new DivideByZeroException();
        }
        Rotation EulerResult = new Rotation(q / r.pitch, q / r.yaw, q / r.roll, r.direction);
        return EulerResult;
    }

    // Float Operators
    public static Rotation operator *(Rotation r, float q)
    {
        Rotation EulerResult = new Rotation(r.pitch * q, r.yaw * q, r.roll * q, r.direction);
        return EulerResult;
    }
    public static Rotation operator /(Rotation r, float q)
    {
        if (q == 0)
        {
            throw new DivideByZeroException();
        }
        Rotation EulerResult = new Rotation(r.pitch / q, r.yaw / q, r.roll / q, r.direction);
        return EulerResult;
    }
    public static Rotation operator *(float q, Rotation r)
    {
        Rotation EulerResult = new Rotation(r.pitch * q, r.yaw * q, r.roll * q, r.direction);
        return EulerResult;
    }
    public static Rotation operator /(float q, Rotation r)
    {
        if (r.pitch == 0 || r.yaw == 0 || r.roll == 0)
        {
            throw new DivideByZeroException();
        }
        Rotation EulerResult = new Rotation(q / r.pitch, q / r.yaw, q / r.roll, r.direction);
        return EulerResult;
    }
}
