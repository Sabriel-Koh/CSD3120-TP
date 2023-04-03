using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenseIngredient : MonoBehaviour
{

  [SerializeField] public GameObject ingredient;
  [SerializeField] public GameObject spawner;

  // Start is called before the first frame update
  void Start()
  {

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
}
