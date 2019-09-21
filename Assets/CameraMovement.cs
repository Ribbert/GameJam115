using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public Vector3 centerPoint;

    // Start is called before the first frame update
    void Start()
    {
        centerPoint = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        centerPoint = Camera.transform.position;
        if (Player.transform.position.x > (centerPoint.x + 5.4f))
        { this.gameObject.transform.position += new Vector3(10.8f, 0f, 0f);}
        else if (Player.transform.position.y > (centerPoint.y + 4.05f))
        { this.gameObject.transform.position += new Vector3(0f, 8.1f, 0f);}
        else if (Player.transform.position.x < (centerPoint.x - 5.4f))
        { this.gameObject.transform.position += new Vector3(-10.8f, 0f, 0f);}
        else if (Player.transform.position.y < (centerPoint.y - 4.05f))
        { this.gameObject.transform.position += new Vector3(0f, -8.1f, 0f);}
        else {};
    }
}
