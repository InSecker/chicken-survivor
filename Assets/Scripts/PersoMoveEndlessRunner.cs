using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoMoveEndlessRunner : MonoBehaviour
{
    public float Speed = 1;
    
    Rigidbody rb;
    
    public float JumpFactor = 1;
    bool IsJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horVal = Input.GetAxis("Horizontal");
        
        Vector3 posArrivee = transform.position + (Vector3.right * Speed * Time.deltaTime * horVal);
        rb.MovePosition(posArrivee);

        float jumpVal = Input.GetAxis("Jump");
        if (!IsJumping && jumpVal > 0.1f) {
            IsJumping = true;
            rb.AddForce(Vector3.up * JumpFactor, ForceMode.VelocityChange);
        }

    }

    public void HitGround() {
        IsJumping = false;
    }

}
