using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereProjectile : MonoBehaviour
{

    [SerializeField] float Force = 5.0f;
    Rigidbody rb;

    private float timer = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        rb.AddForce(transform.right * Force, ForceMode.Impulse);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SauceGun") { return; }
        Destroy(gameObject);
    }
}
