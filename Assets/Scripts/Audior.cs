using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audior : MonoBehaviour {
    // Use this for initialization
    AudioSource audioSource;
    public static float[] samples = new float[128];

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //samples = new float[128]; 
        getSpectrumData();

    }
    void getSpectrumData()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }
}
