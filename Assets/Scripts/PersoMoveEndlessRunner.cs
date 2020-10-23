using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoMoveEndlessRunner : MonoBehaviour
{
    public float Speed = 1;
    public float DureeBonusFly = 3;
    
    Rigidbody rb;
    
    public float JumpFactor = 1;
    bool isJumping = false;

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
        if (!isJumping && jumpVal > 0.1f) {
            isJumping = true;
            rb.AddForce(Vector3.up * JumpFactor, ForceMode.VelocityChange);
        }
    }

    public void DoFly() {
        isJumping = true;
        rb.AddForce(Vector3.up * JumpFactor, ForceMode.VelocityChange);
        Invoke("Freeze", 0.8f);
    }

    void Freeze() {
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        Invoke("GravityOn", DureeBonusFly);
    }

    void GravityOn() {
        Debug.Log("gravityOn");
        rb.useGravity = true;
    }

    public void HitGround() {
        isJumping = false;
    }

}
