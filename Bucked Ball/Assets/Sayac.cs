using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac : MonoBehaviour
{
    public static float deger = 0;

    void start()
    {
        Debug.Log("Ba�lad�S�re");
        //  StartCoroutine(Sayac1Basla());

    }

    void Update()
    {
        deger += Time.deltaTime;
        Debug.Log("S�re = " + deger.ToString("0.#"));
    }
}
