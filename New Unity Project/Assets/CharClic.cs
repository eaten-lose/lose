using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharClic : MonoBehaviour
{
    public BoxCollider2D car;
    public GameObject chara;
    public GameObject v1;
    public PolygonCollider2D charac;
    public static GameObject pan1;
    static int a = 1;
    // Use this for initialization
    public GameObject fas;
    public GameObject fas1;
    public GameObject fas2;

    void Start()
    {
        chara = GameObject.Find("car");
        car = chara.GetComponent<BoxCollider2D>();
       // v1 = GameObject.Find("풍선");
        
        pan1 = GameObject.Find("talk");
        pan1.SetActiveRecursively(false);

    }
    private void OnMouseDown()
    {
        charac = this.GetComponent<PolygonCollider2D>();
        car.enabled = false;
        charac.enabled = false;
        pan1.SetActiveRecursively(true);
        creatButton();
        
    }
    public void delet()
    {
        string[] namestr = new string[5] { "0", "2", "3", "4", "5" };
        GameObject b = GameObject.Find("2");
        DestroyObject(b);
        b = GameObject.Find("0");
        DestroyObject(b);

        car.enabled = true;
        charac.enabled = true;
        pan1.SetActiveRecursively(false);
    }
    public void upper()
    {
        a += 1;
    }
    public void nextText()
    {
        GameObject text = GameObject.Find("quse");
        string str="ERROR";
        FileStream read = new FileStream("text.txt", FileMode.Open);
        StreamReader sR = new StreamReader(read);
        for (int i = 0; i < a; i++)
        {
            str = sR.ReadLine();
        }
        Text TX = text.GetComponent<Text>();
        TX.text = str;
        Debug.Log(str);
        sR.Close();
        read.Close();
        
    }
    public void creatButton()
    {
        string str="0";
        FileStream read = new FileStream("buN.txt", FileMode.Open);
        StreamReader sR = new StreamReader(read);
        for (int i = 0; i < a; i++)
        {
            str = sR.ReadLine();
        }
        Debug.Log(str);
        sR.Close();
        read.Close();
        int num = int.Parse(str);
        string[] namestr = new string[5] { "0", "2", "3", "4", "5" };
        FileStream read1 = new FileStream("asd.txt", FileMode.Open);
        GameObject buttonOR;
        GameObject b;
        StreamReader sR1 = new StreamReader(read1);
        buttonOR = GameObject.Find("B");
        for(int i = 1*5;i<a*5;i++)
        {
            str = sR1.ReadLine();
        }
        for (int i = 0; i < num; i++)
        {
            str = sR1.ReadLine();
            Debug.Log(str);
            b = Instantiate(buttonOR);
            b.transform.parent = GameObject.Find("talk").transform;
            b.transform.Translate(new Vector3((float)196.5, 400 + i * 50, 30));
            b.name = namestr[i];
            GameObject text = GameObject.Find("Text");
            Text tex = b.GetComponentInChildren<Text>();
            tex.text = str;
        }
        sR1.Close();
        read1.Close();
    }
    public void buttonUpdate()
    {
        string str = "0";
        FileStream read = new FileStream("buN.txt", FileMode.Open);
        StreamReader sR = new StreamReader(read);
        for (int i = 0; i < a; i++)
        {
            str = sR.ReadLine();
        }
        sR.Close();
        read.Close();
        int num = int.Parse(str);
        string[] namestr = new string[5] { "0", "2", "3", "4", "5" };
        GameObject b;
        Debug.Log("개수"+num);
        for (int i = 0; i < 5; i++)
        {
            b = GameObject.Find(namestr[i]);
            DestroyObject(b);
        }
        GameObject buttonOR;
        buttonOR = GameObject.Find("B");
    }
    void Update()
    {

    }
}
