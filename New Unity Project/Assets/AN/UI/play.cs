using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {
    // Use this for initialization
    public GameObject a;
	void Start () {
		
	}
	public void played()
    {
        a.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
