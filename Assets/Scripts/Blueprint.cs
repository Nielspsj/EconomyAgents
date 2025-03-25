using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprint : MonoBehaviour
{
    //This script could also be a ScriptableObject.

    //Put the Blueprint script on a Blueprint prefab.
    //Make duplicates of the prefab if you want more blueprints.
    //Fill in the required materials and prefab for the item to craft.

    public List<GameObject> requiredMaterials = new List<GameObject>(); // List of ingredients
    public GameObject craftedItemPrefab; // The item to craft
}
