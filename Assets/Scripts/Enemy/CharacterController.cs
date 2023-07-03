using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [Range(0, 2000)]
    [SerializeField] private float movespeed;
    public void Move(Vector3 direction)
    {
        if (direction.magnitude > 0.1f)
        {
            transform.forward = direction;
            var directiongravity = new Vector3(direction.x, -0.5f, direction.z);
            rb.velocity = directiongravity * movespeed * Time.deltaTime;
        }
    }

    public void setSpeed(float speedup)
    {
        this.movespeed = speedup*this.movespeed;
    }
    public float getSpeed()
    {
        return movespeed;
    }
}
