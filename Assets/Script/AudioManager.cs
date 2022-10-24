using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    public void playCreditSound(){
        audio.Play();
    }
    public void stopCreditSound(){
        audio.Stop();
    }
    void Start()
    {
        audio = GameObject.Find("CreditSound").GetComponent<AudioSource>();
        Invoke("playCreditSound", 20);
        Invoke("stopCreditSound", 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
