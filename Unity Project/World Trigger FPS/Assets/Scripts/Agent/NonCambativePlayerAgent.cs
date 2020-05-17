using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class NonCambativePlayerAgent : Agent
{
    // Parameters
    [SerializeField]
    private float InterJumpDelay = 0.1f;
    private float JumpTimer = 0;
    [SerializeField]
    private float AirControlHeight = 0.5f;
    [SerializeField]
    private LayerMask AirControlLayers;
    [SerializeField]
    private LayerMask JumpLayers;

    // Objects
    [SerializeField]
    private Transform JumpPoint;
    protected Rigidbody PlayerBody;

    // Variables
    protected Vector3 MovementDirection = new Vector3();
    [SerializeField]
    private Transform PreJumpDirection;
    private Vector3 PreJumpVector = new Vector3();

    protected override void Awake()
    {
        base.Awake();
        PlayerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FullAirMove();

        SingleJump();
    }

    protected override Vector3 Jump(Vector3 Direction)
    {
        //Debug.Log("Jumping");
        Vector3 Force = CurrentJumpForce * Direction * GameClock.DeltaTime / 0.2f;
        PlayerBody.AddForce(Force, ForceMode.Impulse);

        PreJumpVector = transform.forward;

        return Force;
    }

    private void LimitedAirMove()
    {
        // When we want the character to stay going in the same direction after jump
        if (Physics.Raycast(JumpPoint.position, -JumpPoint.up, AirControlHeight, JumpLayers))
        {
            MovementDirection.x = Input.GetAxis("Horizontal");
            MovementDirection.z = Input.GetAxis("Vertical");
            float Length = MovementDirection.magnitude;
            MovementDirection.x = MovementDirection.x * GameClock.DeltaTime / Length;
            MovementDirection.z = MovementDirection.z * GameClock.DeltaTime / Length;
            CurrentMovementSpeed.Direction = MovementDirection;
            Controls.Move(CurrentMovementSpeed);
            PreJumpDirection.localRotation = Quaternion.identity;
        }
        else
        {

            PreJumpDirection.forward = PreJumpVector;
            Controls.Move(CurrentMovementSpeed, PreJumpDirection);
        }
    }

    private void FullAirMove()
    {
        float sprintmult = Input.GetAxis("Sprint");
        sprintmult = sprintmult > 0 ? sprintmult * SprintMultiplier : 1;
        MovementDirection.x = Input.GetAxis("Horizontal");
        MovementDirection.z = Input.GetAxis("Vertical");
        float Length = MovementDirection.magnitude;
        MovementDirection.x = MovementDirection.x * GameClock.DeltaTime / Length;
        MovementDirection.z = MovementDirection.z * sprintmult * GameClock.DeltaTime / Length;
        CurrentMovementSpeed.Direction = MovementDirection;
        Controls.Move(CurrentMovementSpeed);
    }

    private void SingleJump()
    {
        if (Input.GetAxis("Jump") > 0 && JumpTimer <= 0)
        {
            //Debug.Log("Jump");
            if (Physics.Raycast(JumpPoint.position, -JumpPoint.up, 0.2f, JumpLayers))
            {
                JumpTimer = InterJumpDelay;
                //Debug.Log("On Ground");
                Jump(transform.up);
            }
        }

        if (JumpTimer > 0)
        {
            JumpTimer -= GameClock.DeltaTime;
        }
    }
}
