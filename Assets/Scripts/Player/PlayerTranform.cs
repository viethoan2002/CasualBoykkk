using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTranform : MonoBehaviour
{
    [SerializeField] private Transform positionCharecter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = positionCharecter.position;
    }
}
