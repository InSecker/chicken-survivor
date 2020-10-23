using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoMoveRigidbody : MonoBehaviour
{
    public float Speed = 1;
    public float RotateSpeed  = 80;

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertVal = Input.GetAxis("Vertical");
        float horVal = Input.GetAxis("Horizontal");
        
        transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime * horVal);

        Vector3 posArrivee = transform.position + (transform.forward * Speed * Time.deltaTime * vertVal);
        rb.MovePosition(posArrivee);
    }
}
