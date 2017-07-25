using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class characterClick : MonoBehaviour {
    public Animation ani;
    public GameObject talkUi;
    public GameObject blackbakc;
    public Animator at;
	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseDown()
    {
        at.SetVector("start", new Vector3(0, 0, 0));
        ani.Play("open");
        talkUi.SetActive(true);
        blackbakc.SetActive(true);
        GetComponent<PolygonCollider2D>().enabled = false;
        
    }
    public void exit()
    {
        GetComponent<PolygonCollider2D>().enabled = true;
        ani.Play("exit",AnimationPlayMode.Queue);
        Debug.Log("asd");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
