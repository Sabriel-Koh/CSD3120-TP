using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Can make some methods inside protected if need to extend.
public class Topping : MonoBehaviour
{
    [field: SerializeField] public ToppingInfo Info { get; private set; }
    [SerializeField] private float lifetime;

    private float lifetimeTimer = 0.0f;
    private bool isBeingConsumed = false;

    public void Consume(GameObject consumer)
    {
        // Prevent normal expiry from taking effect.
        isBeingConsumed = true;

        // Stop movement & follow consumer.
        transform.SetParent(consumer.transform);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        // Start consuming.
        StartCoroutine(ConsumeCoroutine());
    }

    private void Update()
    {
        lifetimeTimer += Time.deltaTime;
        if (!isBeingConsumed && lifetimeTimer > lifetime) { Despawn(); }
    }

    private void Despawn()
    {
        Destroy(gameObject);
    }

    private IEnumerator ConsumeCoroutine()
    {
        const float shrinkTime = 4.0f;
        for (float t = shrinkTime; t >= 0; t -= Time.deltaTime)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, (1 - t / shrinkTime));
            yield return new WaitForSeconds(Time.deltaTime);
        }
        Despawn();

        yield return null;
    }
}
