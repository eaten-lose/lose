using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragInMainHouse : MonoBehaviour {
    public GameObject mainCamera;
    // Use this for initialization
    void Start () {
	}
    private void OnMouseDrag()
    {
        float mouseW = Input.GetAxis("Mouse X");
        float Xdegrees = mainCamera.transform.position.x;
        if (Xdegrees < 6 && Xdegrees > -6)
            mainCamera.transform.position += (new Vector3(-mouseW / 4, 0, 0));
        else if (Xdegrees >= 6 && -mouseW < 0)
            mainCamera.transform.position += (new Vector3(-mouseW / 4, 0, 0));
        else if (Xdegrees <= -6 && -mouseW > 0)
            mainCamera.transform.position += (new Vector3(-mouseW / 4, 0, 0));
        
    }
    private void OnMouseUp()
    {
        float Xdegrees = mainCamera.transform.position.x;
        if (Xdegrees > 6)
            mainCamera.transform.Translate(new Vector3(-((float)Xdegrees - 6), 0, 0));
        if (Xdegrees < -6)
            mainCamera.transform.Translate(new Vector3((float)-Xdegrees-6, 0, 0));
    }
    
    // Update is called once per frame
    void Update () {
      
    }
}
