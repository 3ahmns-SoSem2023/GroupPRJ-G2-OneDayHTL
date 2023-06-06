using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Noten : MonoBehaviour
{
    public Text glueckwunschText; 
    public Text note;
    public int notenZahl;
    public CoutScript02 countScript02;
    public Button abgeben;

    // Start is called before the first frame update
    void Start()
    {
        countScript02 = GetComponent<CoutScript02>();
    }

    public void NoteBerechnen()
    {
        if (countScript02.lernCount <= 2)
        {
            notenZahl = 5;
        }

        if (countScript02.lernCount <= 5 && countScript02.lernCount > 2)
        {
            notenZahl = 4;
        }

        if (countScript02.lernCount <= 7 && countScript02.lernCount > 5)
        {
            notenZahl = 3;
        }

        if (countScript02.lernCount <= 9 && countScript02.lernCount > 7)
        {
            notenZahl = 2;
        }

        if (countScript02.lernCount > 9)
        {
            notenZahl = 1;
        }

        if (countScript02.energyCount < 50)
        {
            notenZahl--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Abgeben() == true)
        {
            if (notenZahl < 4)
            {
                glueckwunschText.text = "Gratuliere du hast die Prüfung bestanden, deine Note ist: ";
            }

            else
            {
                glueckwunschText.text = "Du bist leider durchgefallen";
            }
        }
    }

    public bool Abgeben()
    {
        bool abgegeben = true;
        return abgegeben;
        abgeben.gameObject.SetActive(false);
    }
}
