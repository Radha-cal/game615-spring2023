using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Project1BOXWeight : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
      Debug.Log(gameObject.name);

      rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space)) 
       {
            rb.useGravity = true;
       }
    }
}
