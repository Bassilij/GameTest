using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

    GameObject C;
    Vector3 xyz;

    void Start () {
        //C = GameObject.Find("cube1");
        C = this.gameObject;
        xyz.x = C.transform.position.x;
        xyz.y = C.transform.position.y;
        xyz.z = C.transform.position.z;
        C.transform.position = xyz;
    }

    void Update() {
        if(GameObject.Find("Camera").GetComponent<startgame>().a < 0)
            Destroy(C);
        float speed = 1;
        if (xyz.x < -150)
        {
            Delete();
            Destroy(C);
        }
        else
            xyz.x = xyz.x - speed;
        C.transform.position = xyz;
    }

    private void OnMouseDown()
    {
        Destroy(C);

        if (C.GetComponent<Renderer>().material.color == Color.red)
        {
            GameObject Score;
            Score = GameObject.Find("Score");
            string s = Score.GetComponent<TextMesh>().text;
            s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
            int a = int.Parse(s);
            a++;
            Score.GetComponent<TextMesh>().text = "Score: " + a;
        }
        if (C.GetComponent<Renderer>().material.color == Color.blue)
        {
            GameObject HP;
            HP = GameObject.Find("HP");
            string s = HP.GetComponent<TextMesh>().text;
            s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
            int b = int.Parse(s);
            b--;
            HP.GetComponent<TextMesh>().text = "HP: " + b;

            if (b == 0)
            {
                HP.GetComponent<TextMesh>().text = "YOU LOSE!!!";
                LoseLevel();
            }
        }

    }

    void Delete() {
        GameObject HP;
        HP = GameObject.Find("HP");
        string s = HP.GetComponent<TextMesh>().text;
        if (s != "YOU LOSE!!!")
        if (C.GetComponent<Renderer>().material.color == Color.red)
        {
                s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
                int b = int.Parse(s);
                b--;
                HP.GetComponent<TextMesh>().text = "HP: " + b;

                if (b == 0)
                {
                    HP.GetComponent<TextMesh>().text = "YOU LOSE!!!";
                    LoseLevel();
                }
            }
    }

    void LoseLevel()
    {
        //Destroy(this.gameObject);
        GameObject.Find("Camera").GetComponent<startgame>().STOP();
    }
}
