using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOff : MonoBehaviour {
    public static GameObject panas;
    int a = 1;
    public GameObject chara;

    public BoxCollider2D car;
    public GameObject v;
    public CapsuleCollider2D charac;
    public static GameObject asd;
    public GameObject deco1;
    public static GameObject deco;
    // Use this for initialization

    void Start () {
        deco = GameObject.Find("gagu");
        deco1 = GameObject.Find("da");
        panas = GameObject.Find("Canvas");
        
    chara= GameObject.Find("car");
       car = chara.GetComponent<BoxCollider2D>();

        asd = GameObject.Find("jang");
        v = GameObject.Find("1");
        panas.SetActiveRecursively(false);
        charac =v.GetComponent<CapsuleCollider2D>();
    }

    public void gaguo()
    {
        asd = GameObject.Find("jang");
        deco = GameObject.Find("gagu");
        panas.SetActiveRecursively(true);
        asd.gameObject.SetActive(false);
        deco.gameObject.SetActive(false);
    }
    private void OnMouseDown()
    {
        car.enabled = false;
        charac.enabled = false;
        panas.SetActiveRecursively(true);
        deco1.SetActive(false);
    }
    public void deloe()
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
