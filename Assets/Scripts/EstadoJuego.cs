﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoJuego : MonoBehaviour
{
    public static EstadoJuego estadoJuego;

    private void Awake()
    {
        if (estadoJuego == null)
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }else if (estadoJuego != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start() 
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}