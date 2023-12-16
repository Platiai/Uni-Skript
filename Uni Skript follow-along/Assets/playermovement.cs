using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;


public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    public float movementspeed = 10;
    void Update()
    {
        
      if (Input.GetKey(KeyCode.W))
      {
        gameObject.transform.position += new Vector3
            (0, 0.01f, 0) * movementspeed * Time.deltaTime;
      }  
      if (Input.GetKey(KeyCode.A))
      {
        gameObject.transform.position += new Vector3
            (-0.01f, 0, 0)* movementspeed * Time.deltaTime;
      }
       if (Input.GetKey(KeyCode.S))
      {
        gameObject.transform.position += new Vector3
            (0, -0.01f, 0)* movementspeed * Time.deltaTime;
      }
       if (Input.GetKey(KeyCode.D))
      {
        gameObject.transform.position += new Vector3
            (0.01f, 0, 0)* movementspeed * Time.deltaTime;
      }

    }
    void OnMouseDown() {
  gameObject.transform.Rotate(new Vector3(0, 0, 45));
  }
}
