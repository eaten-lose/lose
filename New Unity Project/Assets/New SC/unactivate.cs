using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unactivate : MonoBehaviour {
    public GameObject a;
	// Use this for initialization
	void Start () {
        a.SetActive(false);
        this.gameObject.SetActiveRecursively(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
