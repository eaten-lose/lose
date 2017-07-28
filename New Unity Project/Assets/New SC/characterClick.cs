using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class characterClick : MonoBehaviour {
    public Animation ani;
    public GameObject talkUi;
    public GameObject blackbakc;
    public GameObject ButtonOrigin;
    private GameObject CopyButton;
    // Use this for initialization
    void Start () {
		
	}
    private void OnMouseDown()
    {
        ani.Play("open");
        ani.Play("buttonOpen",AnimationPlayMode.Queue);
        talkUi.SetActive(true);
        blackbakc.SetActive(true);
        GetComponent<PolygonCollider2D>().enabled = false;
    }
    public void exit()
    {
        GetComponent<PolygonCollider2D>().enabled = true;
        ani.Play("exit",AnimationPlayMode.Queue);
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
