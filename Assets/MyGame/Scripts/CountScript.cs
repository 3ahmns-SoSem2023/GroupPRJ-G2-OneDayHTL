using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    private int geldCount; // geld Stand des Spielers
    private int energyCount; // energy count des Spielers
    private int lernCount;  // lern count des Spielers
    // Start is called before the first frame update
    void Start()
    {
        geldCount = Random.Range(0, 10);
        lernCount = Random.Range(0, 10);
        energyCount = Random.Range(50, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (geldCount > 10) // ueberprueft ob keiner der counts zu hoch ist
        {
            geldCount--;
            Debug.Log("Count zu hoch");
        }
        if (energyCount > 100)
        {
            energyCount--;
            Debug.Log("Count zu hoch");
        }
        if (lernCount > 10)
        {
            lernCount--;
            Debug.Log("Count zu hoch");
        }
    }
    public void SchlafenKurz()
    {
        energyCount +=35;
        lernCount++;
    }
    public void SchlafenLang()
    {
        energyCount += 45;
        lernCount--;
    }
    public void Kaffe()
    {
        energyCount += 10;
        geldCount--;
    }
    public void Lernen()
    {
        geldCount++;
        energyCount -= 15;
    }
   public void JedeEntscheidung()
    {
        energyCount -= 10;
    }
}
