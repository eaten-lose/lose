using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour {
    public string ClickbuttonName = null;
    public bool ClickOnOff;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ClickOnOff && ClickbuttonName != null)
        {
            GameObject ClickButton = GameObject.Find(ClickbuttonName);
            ButtonObject SC = ClickButton.GetComponent<ButtonObject>();
            Debug.Log(SC.name);
            ClickOnOff = false;
            ClickbuttonName = null;
        }
	}
}
