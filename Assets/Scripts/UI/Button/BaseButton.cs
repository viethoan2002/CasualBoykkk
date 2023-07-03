using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{
    [Header("Base Button")]
    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        this.LoadButton();
        this.AddClickEvent();
    }

    private void AddClickEvent()
    {
        this.button.onClick.AddListener(OnClick);
    }

    public abstract void OnClick();

    private void LoadButton()
    {
        this.button = GetComponent<Button>();
    }
}
