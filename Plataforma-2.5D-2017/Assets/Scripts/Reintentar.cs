﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reintentar : MonoBehaviour {



    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(1);
    }



}
