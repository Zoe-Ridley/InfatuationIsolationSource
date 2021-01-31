using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Function of the rigidbody as known as RB for easier prefix.
    Rigidbody2D rb;
    // Variables of the up/down and right/left for easily addition to the script.
    float horizontal;
    float vertical;
    public FieldOfView fov1;
    public Animator animator;
    float value = 0.0f;

    public AudioSource Movement;

    // This is our public float which we can change in Properties to make our character faster or slower. I've sent it as 0.75 for the best usage of it currently.
    public float MovementSpeed = 5.75f;

    void Start()
    {
        // This is where we are linking the prefix to the Rigidbody in the inspector so it finds it.
        rb = GetComponent<Rigidbody2D>();
        value = 270.0f;
        setFOV(fov1);
    }

    string dir = "none";

    void Update()
    {
        // This will link the variables from before to the correct solution so it changes the movement correctly for input.
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        transform.Find("Sprite").GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt((transform.position.y - 0.3f) * 100f) * -1 - 1000;

        if (horizontal < 0)
        {
            if (!dir.Equals("left"))
            {
                if (!dir.Equals("none"))
                    animator.SetBool(dir, false);
                animator.SetTrigger("Left");
                dir = "left";
                animator.SetBool("left", true);

            }
        }
        else if (horizontal > 0)
        {
            if (!dir.Equals("right"))
            {
                if (!dir.Equals("none"))
                    animator.SetBool(dir, false);
                animator.SetTrigger("Right");
                dir = "right";
                animator.SetBool("right", true);
            }
        }
        else if (vertical < 0)
        {
            if (!dir.Equals("down"))
            {
                if (!dir.Equals("none"))
                    animator.SetBool(dir, false);
                animator.SetTrigger("Down");
                dir = "down";
                animator.SetBool("down", true);
            }
        }
        else if (vertical > 0)
        {
            if (!dir.Equals("up"))
            {
                if (!dir.Equals("none"))
                    animator.SetBool(dir, false);
                animator.SetTrigger("Up");
                dir = "up";
                animator.SetBool("up", true);
            }
        }

        if (horizontal == 0 && vertical == 0)
        {
            if (!dir.Equals("none"))
                animator.SetBool(dir, false);
            dir = "none";
            return;
        }

        value = (float)((System.Math.Atan2(horizontal, -vertical) / System.Math.PI) * 180f);
        setFOV(fov1);
    }

    private void FixedUpdate()
    {
        // This will let us change our character speed in the inspector if we want to customize it. This also lets the character be able to move.
        rb.velocity = new Vector2(horizontal * MovementSpeed, vertical * MovementSpeed);
    }

    public void setFOV(FieldOfView fov)
    {
        fov.origin = transform.position;
        if (value < 0) value += 360f;
        fov.startingAngle = (-90 + value) + (fov.fov / 2);
    }
}

// Staffs Unnamed - GGJ Code