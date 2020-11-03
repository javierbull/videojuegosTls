using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public float deltaRotation = 100f;
    public float deltaMove = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        MoveForwardBack();
        
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * Time.deltaTime);    
        } 
        else if (Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);    
        }
        
    }

    void MoveForwardBack ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * deltaMove * Time.deltaTime);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * deltaMove * Time.deltaTime);
        }
    }

    
}
