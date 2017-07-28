using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragInMainHouse : MonoBehaviour {
    public GameObject mainCamera;
    static float ex = 5.7f;
    // Use this for initialization
    void Start () {
        
    }
    private void OnMouseDrag()
    {
        float mouseW = Input.GetAxis("Mouse X");
        float Xdegrees = mainCamera.transform.position.x;
        if (Xdegrees < ex && Xdegrees > -ex)
            mainCamera.transform.position += (new Vector3(-mouseW / 4, 0, 0));
        else if (Xdegrees >= ex && -mouseW < 0)
            mainCamera.transform.position += (new Vector3(-mouseW / 4, 0, 0));
        else if (Xdegrees <= -ex && -mouseW > 0)
            mainCamera.transform.position += (new Vector3(-mouseW / 4, 0, 0));
        
        
    }
    private void OnMouseUp()
    {
        
        float Xdegrees = mainCamera.transform.position.x;
        if (Xdegrees > ex)
            mainCamera.transform.Translate(new Vector3(-((float)Xdegrees - ex), 0, 0));
        if (Xdegrees < -ex)
            mainCamera.transform.Translate(new Vector3((float)-Xdegrees- ex, 0, 0));
    }
    
    // Update is called once per frame
    void Update () {
    }
}
