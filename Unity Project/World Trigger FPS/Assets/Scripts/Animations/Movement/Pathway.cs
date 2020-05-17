using FPS.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathway : MonoBehaviour
{
    [SerializeField]
    private SpreadMode Spread;
    public SpreadMode PathwaySpread { get { return Spread; } }

    private Transform[] Points;

    public Transform[] PathPoints { get { return Points; } }
    public Transform CurrentPoint { get; set; }

    [SerializeField]
    private Color DebugColor;
    [SerializeField]
    private bool DrawPathway = false;

    [SerializeField]
    private List<PointSpeedParameters> PointParameters = new List<PointSpeedParameters>();
    public List<PointSpeedParameters> Parameters { get { return PointParameters; } }

    private void Awake()
    {
        SetPoints();
    }

    public void OnDrawGizmos()
    {
        if (DrawPathway)
        {
            SetPoints();
            Gizmos.color = DebugColor;
            for (int point = 0; point < Points.Length - 1; point++)
            {
                Gizmos.DrawLine(Points[point].position, Points[point + 1].position);
            }
            //DrawPathway = false;
        }
    }

    public void SetPoints()
    {
        Points = GetComponentsInChildren<Transform>();
        CurrentPoint = Points[1];
    }

    public void SetDraw(bool set)
    {
        DrawPathway = set;
    }
}
