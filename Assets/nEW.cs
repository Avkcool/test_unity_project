using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nEW : MonoBehaviour
{
    public GameObject a;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = a.GetComponent<AudioSource>();
        InvokeRepeating(nameof(Play), 1f, 1.48f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Play()
    {
        sound.Play();
    }
}
