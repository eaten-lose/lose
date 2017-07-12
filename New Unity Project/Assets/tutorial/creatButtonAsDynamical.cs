using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class creatButtonAsDynamical : MonoBehaviour {
   public GameObject buttonOR;
    public GameObject b;
	// Use this for initialization
	void Start () {
        string str;
        FileStream read = new FileStream("da.txt", FileMode.Open);
        StreamReader sR = new StreamReader(read);
        str = sR.ReadLine();
        Debug.Log(str);

    }
    private void OnMouseDown()
    {
        buttonOR = GameObject.Find("B");
        b=Instantiate(buttonOR);

        b.transform.parent= GameObject.Find("Canvas").transform;
        b.transform.Translate(new Vector3(200, 200, 30));

        Debug.Log("las");
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
