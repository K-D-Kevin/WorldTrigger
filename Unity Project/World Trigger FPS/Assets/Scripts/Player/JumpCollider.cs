using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCollider : MonoBehaviour
{
    // Parameters
    [SerializeField]
    private bool CanDoubleJump = false;
    [SerializeField]
    private LayerMask CanJumpLayers;
    [SerializeField]
    private bool DebugJump = false;

    // Objects

    // Debugging Tool Colors
    [SerializeField]
    private Material CollidingMaterial_CanJump;
    [SerializeField]
    private Material CollidingMaterial_CantJump;
    [SerializeField]
    private Material NoCollisionMaterial_CanJump;
    [SerializeField]
    private Material NoCollisionMaterial_CantJump;

    [SerializeField]
    private MeshRenderer MeshRen;

    // Variables
    public bool CanJump { get; set; }
    public bool InAir { get; set; } // Gets Set Jump Collider
    public bool Jumped { get; set; } // Gets Set By the Player Controller
    public bool DoubleJumped { get; set; } // Gets Set By the Player Controller
    public bool EnableDoubleJump {get { return CanDoubleJump; } set { CanDoubleJump = value; } }

    private List<Collider> ActiveCollisions = new List<Collider>();

    private void Awake()
    {
        CanJump = true;
        InAir = false;
        Jumped = false;
        DoubleJumped = false;

        if (DebugJump)
        {
            MeshRen.enabled = true;
            MeshRen.material = CollidingMaterial_CanJump;
        }
        else
        {
            MeshRen.enabled = false;
        }
    }

    //private void Update()
    //{

    //    if (ActiveCollisions.Count > 0)
    //    {
    //        InAir = false;

    //        foreach (Collider collider in ActiveCollisions)
    //        {
    //            if ((CanJumpLayers & 1 << collider.gameObject.layer) == 1 << collider.gameObject.layer)
    //            {
    //                CanJump = true;
    //                Jumped = false;
    //                DoubleJumped = false;
    //                if (DebugJump)
    //                {
    //                    MeshRen.material = CollidingMaterial_CanJump;
    //                }
    //                break;
    //            }
    //            else
    //            {
    //                CanJump = false;
    //                DoubleJumped = false;
    //                if (DebugJump)
    //                {
    //                    MeshRen.material = CollidingMaterial_CantJump;
    //                }
    //            }
    //        }
    //    }
    //    else
    //    {
    //        InAir = true;

    //        if (CanDoubleJump && !DoubleJumped)
    //        {
    //            CanJump = true;
    //            if (DebugJump)
    //            {
    //                MeshRen.material = NoCollisionMaterial_CanJump;
    //            }
    //        }
    //        else
    //        {
    //            CanJump = false;
    //            if (DebugJump)
    //            {
    //                MeshRen.material = NoCollisionMaterial_CantJump;
    //            }
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider collision)
    {
        InAir = false;

        if ((CanJumpLayers & 1 << collision.gameObject.layer) == 1 << collision.gameObject.layer)
        {
            CanJump = true;
            Jumped = false;
            DoubleJumped = false;
            if (DebugJump)
            {
                MeshRen.material = CollidingMaterial_CanJump;
            }
        }
        else
        {
            CanJump = false;
            DoubleJumped = false;
            if (DebugJump)
            {
                MeshRen.material = CollidingMaterial_CantJump;
            }
        }

        ActiveCollisions.Add(collision);
        //Debug.Log("Add Collision: " + collision);
    }

    private void OnTriggerExit(Collider collision)
    {
        ActiveCollisions.Remove(collision);
        //Debug.Log("Remove Collision: " + collision);

        if (ActiveCollisions.Count <= 0)
        {
            InAir = true;

            if (CanDoubleJump && !DoubleJumped)
            {
                CanJump = true;
                if (DebugJump)
                {
                    MeshRen.material = NoCollisionMaterial_CanJump;
                }
            }
            else
            {
                CanJump = false;
                if (DebugJump)
                {
                    MeshRen.material = NoCollisionMaterial_CantJump;
                }
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    InAir = false;

    //    if ((CanJumpLayers & 1 << collision.gameObject.layer) == 1 << collision.gameObject.layer)
    //    {
    //        CanJump = true;
    //        Jumped = false;
    //        DoubleJumped = false;
    //        if (DebugJump)
    //        {
    //            MeshRen.material = CollidingMaterial_CanJump;
    //        }
    //    }
    //    else
    //    {
    //        CanJump = false;
    //        DoubleJumped = false;
    //        if (DebugJump)
    //        {
    //            MeshRen.material = CollidingMaterial_CantJump;
    //        }
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    InAir = true;

    //    if (CanDoubleJump && !DoubleJumped)
    //    {
    //        CanJump = true;
    //        if (DebugJump)
    //        {
    //            MeshRen.material = NoCollisionMaterial_CanJump;
    //        }
    //    }
    //    else
    //    {
    //        CanJump = false;
    //        if (DebugJump)
    //        {
    //            MeshRen.material = NoCollisionMaterial_CantJump;
    //        }
    //    }
    //}


    //private void OnTriggerStay(Collider collision)
    //{
    //    InAir = false;

    //    foreach (Collider collider in ActiveCollisions)
    //    {
    //        if ((CanJumpLayers & 1 << collider.gameObject.layer) == 1 << collider.gameObject.layer)
    //        {
    //            CanJump = true;
    //            Jumped = false;
    //            DoubleJumped = false;
    //            if (DebugJump)
    //            {
    //                MeshRen.material = CollidingMaterial_CanJump;
    //            }
    //            break;
    //        }
    //        else
    //        {
    //            CanJump = false;
    //            DoubleJumped = false;
    //            if (DebugJump)
    //            {
    //                MeshRen.material = CollidingMaterial_CantJump;
    //            }
    //        }
    //    }
    //}
}
