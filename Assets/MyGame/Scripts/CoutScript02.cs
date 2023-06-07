using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoutScript02 : MonoBehaviour
{
    public int geldCount; // geld Stand des Spielers
    public int energyCount; // energy count des Spielers
    public int lernCount;  // lern count des Spielers
    public LoadScene loadScene;
    public Button yes,no;
    
    // Start is called before the first frame update
    void Start()
    {
        geldCount = PlayerPrefs.GetInt("geldCount", 0); 
        lernCount = PlayerPrefs.GetInt("lernCount", 0);
        energyCount = PlayerPrefs.GetInt("energyCount", 0);
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
    }
    public void SchlafenKurz()
    {
        energyCount += 35;
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
        Debug.Log("++++++++++++++++++++++++++++++++++++"+gameObject.name);
        yes.interactable = false;
        no.interactable = false;
    }
    public void LoadScene()
    {
        loadScene.NewScene();
    }

}
