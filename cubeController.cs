using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    Transform cube_tr;
    Transform other_tr;
    void Start()
    {
        cube_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            cube_tr.Translate(0,0,1f);
        }
        if (Input.GetKeyDown("a"))
        {
            cube_tr.Translate(-1f,0,0);
        }
        if (Input.GetKeyDown("d"))
        {
            cube_tr.Translate(1f,0,0);
        }
        if (Input.GetKeyDown("s"))
        {
            cube_tr.Translate(0,0,-1f);
        }
        if (Input.GetKeyDown("space"))
        {
            cube_tr.Translate(0,2f,0);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "enemy"){
            print("авария с врагом");
            other_tr = col.gameObject.GetComponent<Transform>();
            print(other_tr.position.x);
            other_tr.Translate(0,0,10f);
        }
        if(col.gameObject.tag == "friend"){
            print("авария с другом");
            other_tr = col.gameObject.GetComponent<Transform>();
            print(other_tr.position.x);
            other_tr.Translate(0,0,10f);
        }
    }
}
