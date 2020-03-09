using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float Speed = 1;
    private Renderer rend;
    public float maxScale = 2;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(1, 1, 1));
        rend.material.SetColor("_Color", HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * Speed, 1), Audior.samples[3] * 100, Audior.samples[3] * 200)));
        transform.Rotate(Audior.samples[5] * 150, Audior.samples[10] * 160, Audior.samples[15] * 170);
        transform.localScale = new Vector3((Audior.samples[20] * maxScale*2) + 0.8f, (Audior.samples[20] * maxScale*2) + 0.8f, (Audior.samples[20] * maxScale*2) + 0.8f);
    }
}
