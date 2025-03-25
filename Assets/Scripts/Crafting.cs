using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    //vTest1: Check if we have iron and log in the inventory list
    //vTest2: Craft the hammer item. Spawn a prefab, destroy the crafting ingredients.

    [SerializeField] private Pickup2D pickup2D;
    [SerializeField] private GameObject hammerPref;

    [Header("Blueprint 1")]
    [SerializeField] private GameObject blueprintMaterial_1;
    [SerializeField] private GameObject blueprintMaterial_2;
    private GameObject ingredient1 = null;
    private GameObject ingredient2 = null;

    private List<GameObject> bluePrintList = new List<GameObject>();

    private void Start()
    {
        Blueprint_Hammer();
    }
    private void Blueprint_Hammer()
    {
        bluePrintList.Add(blueprintMaterial_1);
        bluePrintList.Add(blueprintMaterial_2);
    }

    public void CraftHammer()
    {
        if (pickup2D.inventoryList.Contains("Iron") && pickup2D.inventoryList.Contains("Log"))
        {
            Debug.Log("We can craft!");
            //Spawn hammer
            GameObject hammer = Instantiate(hammerPref) as GameObject;
            //Clear the inventory items
            pickup2D.inventoryList.Remove("Iron");
            pickup2D.inventoryList.Remove("Log");
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

    public void CraftTheHammer()
    {
        foreach (GameObject item in pickup2D.inventoryObjList)
        {
            if (item.name == blueprintMaterial_1.name && ingredient1 == null)
            {
                ingredient1 = item;
            }
            else if (item.name == blueprintMaterial_2.name && ingredient2 == null)
            {
                ingredient2 = item;
            }

            // Stop searching if both ingredients are found
            if (ingredient1 != null && ingredient2 != null)
                break;
        }

        if (ingredient1 != null && ingredient2 != null)
        {
            Debug.Log("Both ingredients found! Crafting...");
            CraftItem();
        }
        else
        {
            Debug.Log("Missing ingredients!");
        }
    }

    private void CraftItem()
    {
        // Example: Create a new crafted item in the scene
        Instantiate(hammerPref, Vector3.zero, Quaternion.identity);
        Debug.Log("Crafting complete!");
        //Remove ingredients from inventory
        pickup2D.inventoryObjList.Remove(ingredient1);
        pickup2D.inventoryObjList.Remove(ingredient2);

        // Destroy ingredients (if needed)
        Destroy(ingredient1);
        Destroy(ingredient2);
    }
}
