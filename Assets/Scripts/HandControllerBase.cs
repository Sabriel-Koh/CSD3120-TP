using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControllerBase : MonoBehaviour
{
    [System.Serializable]
    public class HoverEnterEvent : UnityEvent<HoverEnterEventArgs> { };
    [System.Serializable]
    public class HoverExitEvent : UnityEvent<HoverExitEventArgs> { };
    [System.Serializable]
    public class SelectEnterEvent : UnityEvent<SelectEnterEventArgs> { };
    [System.Serializable]
    public class SelectExitEvent : UnityEvent<SelectExitEventArgs> { };

    [SerializeField] private HandVisualizer visualizer;

    [SerializeField] public HoverEnterEvent hoverEnterEvent;
    [SerializeField] public HoverExitEvent hoverExitEvent;
    [SerializeField] public SelectEnterEvent selectEnterEvent;
    [SerializeField] public SelectExitEvent selectExitEvent;

    // Flag for whether the controller is performing a hover.
    public bool IsHovering { get; private set; }

    // Flag for whether the controller is performing a selection.
    public bool IsSelecting { get; private set; }

    public virtual void OnHoverEnter(HoverEnterEventArgs args)
    {
        hoverEnterEvent.Invoke(args);
        IsHovering = true;
    }

    public virtual void OnHoverExit(HoverExitEventArgs args)
    {
        hoverExitEvent.Invoke(args);
        IsHovering = false;
    }

    public virtual void OnSelectEnter(SelectEnterEventArgs args)
    {
        selectEnterEvent.Invoke(args);
        IsSelecting = true;

        visualizer.SetState(HandVisualizer.State.Select);
    }

    public virtual void OnSelectExit(SelectExitEventArgs args)
    {
        selectExitEvent.Invoke(args);
        IsSelecting = false;

        visualizer.SetState(HandVisualizer.State.Neutral);
    }
}
