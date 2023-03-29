using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PrimaryHandController : MonoBehaviour
{
    [SerializeField] private HandVisualizer visualizer;

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        visualizer.SetState(HandVisualizer.State.Select);
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        visualizer.SetState(HandVisualizer.State.Neutral);
    }
}
