using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Scene currentScene;
    public int daycount;
    public Text dayText; 
    // Start is called before the first frame update
    void Start()
    {
        daycount = PlayerPrefs.GetInt("daycount", 1);
        dayText.text = "Tag: " + daycount;
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        daycount = PlayerPrefs.GetInt("daycount", 0);
    }
    public void NewScene()
    {
        if (daycount < 4)
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
                PlayerPrefs.SetInt("daycount", daycount);
            }
        }

        else
        {
            SceneManager.LoadScene("SchularbeitenSzene", LoadSceneMode.Single);
        }
    }
}
