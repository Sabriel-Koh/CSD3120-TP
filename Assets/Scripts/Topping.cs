using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Can make some methods inside protected if need to extend.
public class Topping : MonoBehaviour
{
    [SerializeField] private float lifetime;

    private float lifetimeTimer = 0.0f;

    private void Update()
    {
        lifetimeTimer += Time.deltaTime;
        if (lifetimeTimer > lifetime) { Despawn(); }
    }

    private void Despawn()
    {
        Destroy(gameObject);
    }
}
