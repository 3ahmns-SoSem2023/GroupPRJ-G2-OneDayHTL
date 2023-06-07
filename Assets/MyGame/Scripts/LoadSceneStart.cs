using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneStart : MonoBehaviour
{
    public Scene currentScene;
    public int daycount = 0;
    // Start is called before the first frame update
    void Start()
    {
        daycount = 0;
        PlayerPrefs.SetInt("daycount", daycount);
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        
    }
    public void NewScene()
    {
        if (daycount < 4)
        {
            if (currentScene.name == "StartScene")
            {
                SceneManager.LoadScene("SchlafSzene", LoadSceneMode.Single);

            }
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
                PlayerPrefs.SetInt("daycount", daycount);
            }
        }

        else
        {
            SceneManager.LoadScene("SchularbeitenSzene", LoadSceneMode.Single);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SchlafSzene", LoadSceneMode.Single);
    }
}
