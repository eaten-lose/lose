using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragTuto : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        
	}
    private void OnMouseDrag()
    {
        Vector2 a;
        float MX = 0;
        float monitorsize = (float)5.7;
        MX = Input.GetAxis("Mouse X");
        Transform tf = GetComponent<Transform>();
        // MX = 0;
        //  Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float cameraX = tf.position.x;
        if(cameraX>=-monitorsize&&cameraX<=monitorsize)
        tf.position += new Vector3(-MX/3,0,0);
        if (cameraX <= -monitorsize && -MX > 0)
            tf.position += new Vector3(-MX / 3, 0, 0);
        else if (cameraX >= monitorsize && -MX < 0)
            tf.position += new Vector3(-MX / 3, 0, 0);
        // rb.AddForce(a, 0);
        Debug.Log(MX);
    }
    // Update is called once per frame
    void Update () {
    }
}
