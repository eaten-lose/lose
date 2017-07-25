using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickObject : MonoBehaviour {
    public BoxCollider2D COl;
    public GameObject ef;
	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseDown()
    {
        Vector3 a = Input.mousePosition;
        COl.enabled = false;
        ef.GetComponent<Transform>().TransformPoint(a);
        ef.active = true;

        ef.active = false;
    }
    private void OnMouseExit()
    {
        COl.enabled = true;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
