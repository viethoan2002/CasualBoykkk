using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnmCtrl : MonoBehaviour
{
    [SerializeField] private Animator PlayerAnm;
    [SerializeField] private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        PlayerAnm = GetComponent<Animator>();
        playerRb = GameObject.Find("PlayerCharacter").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector3(playerRb.velocity.x, 0, playerRb.velocity.z).magnitude;
        PlayerAnm.SetFloat("velocity", direction);
    }
}
