using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
class ToppingLayer
{
    public ToppingInfo info;
    public float amount;
}

public class Pizza : MonoBehaviour
{
    [SerializeField] private float maxBakeLevel;
    [SerializeField] private float bakeReadyLevel;

    [SerializeField] private ParticleSystem readyEmitter;
    [SerializeField] private int readyParticleCount;

    //TODO Check if ScriptableObjects are copy by value.
    private Dictionary<ToppingInfo, ToppingLayer> toppings = new Dictionary<ToppingInfo, ToppingLayer>();
    [SerializeField] private float bakeLevel = 0;

    //DEBUG
    [SerializeField] private List<ToppingLayer> D_toppings = new List<ToppingLayer>();

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Topping")
        {
            Topping topping = other.gameObject.GetComponent<Topping>();
            AddTopping(topping.Info);
            ConsumeTopping(topping);
        }
    }

    public void AddBakeLevel(float level)
    {
        bakeLevel += level;

        // Trigger on bake ready.
        if (bakeLevel < bakeReadyLevel 
            && (bakeLevel + level) >= bakeReadyLevel)
        {
            OnBakeReady();
        }

        // Clamp to max level.
        if (bakeLevel > maxBakeLevel) { bakeLevel = maxBakeLevel; }
    }

    private void AddTopping(ToppingInfo toppingInfo)
    {
        // Add empty layer if doesn't exist.
        if (!toppings.ContainsKey(toppingInfo))
        {
            toppings.Add(toppingInfo, new ToppingLayer() {
                info = toppingInfo,
                amount = 0
            });

            //DEBUG
            D_toppings.Add(toppings[toppingInfo]);
        }

        // Increment layer amount.
        toppings[toppingInfo].amount += toppingInfo.amountPerUnit;
    }

    private void OnBakeReady()
    {
        readyEmitter.Emit(readyParticleCount);
    }

    private void ConsumeTopping(Topping topping)
    {
        topping.Consume(gameObject);
    }
}
