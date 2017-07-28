using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookHistoryClick : MonoBehaviour {
    public GameObject BookUi;
    public GameObject back;
    static float timeX = 0;
    // Use this for initialization
    void Start () {
		
	}
    private void OnMouseDown()
    {
        if (Time.time > timeX)
        {
            back.GetComponent<BoxCollider2D>().enabled = false;
            BookUi.GetComponent<Animation>().Play("openB", AnimationPlayMode.Queue);
            timeX = (float)Time.time + 0.5f;
        }
    }
    // Update is called once per frame
    
    void Update () {
		
	}
}
