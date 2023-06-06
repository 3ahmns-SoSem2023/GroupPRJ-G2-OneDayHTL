using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Scene currentScene;
    public int daycount;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene(); 
    }
    public void NewScene()
    {
        if (daycount<4)
        {
            if (currentScene.name == "SchlafSzene")
            {
                SceneManager.LoadScene("KaffeeSzeneVormittag 1", LoadSceneMode.Single);
                
            }
            if (currentScene.name == "KaffeeSzeneVormittag 1")
            {
                SceneManager.LoadScene("KaffeeSzeneNachmittag", LoadSceneMode.Single);
                
            }
            if (currentScene.name == "KaffeeSzeneNachmittag")
            {
                SceneManager.LoadScene("LernSzene", LoadSceneMode.Single);
                
            }
            if (currentScene.name == "LernSzene")
            {
                SceneManager.LoadScene("SchlafSzene", LoadSceneMode.Single);
                
                daycount++;
            }
        }
       
        if (daycount>=4)
        {
            SceneManager.LoadScene("SchularbeitenSzene", LoadSceneMode.Additive);
        }
    }
}
