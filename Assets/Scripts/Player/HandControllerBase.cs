using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControllerBase : InteractorBase
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

    [Header("Events")]
    [SerializeField] public HoverEnterEvent hoverEnterEvent;
    [SerializeField] public HoverExitEvent hoverExitEvent;
    [SerializeField] public SelectEnterEvent selectEnterEvent;
    [SerializeField] public SelectExitEvent selectExitEvent;

    // Flag for whether the controller is performing a hover.
    public bool IsHovering { get; private set; }

    // Flag for whether the controller is performing a selection.
    public bool IsSelecting { get; private set; }

    public override void OnHoverEnter(HoverEnterEventArgs args)
    {
        base.OnHoverEnter(args);

        hoverEnterEvent.Invoke(args);
        IsHovering = true;
    }

    public override void OnHoverExit(HoverExitEventArgs args)
    {
        base.OnHoverExit(args);

        hoverExitEvent.Invoke(args);
        IsHovering = false;
    }

    public override void OnSelectEnter(SelectEnterEventArgs args)
    {
        base.OnSelectEnter(args);

        selectEnterEvent.Invoke(args);
        IsSelecting = true;

        visualizer.SetState(HandVisualizer.State.Select);
    }

    public override void OnSelectExit(SelectExitEventArgs args)
    {
        base.OnSelectExit(args);

        selectExitEvent.Invoke(args);
        IsSelecting = false;

        visualizer.SetState(HandVisualizer.State.Neutral);
    }
}
