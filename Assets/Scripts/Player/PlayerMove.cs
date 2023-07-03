using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: CharacterController
{
    [SerializeField] private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(InputManager.instance.Horizontal, 0, InputManager.instance.Vertical).normalized;
        Move(direction);
    }

    public float GetValueDirection()
    {
        return direction.magnitude;
    }
}
