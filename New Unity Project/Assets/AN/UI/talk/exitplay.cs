using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitplay : MonoBehaviour {
    public Animation a;
    public PolygonCollider2D p;
    static float time;
    static float timeX=0;
    // Use this for initialization
    void Start () {
		
	}
    private void OnMouseDown()
    {
        if (time > timeX)
        {
            a.Play("ButtonChange", AnimationPlayMode.Queue);
            a.Play("exit", AnimationPlayMode.Queue);
            p.enabled = true;
            timeX = time + (float)2;
        }
    }
    // Update is called once per frame
    void Update () {
        time = Time.time;
    }
}
