using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceEmitter : MonoBehaviour
{
    [SerializeField] GameObject Ball;

    // Update is called once per frame
    void Update()
    {
        Instantiate(Ball, this.transform.position, this.transform.rotation);
    }
}
