using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
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
        sR.Close();
        read.Close();
        int num = int.Parse(str);
       string[] namestr = new string[5] { "1","2","3","4","5"};

        for(int i=0;i<num;i++)
        {
            buttonOR = GameObject.Find("B");
            b = Instantiate(buttonOR);
            b.transform.parent = GameObject.Find("Canvas").transform;
            b.transform.Translate(new Vector3((float)196.5, 200+i*50, 30));
            b.name = namestr[i];
        }
        buttonOR.SetActive(false);
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
