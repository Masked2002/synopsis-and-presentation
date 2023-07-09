using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float sprint = 5.0f;
   
    private bool run= true;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
      

        if (Input.GetKeyDown(KeyCode.C) && run)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * sprint * forwardInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * sprint * horizontalInput);
            run = true;
        }

    }
}