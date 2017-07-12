using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using UnityEngine.SceneManagement;

public class CharClic : MonoBehaviour
{
    public BoxCollider2D car;
    public GameObject chara;
    public GameObject v1;
    public PolygonCollider2D charac;
    public static GameObject pan1;
    int a = 1;
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
        
    }
    public void delet()
    {
        car.enabled = true;
        charac.enabled = true;
        pan1.SetActiveRecursively(false);
    }
    public void button1()
    {
        Debug.Log("LAS:1");
        FileStream read = new FileStream("da.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(read);
        sw.WriteLine(1);
        sw.Close();
        read.Close();
        SceneManager.LoadScene("test");
    }
    public void button2()
    {
        Debug.Log("LAS:2");
        FileStream read = new FileStream("da.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(read);
        sw.WriteLine(2);
        sw.Close();
        read.Close();
        SceneManager.LoadScene("test");
    }
    public void button3()
    {
        Debug.Log("LAS:3");
        FileStream read = new FileStream("da.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(read);
        sw.WriteLine(3);
        sw.Close();
        read.Close();
        SceneManager.LoadScene("test");
    }
    public void button4()
    {
        Debug.Log("LAS:4");
        FileStream read = new FileStream("da.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(read);
        sw.WriteLine(4);
        sw.Close();
        read.Close();
        SceneManager.LoadScene("test");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
