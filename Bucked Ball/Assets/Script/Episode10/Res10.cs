﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void RestartGame()
    {
        SceneManager.LoadScene("episode10");
        StartPointKey.say = 0;
    }
}
