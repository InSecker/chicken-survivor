using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float Speed = 1; // 1 degrée par seconde
    public Vector3 Axe = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Axe, Speed * Time.deltaTime);
    }
}
