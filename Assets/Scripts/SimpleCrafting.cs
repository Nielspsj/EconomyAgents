using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCrafting : MonoBehaviour
{
    //Add the prefab of the hammer in the inspector.
    [SerializeField] private GameObject hammerPref;
    //Write text strings into the list in the inspector to fill the inventory.
    public List<string> inventoryList = new List<string>();
    
    //Call this method on the button to craft.
    public void CraftItem()
    {
        if (inventoryList.Contains("Iron") && inventoryList.Contains("Log"))
        {
            Debug.Log("We can craft!");
            //Spawn hammer
            GameObject hammer = Instantiate(hammerPref) as GameObject;
            //Remove the items from inventory
            inventoryList.Remove("Iron");
            inventoryList.Remove("Log");
        }
    }    
}
