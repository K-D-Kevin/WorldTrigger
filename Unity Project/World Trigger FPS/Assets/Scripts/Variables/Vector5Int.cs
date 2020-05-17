using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector5Int
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }
    public int w { get; set; }
    public int v { get; set; }

    public Vector5Int(int X = 0, int Y = 0, int Z = 0, int W = 0, int V = 0)
    {
        x = X;
        y = Y;
        z = Z;
        w = W;
        v = V;
    }

    private static Vector5Int zero = new Vector5Int();
    public static Vector5Int Zero { get { return zero; } }

    private static Vector5Int one = new Vector5Int(1, 1, 1, 1, 1);
    public static Vector5Int One { get { return one; } }
}
