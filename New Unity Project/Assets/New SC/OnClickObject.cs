using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickObject : MonoBehaviour {
    public BoxCollider2D COl;
    public GameObject ef;
    static Vector2 mouse_position;
    // Use this for initialization
    void Start () {
        mouse_position = Vector2.zero;
    }
    private void OnMouseDown()
    {
        COl.enabled = false;
        
        
        

        
    }
    private void OnMouseExit()
    {
        COl.enabled = true;
    }
    // Update is called once per frame
    void Update () {

        mouse_position = Input.mousePosition;
     //   Debug.Log(mouse_position);
    }
}
