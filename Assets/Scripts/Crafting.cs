using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    //Test1: Check if we have iron and log in the inventory list
    //Test2: Craft the hammer item. Spawn a prefab, destroy the crafting ingredients.

    [SerializeField] private Pickup2D pickup2D;
    [SerializeField] private List<string> blueprint = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CraftHammer()
    {
        if (pickup2D.inventoryList.Contains("Iron") && pickup2D.inventoryList.Contains("Log"))
        {
            Debug.Log("We can craft!");
            //Spawn hammer
            //Clear the inventory items
        }

        /*
        if (pickup2D.inventoryList.Count > 0)
        {
            foreach (GameObject craftingIngredient in pickup2D.inventoryList)
            {
                //Debug.Log("check list");

                if (craftingIngredient.name == "Iron")
                {
                    Debug.Log("We have iron!");
                }
                else
                {
                    Debug.Log("We don't have what we need :(");
                }
            }
        }
        else
        {
            Debug.Log("Nothing in our pockets :(");
        }   
        */
    }
}
