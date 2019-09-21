using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = .1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() //Raycast collision fixes needed
    {
        if(Input.GetKey(KeyCode.A))
        {this.gameObject.transform.position += new Vector3(-speed, 0, 0);}
        if (Input.GetKey(KeyCode.W))
        { this.gameObject.transform.position += new Vector3(0, speed, 0); }
        if (Input.GetKey(KeyCode.S))
        { this.gameObject.transform.position += new Vector3(0, -speed, 0); }
        if (Input.GetKey(KeyCode.D))
        { this.gameObject.transform.position += new Vector3(speed, 0, 0); }

    }
}
