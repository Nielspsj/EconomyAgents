using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGenerator : MonoBehaviour
{
    //vTest1: Click cookie for gold.
    //vTest2: Get more gold per click with UI button.
    //vTest3: Create an auto clicker with coroutine. Able to buy one with button.
    //vTest4: Increase auto clicker speed.

    //Serialize to keep it private but accessible in the inspector.
    [SerializeField] private UIManager uIManager;
    private int currentGold = 0;
    private int goldFromClick = 10;
    private float clickDelay = 2f;


    public void CookieClicked()
    {
        //Debug.Log("clicked the cookie");
        currentGold += goldFromClick;
        uIManager.UpdateGold(currentGold);
    }
    public void MoreGoldPerClick(int cost)
    {
        if (currentGold >= cost)
        {
            currentGold -= cost;
            goldFromClick += 10;
            uIManager.UpdateGold(currentGold);
        }        
    }

    public void BuyAnAutoclicker(int cost)
    {
        if (currentGold >= cost)
        {
            currentGold -= cost;
            StartCoroutine(AutoClicker());
            uIManager.UpdateGold(currentGold);
        }
    }

    public void IncreaseAutoClickSpeed(int cost)
    {
        if (currentGold >= cost)
        {
            currentGold -= cost;
            clickDelay -= 0.1f;
            uIManager.UpdateGold(currentGold);
        }
    }

    //Use while loop to keep it repeating itself while true.
    private IEnumerator AutoClicker()
    {
        while (true)
        {
            yield return new WaitForSeconds(clickDelay);
            CookieClicked();
        }
    }
}
