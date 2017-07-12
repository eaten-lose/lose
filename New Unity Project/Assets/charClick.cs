using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charClick : MonoBehaviour {
    public static int tutoCharClick;
    SpriteRenderer im;
    Transform tr;
   // GameObject LA;
    // Use this for initialization
    void Start () {
         im= GetComponent<SpriteRenderer>();
        tr = GetComponent<Transform>();
      //  LA = GameObject.Find("풍선");
        tutoCharClick = 0;
    }
    private void OnMouseDown()
    {
        tutoCharClick = 1;
        this.gameObject.SetActive(false);
        Debug.Log("캐릭터 클릭");
       // LA.SetActive(false);
       // tr.position = new Vector3(tr.position.x, tr.position.y, -20);   
        //im.color = new Color(0, 0, 0, 0);

    }
   
    // Update is called once per frame
    void Update () {
		
	}
}
