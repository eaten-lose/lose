using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript;

public class ButtonObject : MonoBehaviour {
    public GameObject TalkAlgorithm;
    public Algorithm main;
    private string ButtonName;
    public int PrivateCode;
    public float love;
    public string Text;
    public int NextTalk;
    public bool Click = false;
	// Use this for initialization
    public void ButtonOSetting(int Code, bool exist)
    {
        if(exist)
            PrivateCode = Code;
        gameObject.SetActive(exist);
    }
	void Start () {
        ButtonName = gameObject.name;
	}
    private void OnMouseDown()
    {
        Click = true;
    }
    // Update is called once per frame
    void Update () {
		if(Click)
        {
            main.ClickOnOff = true;
            main.ClickbuttonName = ButtonName;
            Click = false;
        }
        
	}
}
