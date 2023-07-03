using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance { get; private set; }

    [SerializeField] private FixedJoystick fixedJoystick;
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }
    public bool FireWeapons { get; private set; }
    public event Action OnFire = delegate { };

    private void Start()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        fixedJoystick = GameObject.Find("Fixed Joystick").GetComponent<FixedJoystick>();
    }

    private void Awake()
    {
        InputManager.instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        Horizontal = fixedJoystick.Horizontal;
        Vertical = fixedJoystick.Vertical;
        FireWeapons = Input.GetButtonDown("Fire1");
        if (FireWeapons)
        {
            OnFire();
        }
    }
}
