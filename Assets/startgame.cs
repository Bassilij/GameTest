using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startgame : MonoBehaviour {
    public int a = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (a >= 0)
        {
            GameObject D;
            //D = new GameObject();
            D = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            float r = Random.value;
            if (r < 0.33)
                D.GetComponent<Renderer>().material.color = Color.red;
            if (r > 0.33 && r < 0.66)
                D.GetComponent<Renderer>().material.color = Color.white;
            if (r > 0.66)
                D.GetComponent<Renderer>().material.color = Color.blue;
            Vector3 sss;
            sss.x = 10;
            sss.y = 10;
            sss.z = 10;
            D.transform.localScale = sss;
            Vector3 xyz;
            xyz.x = 150;
            xyz.y = -100 + Random.value*200;
            xyz.z = Random.value * 20;
            D.transform.position = xyz;
            D.AddComponent<start>();

            //a++;
        }
    }

    public void STOP() {
        a = -1;
    }
}
