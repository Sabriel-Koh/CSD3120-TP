using System.Collections;
using System.Collections.Generic;
// using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DeliveryHole : MonoBehaviour
{
    [SerializeField] private DeliveryHoleCollider collisionManager;
    [SerializeField] private Light indicator;
    [SerializeField] private ParticleSystem emitter;
    [SerializeField] private int successParticleCount;
    [SerializeField] private Color neutralColor;
    [SerializeField] private Color successColor;
    [SerializeField] private float successLightDuration;

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
        StartCoroutine(IndicateSuccess());

    }

    public void OnColliderStay(Collider other)
    {
        //TODO May be helpful for tracking pizza gameobject in the collision area.
        //      Can be removed if not used.
    }

    private IEnumerator IndicateSuccess()
    {
        yield return new WaitForSeconds(0.3f);

        // Particle
        emitter.Emit(successParticleCount);

        // Light
        indicator.color = successColor;
        yield return new WaitForSeconds(successLightDuration);
        indicator.color = neutralColor;


        yield return null;
    }

    private IEnumerator IndicateFail()
    {
        yield return null;
    }
}
