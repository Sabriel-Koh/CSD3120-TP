using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class OvenStation : MonoBehaviour
{
    [SerializeField] private float bakeLevelPerSecond;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "Pizza") { return; }

        float bakeLevel = Time.deltaTime * bakeLevelPerSecond;
        other.gameObject.GetComponent<Pizza>().AddBakeLevel(bakeLevel);
    }
}
