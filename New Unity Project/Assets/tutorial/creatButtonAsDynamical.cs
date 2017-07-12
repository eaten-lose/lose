using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatButtonAsDynamical : MonoBehaviour {
    GameObject buttonOR;
	// Use this for initialization
	void Start () {
        buttonOR = GameObject.Find ("Canvas");
        buttonOR.SetActive(false);
	}
    private void OnMouseDown()
    {
        GameObject button1 = Instantiate(buttonOR);
        button1.transform.SetParent(buttonOR.transform);
        button1.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
