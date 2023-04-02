using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceGun : MonoBehaviour
{
    [SerializeField] GameObject BallSpawnPoint;
    [SerializeField] GameObject Ball;

    private void Update() {
        if(Input.GetButtonDown("Fire1")) {
            Instantiate(Ball, BallSpawnPoint.transform.position, BallSpawnPoint.transform.rotation);
        }
    }
}
