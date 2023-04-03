using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SauceGun : InteractableBase
{
    [SerializeField] private Vector3 spawnOffset;
    [SerializeField] private GameObject projectileObject;
    [SerializeField] private float fireInterval;
    [SerializeField] private float projectileSpeed;

    private bool isFiring = false;
    private float fireTimer;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void OnActivate(ActivateEventArgs args)
    {
        base.OnActivate(args);
        isFiring = true;
        audioSource.Play();
    }

    public override void OnDeactivate(DeactivateEventArgs args)
    {
        base.OnDeactivate(args);
        isFiring = false;
        audioSource.Stop();
    }

    private void Update()
    {
        if (isFiring)
        {
            fireTimer -= Time.deltaTime;
            if (fireTimer <= 0)
            {
                ShootOnce();
                fireTimer = fireInterval;
            }
        }
    }

    private void ShootOnce()
    {
        Vector3 spawnPosition = transform.TransformPoint(spawnOffset);
        Instantiate(projectileObject, spawnPosition, transform.rotation);
        projectileObject.GetComponent<Rigidbody>().velocity = projectileSpeed * projectileObject.transform.forward;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.TransformPoint(spawnOffset), 0.02f);
    }
}
