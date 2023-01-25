using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kittyw1 : MonoBehaviour
{
    // Start is called before the first frame update
    // Pizza slice by jeremy [CC-BY] via Poly Pizza
    //Cat by Poly by Google [CC-BY] via Poly Pizza
    //Jewel by Zsky [CC-BY] via Poly Pizza



    Rigidbody rb;
    void Start()
    {
      Debug.Log("Pizza slice by jeremy [CC-BY] via Poly Pizza, Cat by Poly by Google [CC-BY] via Poly Pizza, Jewel by Zsky [CC-BY] via Poly Pizza");

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
