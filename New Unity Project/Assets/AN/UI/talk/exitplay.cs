using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitplay : MonoBehaviour {
    public Animation a;
    public PolygonCollider2D p;
	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseDown()
    {
        a.Play("exit");
        p.enabled = true;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
