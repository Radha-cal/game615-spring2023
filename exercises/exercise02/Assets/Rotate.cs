using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = .001f;
    public float launchForce = .001f;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name); 
    }

    // Update is called once per frame
    void Update()
    {
    //    Vector3 newPosition = new Vector3(gameObject.transform.position.x+.05f,
    //    gameObject.transform.position.y,
    //    gameObject.transform.position.z);
    //    gameObject.transform.position.newPosition;
    if (Input.GetKey(KeyCode.Space)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        rb.AddForce(gameObject.transform.forward*launchForce);
    }
    }
}
