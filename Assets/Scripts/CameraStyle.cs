using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStyle : MonoBehaviour
{
    public float speed = 100;
    public float factor = 2;
    // Use this for initialization
    private Vector3 initPos;
    void Start () {
        initPos = transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Audior.samples[20] * factor);
    }
    private void FixedUpdate() {
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, initPos, step);
    }
}
