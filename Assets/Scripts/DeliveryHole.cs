using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryHole : MonoBehaviour
{
    [SerializeField] private DeliveryHoleCollider collisionManager;
    [SerializeField] private Light indicator;

    void Start()
    {
        collisionManager.RegisterOnEnterHandler(OnColliderEnter);
        collisionManager.RegisterOnStayHandler(OnColliderStay);
    }

    void Update()
    {
        
    }

    public void OnColliderEnter(Collider other)
    {
        //TODO Contiue if $other is pizza. Otherwise, return.

        //TODO Start coroutine to show success feedback, (e.g. turn light to green, emit particles)
        //      then destroy pizza gameobject.
    }

    public void OnColliderStay(Collider other)
    {
        //TODO May be helpful for tracking pizza gameobject in the collision area.
        //      Can be removed if not used.
    }

    private IEnumerator IndicateSuccess()
    {
        yield return null;
    }

    IEnumerator IndicateFail()
    {
        yield return null;
    }
}
