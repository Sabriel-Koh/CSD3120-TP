using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public abstract class InteractableBase : MonoBehaviour
{
    [Tooltip("XR Interactable script instance.\n" +
        "Can be left empty to search within the same GameObject.")]
    [SerializeField] private XRBaseInteractable interactableScript;

    private void Awake()
    {
        if (interactableScript == null)
        {
            interactableScript = GetComponent<XRBaseInteractable>();
        }

        if (interactableScript)
        {
            interactableScript.hoverEntered.AddListener(OnHoverEnter);
            interactableScript.hoverExited.AddListener(OnHoverExit);
            interactableScript.selectEntered.AddListener(OnSelectEnter);
            interactableScript.selectExited.AddListener(OnSelectExit);
            interactableScript.activated.AddListener(OnActivate);
            interactableScript.deactivated.AddListener(OnDeactivate);
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

    public virtual void OnActivate(ActivateEventArgs args)
    { }

    public virtual void OnDeactivate(DeactivateEventArgs args)
    { }
}
