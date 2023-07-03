using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCtrl : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 10)
        {
            transform.position = new Vector3(circle.transform.position.x, 10, circle.transform.position.y);
        }
    }
}
