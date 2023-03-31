using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SecondaryHandController : HandControllerBase
{
    [SerializeField] private GameObject rayInteractorGameObject;
    [SerializeField] private XRDirectInteractor directInteractor;

    private XRController xrController;
    private XRRayInteractor rayInteractor;

    private void Awake()
    {
        rayInteractor = rayInteractorGameObject.GetComponent<XRRayInteractor>();
    }

    private void Update()
    {

    }
}
