using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector5
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
    public float w { get; set; }
    public float v { get; set; }

    public Vector5(float X = 0, float Y = 0, float Z = 0, float W = 0, float V = 0)
    {
        x = X;
        y = Y;
        z = Z;
        w = W;
        v = V;
    }

    private static Vector5 zero = new Vector5();
    public static Vector5 Zero { get { return zero; } }

    private static Vector5 one = new Vector5(1,1,1,1,1);
    public static Vector5 One { get { return one; } }
}
