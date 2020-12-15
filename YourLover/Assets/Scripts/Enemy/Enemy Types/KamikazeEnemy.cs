﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeEnemy : Enemy
{
    [SerializeField]
    private GameObject bomb;

    public override void Start()
    {
        base.Start();
        FindPlayer();
        GameObject danger = Instantiate(bomb, transform.position, Quaternion.identity);
        danger.GetComponent<Bomb>().isTaken = true;
        danger.GetComponent<Bomb>().ownerTransform = transform;

        InvokeRepeating("FindTarget", 0f, 1f);
    }

    public override void Update()
    {
        base.Update();
    }
}