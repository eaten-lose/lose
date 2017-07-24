using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickObject : MonoBehaviour {
    public BoxCollider2D COl;
	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseDown()
    {
        COl.enabled = false;
    }
    private void OnMouseExit()
    {
        COl.enabled = true;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
