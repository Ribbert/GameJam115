using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = .1f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() //Raycast collision fixes needed
    {
        if(Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(-speed, 0, 0);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(0, speed, 0);
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += new Vector3(0, -speed, 0);
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("isRunning", true);
        }
        if (!(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)))
        {
            anim.SetBool("isRunning", false);
        }

    }
}
