using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offga : MonoBehaviour {
    
    public static GameObject panas;
    public BoxCollider2D car;
    public GameObject chara;
    public GameObject v;
    public CapsuleCollider2D charac;
    // Use this for initialization
    void Start () {
        
        panas = GameObject.Find("Canvas");
        chara = GameObject.Find("car");
        car = chara.GetComponent<BoxCollider2D>();
        

        v = GameObject.Find("1");

        charac = v.GetComponent<CapsuleCollider2D>();
    }
    public void OnMseDown()
    {
        car.enabled = true;
        charac.enabled = true;
        panas.SetActiveRecursively(false);
        Debug.Log("asdfdsf");
    }
    private void OnMouseDown()
    {
        car.enabled = true;
        charac.enabled = true;
        panas.SetActiveRecursively(false);
        Debug.Log("asdfdsf");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
