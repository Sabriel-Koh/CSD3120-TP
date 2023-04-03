using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class IngredientDispenser : InteractableBase
{

    public GameObject ingredient;
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Ingredient, this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
    //Instantiate(ingredient, spawner.transform.position, spawner.transform.rotation);
    }

    public void Dispense()
    {
        Instantiate(ingredient, spawner.transform.position, spawner.transform.rotation);
    }

    public override void OnHoverEnter(HoverEnterEventArgs args)
    {
        Debug.Log("OnHoverEnter Dispensing.");
        Dispense();
    }

    public override void OnSelectEnter(SelectEnterEventArgs args)
    {
        Debug.Log("OnSelectEnter Dispensing.");
        Dispense();
    }
}
