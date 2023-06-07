using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
    private int geldCount; // geld Stand des Spielers
    private int energyCount; // energy count des Spielers
    private int lernCount;  // lern count des Spielers
    public LoadScene loadScene;
    public GameObject[] lerncountPNG;
    // Start is called before the first frame update
    void Start()
    {
        geldCount = Random.Range(1, 10);
        lernCount = Random.Range(0, 10);
        energyCount = Random.Range(50, 100);
        PlayerPrefs.SetInt("geldCount", geldCount);
        PlayerPrefs.SetInt("energyCount", energyCount);
        PlayerPrefs.SetInt("lernCount", lernCount);
        loadScene = GetComponent<LoadScene>();
        Debug.Log("Geld:" + geldCount);
        Debug.Log("Lern:" + lernCount);
        Debug.Log("Energie:" + energyCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (geldCount > 10) // ueberprueft ob keiner der counts zu hoch ist
        {
            geldCount--;
            Debug.Log("Count zu hoch");
            PlayerPrefs.SetInt("geldCount", geldCount);
        }
        if (energyCount > 100)
        {
            energyCount--;
            Debug.Log("Count zu hoch");
            PlayerPrefs.SetInt("energyCount", energyCount);
        }
        if (lernCount > 10)
        {
            lernCount--;
            Debug.Log("Count zu hoch");
            PlayerPrefs.SetInt("lernCount", lernCount);
        }
        if (lernCount == 0)
        {
                lerncountPNG[0].gameObject.SetActive(true);
                lerncountPNG[1].gameObject.SetActive(false);
                lerncountPNG[2].gameObject.SetActive(false);
                lerncountPNG[3].gameObject.SetActive(false);
                lerncountPNG[4].gameObject.SetActive(false);
                lerncountPNG[5].gameObject.SetActive(false);
                lerncountPNG[6].gameObject.SetActive(false);
                lerncountPNG[7].gameObject.SetActive(false);
                lerncountPNG[8].gameObject.SetActive(false);
                lerncountPNG[9].gameObject.SetActive(false);
                lerncountPNG[10].gameObject.SetActive(false);
          
        }
        if (lernCount == 1)
        {
            lerncountPNG[1].gameObject.SetActive(true);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 2)
        {
            lerncountPNG[2].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 3)
        {
            lerncountPNG[3].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 4)
        {
            lerncountPNG[4].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 5)
        {
            lerncountPNG[5].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 6)
        {
            lerncountPNG[6].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 7)
        {
            lerncountPNG[7].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 8)
        {
            lerncountPNG[8].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 9)
        {
            lerncountPNG[9].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);
            lerncountPNG[10].gameObject.SetActive(false);

        }
        if (lernCount == 10)
        {
            lerncountPNG[10].gameObject.SetActive(true);
            lerncountPNG[1].gameObject.SetActive(false);
            lerncountPNG[2].gameObject.SetActive(false);
            lerncountPNG[3].gameObject.SetActive(false);
            lerncountPNG[4].gameObject.SetActive(false);
            lerncountPNG[5].gameObject.SetActive(false);
            lerncountPNG[6].gameObject.SetActive(false);
            lerncountPNG[7].gameObject.SetActive(false);
            lerncountPNG[8].gameObject.SetActive(false);
            lerncountPNG[9].gameObject.SetActive(false);
            lerncountPNG[0].gameObject.SetActive(false);

        }
    }
    public void SchlafenKurz()
    {
        energyCount +=35;
        lernCount++;
        PlayerPrefs.SetInt("lernCount", lernCount);
        PlayerPrefs.SetInt("energyCount", energyCount);
    }
    public void SchlafenLang()
    {
        energyCount += 45;
        lernCount--;
        PlayerPrefs.SetInt("lernCount", lernCount);
        PlayerPrefs.SetInt("energyCount", energyCount);
    }
    public void Kaffe()
    {
        energyCount += 10;
        geldCount--;
        PlayerPrefs.SetInt("energyCount", energyCount);
        PlayerPrefs.SetInt("geldCount", geldCount);
    }
    public void Lernen()
    {
        geldCount++;
        energyCount -= 15;
        PlayerPrefs.SetInt("energyCount", energyCount);
        PlayerPrefs.SetInt("geldCount", geldCount);
    }
    public void JedeEntscheidung()
    {
        energyCount -= 10;
        PlayerPrefs.SetInt("energyCount", energyCount);
        Invoke("LoadScene", 2.0f);

    }
    public void LoadScene()
    {
        loadScene.NewScene();
    }

}
