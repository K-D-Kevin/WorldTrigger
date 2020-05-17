using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Movement
{
    [SerializeField]
    private float forward;
    public float Forward { get { return forward; } set { forward = value; UpdateForwardDirection(value); } }
    [SerializeField]
    private float backward;
    public float Backward { get { return backward; } set { backward = value; UpdateBackwardDirection(value); } }
    [SerializeField]
    private float strafe;
    public float Strafe { get { return strafe; } set { strafe = value; UpdateStrafeDirection(value); } }
    [SerializeField]
    private float rise;
    public float Rise { get { return rise; } set { rise = value; UpdateRiseDirection(value); } }
    [SerializeField]
    private float fall;
    public float Fall { get { return fall; } set { fall = value; UpdateFallDirection(value); } }

    private Vector3 direction;
    public Vector3 Direction { get { return direction; } set { direction = value; } }

    public Movement(float ForwardSpeed = 0, float BackwardSpeed = 0, float StrafeSpeed = 0, float RiseSpeed = 0, float FallSpeed = 0, Vector3 MovementDirection = new Vector3())
    {
        forward = ForwardSpeed;
        backward = BackwardSpeed;
        strafe = StrafeSpeed;
        rise = RiseSpeed;
        fall = FallSpeed;
        direction = MovementDirection;
    }

    private void UpdateStrafeDirection(float value)
    {
        if (value > 0)
        {
            direction.x = 1;
        }
        else if (value < 0)
        {
            direction.x = -1;
        }
        else
        {
            direction.x = 0;
        }
    }
    private void UpdateRiseDirection(float value)
    {
        if (value > 0)
        {
            direction.y = 1;
        }
        else if (value < 0)
        {
            direction.y = -1;
        }
        else
        {
            direction.y = 0;
        }
    }
    private void UpdateForwardDirection(float value)
    {
        if (value > 0)
        {
            direction.z = 1;
        }
        else if (value < 0)
        {
            direction.z = -1;
        }
        else
        {
            direction.z = 0;
        }
    }

    private void UpdateFallDirection(float value)
    {
        if (value > 0)
        {
            direction.y = -1;
        }
        else if (value < 0)
        {
            direction.y = 1;
        }
        else
        {
            direction.y = 0;
        }
    }
    private void UpdateBackwardDirection(float value)
    {
        if (value > 0)
        {
            direction.z = -1;
        }
        else if (value < 0)
        {
            direction.z = 1;
        }
        else
        {
            direction.z = 0;
        }
    }

    private static Movement zero = new Movement();
    public static Movement Zero { get { return zero; } }

    private static Movement one = new Movement(1, 1, 1, 1, 1);
    public static Movement One { get { return one; } }

    private static Movement backwardMovement = new Movement(0, 1, 0, 0, 0, new Vector3(0 ,0,-1));
    public static Movement Back { get { return backwardMovement; } }

    private static Movement forwardMovement = new Movement(1, 0, 0, 0, 0, new Vector3(0, 0, 1));
    public static Movement Front { get { return forwardMovement; } }

    private static Movement rightMovement = new Movement(0, 0, 1, 0, 0, new Vector3(1, 0, 0));
    public static Movement Right { get { return rightMovement; } }

    private static Movement leftMovement = new Movement(0, 0, 1, 0, 0, new Vector3(-1, 0, 0));
    public static Movement Left { get { return leftMovement; } }

    private static Movement riseMovement = new Movement(0, 0, 0, 1, 0, new Vector3(0, 1, 0));
    public static Movement Up { get { return riseMovement; } }

    private static Movement fallMovement = new Movement(0, 0, 0, 0, 1, new Vector3(0, -1, 0));
    public static Movement Down { get { return fallMovement; } }

    // Operators
    // Movement Operators
    public static Movement operator +(Movement a) => a;
    public static Movement operator +(Movement a, Movement b) => new Movement(a.Forward + b.Forward, a.Backward + b.Backward, a.Strafe + b.Strafe, a.Rise + b.Rise, a.Fall + b.Fall, (a.direction + b.direction).normalized);
    public static Movement operator -(Movement a) => new Movement(-a.Forward, -a.Backward, -a.Strafe, -a.Rise, -a.Fall, -a.direction);
    public static Movement operator -(Movement a, Movement b) => new Movement(a.Forward - b.Forward, a.Backward - b.Backward, a.Strafe - b.Strafe, a.Rise - b.Rise, a.Fall - b.Fall, (a.direction - b.direction).normalized);
    public static Movement operator *(Movement a, Movement b) => new Movement(a.Forward * b.Forward, a.Backward * b.Backward, a.Strafe*+ b.Strafe, a.Rise * b.Rise, a.Fall * b.Fall, (a.direction + b.direction).normalized);
    public static Movement operator /(Movement a, Movement b)
    {
        if (b.forward == 0 || b.backward == 0 || b.strafe == 0 || b.rise == 0 || b.fall == 0)
        {
            throw new DivideByZeroException();
        }
        return new Movement(a.Forward / b.Forward, a.Backward / b.Backward, a.Strafe / +b.Strafe, a.Rise / b.Rise, a.Fall / b.Fall, (a.direction - b.direction).normalized);
    }

    // Vector3 Operators
    public static Vector3 operator +(Vector3 v, Movement m)
    {
        Vector3 RetunVector = new Vector3();

        RetunVector.z = m.direction.z > 0 ? v.z + m.forward * m.direction.z : v.z + m.backward * m.direction.z;
        RetunVector.y = m.direction.y > 0 ? v.y + m.rise * m.direction.y : v.y + m.fall * m.direction.y;
        RetunVector.x = v.x + m.strafe * m.direction.x;

        return RetunVector;
    }
    public static Vector3 operator -(Vector3 v, Movement m)
    {
        Vector3 RetunVector = new Vector3();

        RetunVector.z = m.direction.z > 0 ? v.z - m.forward * m.direction.z : v.z - m.backward * m.direction.z;
        RetunVector.y = m.direction.y > 0 ? v.y - m.rise * m.direction.y : v.y - m.fall * m.direction.y;
        RetunVector.x = v.x + m.strafe * m.direction.x;

        return RetunVector;
    }
    public static Vector3 operator +(Movement m, Vector3 v)
    {
        Vector3 RetunVector = new Vector3();

        RetunVector.z = m.direction.z > 0 ? v.z + m.forward * m.direction.z : v.z + m.backward * m.direction.z;
        RetunVector.y = m.direction.y > 0 ? v.y + m.rise * m.direction.y : v.y + m.fall * m.direction.y;
        RetunVector.x = v.x + m.strafe * m.direction.x;

        return RetunVector;
    }
    public static Vector3 operator -(Movement m, Vector3 v)
    {
        Vector3 RetunVector = new Vector3();

        RetunVector.z = m.direction.z > 0 ? -v.z + m.forward * m.direction.z : -v.z + m.backward * m.direction.z;
        RetunVector.y = m.direction.y > 0 ? -v.y + m.rise * m.direction.y : -v.y + m.fall * m.direction.y;
        RetunVector.x = -v.x + m.strafe * m.direction.x;

        return RetunVector;
    }
    public static Movement operator *(Vector3 v, Movement m)
    {
        Movement RetunMovement = new Movement(m.forward * v.z, m.backward * v.z, m.strafe * v.x, m.rise * v.y, m.fall * v.y, m.direction);

        return RetunMovement;
    }
    public static Movement operator /(Vector3 v, Movement m)
    {
        if (v.x == 0 || v.y == 0 || v.z == 0)
        {
            throw new DivideByZeroException();
        }
        Movement RetunMovement = new Movement(m.forward / v.z, m.backward / v.z, m.strafe / v.x, m.rise / v.y, m.fall / v.y, m.direction);

        return RetunMovement;
    }
    public static Movement operator *(Movement m, Vector3 v)
    {
        Movement RetunMovement = new Movement(m.forward * v.z, m.backward * v.z, m.strafe * v.x, m.rise * v.y, m.fall * v.y, m.direction);

        return RetunMovement;
    }
    public static Movement operator /(Movement m, Vector3 v)
    {
        if (v.x == 0 || v.y == 0 || v.z == 0)
        {
            throw new DivideByZeroException();
        }
        Movement RetunMovement = new Movement(m.forward / v.z, m.backward / v.z, m.strafe / v.x, m.rise / v.y, m.fall / v.y, m.direction);

        return RetunMovement;
    }

    // Int Operators
    public static Movement operator *(int i, Movement m)
    {
        Movement RetunMovement = new Movement(m.forward * i, m.backward * i, m.strafe * i, m.rise * i, m.fall * i, i * m.direction);

        return RetunMovement;
    }
    public static Movement operator /(int i, Movement m)
    {
        if (m.direction.x == 0 || m.direction.y == 0 || m.direction.z == 0)
        {
            throw new DivideByZeroException();
        }
        Movement RetunMovement = new Movement(m.forward / i, m.backward / i, m.strafe / i, m.rise / i, m.fall / i, new Vector3(i / m.direction.x, i / m.direction.y, i / m.direction.z));

        return RetunMovement;
    }
    public static Movement operator *(Movement m, int i)
    {
        Movement RetunMovement = new Movement(m.forward * i, m.backward * i, m.strafe * i, m.rise * i, m.fall * i, i * m.direction);

        return RetunMovement;
    }
    public static Movement operator /(Movement m, int i)
    {
        if (i == 0)
        {
            throw new DivideByZeroException();
        }
        Movement RetunMovement = new Movement(m.forward / i, m.backward / i, m.strafe / i, m.rise / i, m.fall / i, m.direction / i);

        return RetunMovement;
    }
    public static Movement operator ^(Movement m, int i)
    {
        Movement RetunMovement = new Movement(Mathf.Pow(m.forward, i), Mathf.Pow(m.backward, i), Mathf.Pow(m.strafe, i), Mathf.Pow(m.rise, i), Mathf.Pow(m.fall, i), m.direction);

        return RetunMovement;
    }

    // Float Operators
    public static Movement operator *(float i, Movement m)
    {
        Movement RetunMovement = new Movement(m.forward * i, m.backward * i, m.strafe * i, m.rise * i, m.fall * i, i * m.direction);

        return RetunMovement;
    }
    public static Movement operator /(float i, Movement m)
    {
        if (m.direction.x == 0 || m.direction.y == 0 || m.direction.z == 0)
        {
            throw new DivideByZeroException();
        }
        Movement RetunMovement = new Movement(m.forward / i, m.backward / i, m.strafe / i, m.rise / i, m.fall / i, new Vector3(i / m.direction.x, i / m.direction.y, i / m.direction.z));

        return RetunMovement;
    }
    public static Movement operator *(Movement m, float i)
    {
        Movement RetunMovement = new Movement(m.forward * i, m.backward * i, m.strafe * i, m.rise * i, m.fall * i, i * m.direction);

        return RetunMovement;
    }
    public static Movement operator /(Movement m, float i)
    {
        if (i == 0)
        {
            throw new DivideByZeroException();
        }
        Movement RetunMovement = new Movement(m.forward / i, m.backward / i, m.strafe / i, m.rise / i, m.fall / i, m.direction / i);

        return RetunMovement;
    }
    public static Movement operator ^(Movement m, float i)
    {
        Movement RetunMovement = new Movement(Mathf.Pow(m.forward, i), Mathf.Pow(m.backward, i), Mathf.Pow(m.strafe, i), Mathf.Pow(m.rise, i), Mathf.Pow(m.fall, i), m.direction);

        return RetunMovement;
    }

    // Quaternion Operators
    public static Vector3 operator *(Quaternion v, Movement m)
    {
        Vector3 RetunVector = new Vector3();

        RetunVector.z = m.direction.z > 0 ? m.forward * m.direction.z : m.backward * m.direction.z;
        RetunVector.y = m.direction.y > 0 ? m.rise * m.direction.y : m.fall * m.direction.y;
        RetunVector.x = m.strafe * m.direction.x;

        RetunVector = v * RetunVector;

        return RetunVector;
    }
    public static Vector3 operator *(Movement m, Quaternion v)
    {
        Vector3 RetunVector = new Vector3();

        RetunVector.z = m.direction.z > 0 ? m.forward * m.direction.z : m.backward * m.direction.z;
        RetunVector.y = m.direction.y > 0 ? m.rise * m.direction.y : m.fall * m.direction.y;
        RetunVector.x = m.strafe * m.direction.x;

        RetunVector = v * RetunVector;

        return RetunVector;
    }
}
