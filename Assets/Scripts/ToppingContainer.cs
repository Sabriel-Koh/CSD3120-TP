using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToppingContainer : InteractableBase
{
    public GameObject toppingObject;
    public Vector3 spawnOffset;
    public float spillageAngle;
    public int numSpawnPerUpdate;
    public float spawnRate;

    private float spawnTimer = 0.0f;

    private void Update()
    {
        float angleFromHorizon = 90.0f - Vector3.Angle(Vector3.down, transform.up);
        
        if (angleFromHorizon > spillageAngle)
        {
            SpawnTopping();
        }
    }

    private void SpawnTopping()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0.0f)
        {
            Vector3 spawnPosition = transform.TransformPoint(spawnOffset);
            for (int i = 0; i < numSpawnPerUpdate; i++)
            {
                Instantiate(toppingObject, spawnPosition, Random.rotation);
            }
            spawnTimer = spawnRate;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.TransformPoint(spawnOffset), 0.02f);
    }
}
