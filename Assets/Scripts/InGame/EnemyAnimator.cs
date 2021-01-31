using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{

    public AIPath path;
    public Animator animator;
    public string dir = "none";

    void Update()
    {
        if (path.desiredVelocity.x >= 0.01f) // Right
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
        else if (path.desiredVelocity.x <= -0.01f) // Left
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
        else if (path.desiredVelocity.y <= -0.01f) // Down
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
        else if (path.desiredVelocity.y >= 0.01f) // Up
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

        if (path.desiredVelocity.x == 0 && path.desiredVelocity.y == 0)
        {
            if (!dir.Equals("none"))
                animator.SetBool(dir, false);
            dir = "none";
            return;
        }
    }
}
