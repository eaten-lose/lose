using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterClick : MonoBehaviour {
    public Animation ani;
	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseDown()
    {
        ani.Play();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
