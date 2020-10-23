using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoMove : MonoBehaviour
{
    public float Speed = 1;
    public float RotateSpeed  = 80;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertVal = Input.GetAxis("Vertical");
        float horVal = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * vertVal);
        transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime * horVal);
    }
}
