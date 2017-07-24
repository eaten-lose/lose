using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationClick : MonoBehaviour {
    public GameObject UiCan;
    public GameObject open;
   // public GameObject backPicture;
    public Animation an;
    // Use this for initialization
    void Start () {
		
	}
    private void OnMouseDown()
    {
        GetComponentInParent<BoxCollider2D>().enabled = false;
        UiCan.SetActiveRecursively(true);
        open.SetActive(false);
        an.Play(AnimationPlayMode.Queue);
    }
    private void OnMouseExit()
    {
        GetComponentInParent<BoxCollider2D>().enabled = false;
    }
    public void decorateOut()
    {
        GetComponentInParent<BoxCollider2D>().enabled = true;
        UiCan.SetActiveRecursively(false);
    }
    public void enteropen(Animation animation)
    {
        open.SetActive(true);
        //animation.Play(AnimationPlayMode.Queue);

    } 
    // Update is called once per frame
    void Update () {
		
	}
}
