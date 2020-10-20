using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBark : MonoBehaviour
{
    AudioSource myAudioSource;//save in inspector
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            myAudioSource.Play();
        }
        if(Input.GetKeyDown(KeyCode.L)){
            myAudioSource.Play();
        }
    }
}
