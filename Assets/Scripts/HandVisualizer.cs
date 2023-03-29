using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class HandVisualizer : MonoBehaviour
{
    public enum State
    {
        Neutral,
        Select,
        Activate
    }

    [SerializeField] private Material neutralMaterial;
    [SerializeField] private Material selectMaterial;
    [SerializeField] private Material activateMaterial;

    private MeshRenderer meshRenderer;

    public void SetState(State state)
    {
        switch (state)
        {
            case State.Neutral:
                meshRenderer.material = neutralMaterial;
                break;
            case State.Select:
                meshRenderer.material = selectMaterial;
                break;
            case State.Activate:
                meshRenderer.material = activateMaterial;
                break;
        }
    }

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
}
