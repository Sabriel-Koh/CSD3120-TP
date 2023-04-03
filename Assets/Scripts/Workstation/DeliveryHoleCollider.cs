using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DeliveryHoleCollider : MonoBehaviour
{
    public delegate void OnTriggerEnterHandler(Collider other);
    public delegate void OnTriggerStayHandler(Collider other);

    private List<OnTriggerEnterHandler> onEnterHandlers = new List<OnTriggerEnterHandler>();
    private List<OnTriggerStayHandler> onStayHandlers = new List<OnTriggerStayHandler>();

    public void RegisterOnEnterHandler(OnTriggerEnterHandler handler)
    {
        onEnterHandlers.Add(handler);
    }

    public void RegisterOnStayHandler(OnTriggerStayHandler handler)
    {
        onStayHandlers.Add(handler);
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (OnTriggerEnterHandler handler in onEnterHandlers)
        {
            handler(other);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        foreach (OnTriggerStayHandler handler in onStayHandlers)
        {
            handler(other);
        }
    }
}
