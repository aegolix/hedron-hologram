using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStyle : MonoBehaviour {
    public float Speed = 1;
    public float maxScale = 2;
    public float colorRate = 1;
    // Use this for initialization
    private ParticleSystem.MainModule settings;
    void Start () {
        settings = GetComponent<ParticleSystem>().main;
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(1, 1, 1));
        //settings.startColor = HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * colorRate, 1), 1, 1));
        transform.Rotate(Audior.samples[15] * 100, Audior.samples[30] * 100, Audior.samples[50] * 100);
    }
}
