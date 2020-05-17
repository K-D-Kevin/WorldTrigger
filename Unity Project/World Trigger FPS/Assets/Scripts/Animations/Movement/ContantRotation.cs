using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContantRotation : MonoBehaviour
{
    [SerializeField]
    private Vector3 RotationVector = Vector3.zero;
    [SerializeField]
    private bool WorldSpace = true;
    [SerializeField]
    private bool UpdateToDayTime = false;

    // Update is called once per frame
    void Update()
    {
        if (UpdateToDayTime)
        {
            transform.rotation = Quaternion.Euler(GameClock.Clock * RotationVector / 24);
        }
        else
        {
            transform.Rotate(RotationVector * GameClock.DeltaTime, WorldSpace ? Space.World : Space.Self);
        }
    }
}
