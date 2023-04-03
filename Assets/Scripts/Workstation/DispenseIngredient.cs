using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenseIngredient : MonoBehaviour
{
    [SerializeField] GameObject Ingredient;

    // Update is called once per frame
    void Update()
    {
        //Instantiate(Ingredient, this.transform.position, this.transform.rotation);
    }

    public void Dispense()
    {
        Instantiate(Ingredient, this.transform.position, this.transform.rotation);
    }
}
