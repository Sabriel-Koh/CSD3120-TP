using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class InteractorBase : MonoBehaviour
{
    [Tooltip("XR Interactor script instance.\n" +
        "Can be left empty to search within the same GameObject.")]
    [SerializeField] private XRBaseInteractor interactorScript;

    private void Awake()
    {
        if (interactorScript == null)
        {
            interactorScript = GetComponent<XRBaseInteractor>();
        }

        if (interactorScript)
        {
            interactorScript.hoverEntered.AddListener(OnHoverEnter);
            interactorScript.hoverExited.AddListener(OnHoverExit);
            interactorScript.selectEntered.AddListener(OnSelectEnter);
            interactorScript.selectExited.AddListener(OnSelectExit);
        }
    }

    public virtual void OnHoverEnter(HoverEnterEventArgs args)
    { }

    public virtual void OnHoverExit(HoverExitEventArgs args)
    { }

    public virtual void OnSelectEnter(SelectEnterEventArgs args)
    { }

    public virtual void OnSelectExit(SelectExitEventArgs args)
    { }
}
