﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageInfo : MonoBehaviour
{
    [SerializeField]
    private Text text;
    public string damage;

    void Start()
    {
        text.text = damage;
        Destroy(gameObject, 0.5f);
    }
}