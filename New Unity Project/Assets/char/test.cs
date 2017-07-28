using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class test : MonoBehaviour {
    public Image image;
    
    // Use this for initialization
    void Start () {
		
	}
    public void setIamge(Sprite a)
    {
        image.sprite = a;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
