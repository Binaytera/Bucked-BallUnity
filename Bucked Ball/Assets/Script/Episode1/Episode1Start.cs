﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Episode1Start : MonoBehaviour
{
 

    void Start()
    {
        Sayac.deger = 0;
    }

    // Update is called once per frame
   public void Epsode1Start()
    {
       
        SceneManager.LoadScene("episode1");
        
    }
}
