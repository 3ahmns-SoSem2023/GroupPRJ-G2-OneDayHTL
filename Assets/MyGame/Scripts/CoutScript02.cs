using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoutScript02 : MonoBehaviour
{
    public GameObject[] energycountPNG;
    public GameObject[] lerncountPNG;
    public GameObject[] geldCountPNG;

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
        for (int i = 0; i < energycountPNG.Length; i++)
        {
            energycountPNG[i].gameObject.SetActive(false);
        }
        if (energyCount == 0)
        {
            energycountPNG[0].gameObject.SetActive(true);
        }
        if (energyCount < 5 && energyCount>0)
        {
           
            energycountPNG[1].gameObject.SetActive(true);

        }
        if (energyCount < 10 && energyCount >= 5)
        {
            
            energycountPNG[2].gameObject.SetActive(true);

        }
        if (energyCount < 15 && energyCount >= 10)
        {
            
            energycountPNG[3].gameObject.SetActive(true);

        }
        if (energyCount < 20 && energyCount >= 15)
        {
           
            energycountPNG[4].gameObject.SetActive(true);

        }
        if (energyCount < 25 && energyCount >= 20)
        {
           
            energycountPNG[5].gameObject.SetActive(true);

        }
        if (energyCount < 30 && energyCount >= 25)
        {
            
            energycountPNG[6].gameObject.SetActive(true);

        }
        if (energyCount < 35 && energyCount >= 30)
        {
            
            energycountPNG[7].gameObject.SetActive(true);

        }
        if (energyCount < 40 && energyCount >= 35)
        {
            
            energycountPNG[8].gameObject.SetActive(true);

        }
        if (energyCount < 45 && energyCount >= 40)
        {
           
            energycountPNG[9].gameObject.SetActive(true);

        }
        if (energyCount < 50 && energyCount >= 45)
        {
            
            energycountPNG[10].gameObject.SetActive(true);

        }
        if (energyCount < 55 && energyCount >= 50)
        {
            
            energycountPNG[11].gameObject.SetActive(true);

        }
        if (energyCount < 60 && energyCount >= 55)
        {
            
            energycountPNG[12].gameObject.SetActive(true);

        }
        if (energyCount < 65 && energyCount >= 60)
        {
            
            energycountPNG[13].gameObject.SetActive(true);

        }
        if (energyCount < 70 && energyCount >= 65)
        {
            
            energycountPNG[14].gameObject.SetActive(true);

        }
        if (energyCount < 75 && energyCount >= 70)
        {
            
            energycountPNG[15].gameObject.SetActive(true);

        }
        if (energyCount < 80 && energyCount >= 75)
        {
            
            energycountPNG[16].gameObject.SetActive(true);

        }
        if (energyCount < 85 && energyCount >= 80)
        {
            
            energycountPNG[17].gameObject.SetActive(true);

        }
        if (energyCount < 90 && energyCount >= 85)
        {
            
            energycountPNG[18].gameObject.SetActive(true);

        }
        if (energyCount < 95 && energyCount >= 90)
        {
            
            energycountPNG[19].gameObject.SetActive(true);

        }
        if (energyCount >= 95)
        {
            
            energycountPNG[20].gameObject.SetActive(true);

        }

        for (int i = 0; i < lerncountPNG.Length; i++)
        {
            lerncountPNG[i].gameObject.SetActive(false);
        }
        if (lernCount == 0)
        {
            lerncountPNG[0].gameObject.SetActive(true);
       

        }
        if (lernCount == 1)
        {
            lerncountPNG[1].gameObject.SetActive(true);


        }
        if (lernCount == 2)
        {
            lerncountPNG[2].gameObject.SetActive(true);
          

        }
        if (lernCount == 3)
        {
            lerncountPNG[3].gameObject.SetActive(true);
       

        }
        if (lernCount == 4)
        {
            lerncountPNG[4].gameObject.SetActive(true);
       
        }
        if (lernCount == 5)
        {
            lerncountPNG[5].gameObject.SetActive(true);
          

        }
        if (lernCount == 6)
        {
            lerncountPNG[6].gameObject.SetActive(true);
          

        }
        if (lernCount == 7)
        {
            lerncountPNG[7].gameObject.SetActive(true);
            

        }
        if (lernCount == 8)
        {
            lerncountPNG[8].gameObject.SetActive(true);
            

        }
        if (lernCount == 9)
        {
            lerncountPNG[9].gameObject.SetActive(true);
            

        }
        if (lernCount == 10)
        {
            lerncountPNG[10].gameObject.SetActive(true);
            

        }
        for (int i = 0; i < geldCountPNG.Length; i++)
        {
            geldCountPNG[i].gameObject.SetActive(false);
        }
        if (geldCount == 1)
        {
            geldCountPNG[1].gameObject.SetActive(true);


        }
        if (geldCount == 2)
        {
            geldCountPNG[2].gameObject.SetActive(true);


        }
        if (geldCount == 3)
        {
            geldCountPNG[3].gameObject.SetActive(true);


        }
        if (geldCount == 4)
        {
            geldCountPNG[4].gameObject.SetActive(true);

        }
        if (geldCount == 5)
        {
            geldCountPNG[5].gameObject.SetActive(true);


        }
        if (geldCount == 6)
        {
            geldCountPNG[6].gameObject.SetActive(true);


        }
        if (geldCount == 7)
        {
            geldCountPNG[7].gameObject.SetActive(true);


        }
        if (geldCount == 8)
        {
            geldCountPNG[8].gameObject.SetActive(true);


        }
        if (geldCount == 9)
        {
            geldCountPNG[9].gameObject.SetActive(true);


        }
        if (lernCount == 10)
        {
            geldCountPNG[10].gameObject.SetActive(true);


        }


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
