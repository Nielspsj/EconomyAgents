using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI goldText;
   

    public void UpdateGold(int gold)
    {
        Debug.Log("gold: " + gold);
 
        goldText.text = gold.ToString();
    }
}
