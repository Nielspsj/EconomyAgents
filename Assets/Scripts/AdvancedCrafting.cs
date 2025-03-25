using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedCrafting : MonoBehaviour
{
    //Use the pickup script you have from before to pick up items and add to inventory.
    [SerializeField] private Pickup2D pickup2D;

    //Put the Blueprint script on a Blueprint prefab.
    //Add the blueprint prefab in the inspector.
    //The required materials and crafted item are all stored in the blueprint script.
    [SerializeField] private Blueprint currentBlueprint;

    public void CraftItem()
    {
        //Make a new list for found materials every time we craft.
        List<GameObject> foundBlueprintMaterials = new List<GameObject>();

        foreach (GameObject blueprintMaterial in currentBlueprint.requiredMaterials)
        {
            GameObject foundItem = null;
            //Search in the inventory for the blueprint material 
            foreach (GameObject item in pickup2D.inventoryObjList)
            {
                if (item.name == blueprintMaterial.name)
                {
                    foundItem = item;
                    //Stop searching in the inventory
                    break;
                }
            }
            if (foundItem != null)
            {
                foundBlueprintMaterials.Add(foundItem);
            }
            else
            {
                Debug.Log("Missing ingredients");
                // Stop crafting if any ingredient is missing.
                return; 
            }
        }

        Debug.Log("All ingredients are found <3");

        //Remove the ingredients from the inventory.
        foreach (GameObject item in foundBlueprintMaterials)
        {
            pickup2D.inventoryObjList.Remove(item);
            Destroy(item);
        }

        GameObject craftedItem = Instantiate(currentBlueprint.craftedItemPrefab);
        Debug.Log("Crafting complete!");
    }
}
