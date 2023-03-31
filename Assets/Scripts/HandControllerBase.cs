using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControllerBase : MonoBehaviour
{
    [System.Serializable]
    public class ControllerEvent : UnityEvent { };

    [SerializeField] private HandVisualizer visualizer;

    [SerializeField] public ControllerEvent controllerEvent;

    public virtual void OnSelectEnter(SelectEnterEventArgs args)
    {
        controllerEvent.Invoke();

        visualizer.SetState(HandVisualizer.State.Select);
    }

    public virtual void OnSelectExit(SelectExitEventArgs args)
    {
        controllerEvent.Invoke();

        visualizer.SetState(HandVisualizer.State.Neutral);
    }
}
