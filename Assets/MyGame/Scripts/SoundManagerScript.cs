using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip coinUp, coinDown, energyUp, energyDown, lernUp, lernDown, sucessSound, failureSound;
    AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = gameObject.AddComponent<AudioSource>();
        //coinUp = Resources.Load<AudioClip>("Coin.mp3");
        //coinDown = Resources.Load<AudioClip>("CoinAbzug");
        /*energyUp = SFX.Load<AudioClip>("EnergieRauf");
        energyDown = SFX.Load<AudioClip>("EnergieRunter");
        lernUp = SFX.Load<AudioClip>("LernRauf");
        lernDown = SFX.Load<AudioClip>("LernRunter");
        sucessSound = SFX.Load<AudioClip>("Negative_beeps-6008");
        failureSound = SFX.Load<AudioClip>("Success-fanfare-trumpets-6185");*/

    }

    public void PlayClip()
    {
        audioSrc.clip = coinUp;
        audioSrc.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
