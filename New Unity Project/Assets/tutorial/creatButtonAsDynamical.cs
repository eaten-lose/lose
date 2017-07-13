using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        FileStream read1 = new FileStream("asd.txt", FileMode.Open);
        StreamReader sR1 = new StreamReader(read1);
        for (int i=0;i<num;i++)
        {
            
            str = sR1.ReadLine();
            Debug.Log(str);
            buttonOR = GameObject.Find("B");


            b = Instantiate(buttonOR);

            b.transform.parent = GameObject.Find("Canvas").transform;
            b.transform.Translate(new Vector3((float)196.5, 200+i*50, 30));
            b.name = namestr[i];

            GameObject text = GameObject.Find("Text");
            Text tex = b.GetComponentInChildren<Text>();
            tex.text = str;

        }
        sR1.Close();
        read1.Close();
        buttonOR.SetActive(false);
    }
  public void change()
    {
        SceneManager.LoadScene("tuto");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
