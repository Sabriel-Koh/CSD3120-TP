using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PizzaBoxLidCheck : MonoBehaviour
{
    [SerializeField] private AudioClip openSound;
    [SerializeField] private AudioClip closeSound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(closeSound);
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.PlayOneShot(openSound);
    }
}
