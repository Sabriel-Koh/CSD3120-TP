using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereProjectile : MonoBehaviour
{

    [SerializeField] float Force = 5.0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        rb.AddForce(transform.right * Force, ForceMode.Impulse);
        Destroy(this, 8.0f);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //}
}
