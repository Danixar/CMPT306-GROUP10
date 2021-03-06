﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Transform throwOrigin;
    public GameObject crossPrefab;

    public float throwForce = 20f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Throw();
        }
    }

    void Throw()
    {
        GameObject cross = Instantiate(crossPrefab, throwOrigin.position, throwOrigin.rotation);
        Rigidbody2D rb = cross.GetComponent<Rigidbody2D>();
        rb.AddForce(throwOrigin.up * throwForce, ForceMode2D.Impulse);
    }
}
