using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationClick : MonoBehaviour {
    public GameObject UiCan;
    public GameObject open;
    static float time;
    static float timeX;
    // public GameObject backPicture;
    public Animation OpenAnimation;
    static bool count = false;
    public Animation PopUp;
    // Use this for initialization
    void Start () {
		
	}
    private void OnMouseUp()
    {
        
    }
    private void OnMouseDown()
    {
        GetComponentInParent<BoxCollider2D>().enabled = false;
        GetComponentInParent<PolygonCollider2D>().enabled = false;
        UiCan.SetActiveRecursively(true);
        open.SetActive(false);
        OpenAnimation.Play(AnimationPlayMode.Queue);
        count = false;
        timeX = time + (float)0.6;
    }
    public void decorateOutex()
    {
        if(time > timeX)
        { 
        if (count)
            OpenAnimation.Play("exitlast 1", AnimationPlayMode.Queue);
        else
            OpenAnimation.Play("exitlast", AnimationPlayMode.Queue);
        
        decorateOut();
        }
    }
    
    IEnumerator stay()
    {

        yield return new WaitForSecondsRealtime(2.2f);

    }
    public void decorateOut()
    {
        GetComponentInParent<BoxCollider2D>().enabled = true;
        GetComponentInParent<PolygonCollider2D>().enabled = true;
    }
    public void enteropen(Animation animation)
    {

        GetComponent<PolygonCollider2D>().enabled = false;
        OpenAnimation.Play("exit", AnimationPlayMode.Queue);
        open.SetActive(true);
        PopUp.Play();
        count = true;
    } 
    // Update is called once per frame
    void Update () {
        time = Time.time;
	}
}
