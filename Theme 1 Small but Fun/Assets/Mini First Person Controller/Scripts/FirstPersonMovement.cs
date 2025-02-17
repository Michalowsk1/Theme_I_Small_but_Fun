﻿using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    public Transform Respawn;
    public Transform Respawn2;
    public Transform Respawn3;
    [SerializeField] GameObject player;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public static float runSpeed = 9;
    public float jumpVel = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    Rigidbody rigidbody;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey);

        // Get targetMovingSpeed.
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity =new Vector2( Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * jumpVel);

        // Apply movement.
        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Kill")
        {
            player.transform.position = Respawn.position;
        }

        if (collision.gameObject.tag == "Kill2")
        {
            player.transform.position = Respawn2.position;
        }

        if(collision.gameObject.tag == "KillCube")
        {
            player.transform.position = Respawn3.position;
        }
    }
}