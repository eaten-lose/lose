using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class click : MonoBehaviour {
    int howManyPlay=0;
    // Use this for initialization
    void Start () {
        
	}
    private void OnMouseDown()
    {
        if(howManyPlay==0)
        SceneManager.LoadScene("tuto");
    }
    public void tomain()
    {
        SceneManager.LoadScene("tuto");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
