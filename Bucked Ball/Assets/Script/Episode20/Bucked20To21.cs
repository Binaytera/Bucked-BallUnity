using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucked20To21 : MonoBehaviour
{
    public GameObject LevelEnd1;
    public AudioSource PuzzleDoneSource;
    void Start()
    {
        Sayac.deger = 0;
        if (LevelEnd1.gameObject == true) { LevelEnd1.gameObject.SetActive(false); }
        LevelEnd1.gameObject.SetActive(false);
    }

    public static float x21 = 0;
    public static float CloseOpen = 0;

    public GameObject Gud;
    public GameObject Medium;
    public GameObject Bad;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //   SceneManager.LoadScene("Menu");
            StartPointKey.say = 0;
            x21 = 1;
            CloseOpen = 1;
            LevelEnd1.gameObject.SetActive(false);
            Gud.SetActive(false);
            Medium.SetActive(false);
            Bad.SetActive(false);
        }
    }
    void Update()
    {
        if (x21 == 1) { level20(); }
        else { return; }
    }

    public void level20()
    {
        StartCoroutine(GetEndLevel());
    }
    public GameObject levels;
    public IEnumerator GetEndLevel()
    {
        yield return new WaitForSeconds(0.50f);

        if (CloseOpen == 1)
        {
            PuzzleDoneSource.Play();
            Debug.Log("B�l�m bitti");
            LevelEnd1.gameObject.SetActive(true);
            levels.gameObject.SetActive(true);
            if (Sayac.deger >= 0 && Sayac.deger <= 17) { Gud.SetActive(true); }
            if (Sayac.deger >= 17 && Sayac.deger <= 25) { Medium.SetActive(true); }
            if (Sayac.deger >= 25) { Bad.SetActive(true); }
            CloseOpen = 0;
            Time.timeScale = 0f;
        }
        else { CloseOpen = 0; }
    }
}
