using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Display")]
    [SerializeField] TextMeshProUGUI moneyDisplay;
    [SerializeField] TextMeshProUGUI upgradeDisplay;
    [SerializeField] TextMeshProUGUI autoClickerDisplay;

    [Header("Money")]
    [SerializeField] float money;

    [Header("Upgrades")]
    [SerializeField] int clickValue = 1;
    [SerializeField] int autoClickPerSec;

    private void FixedUpdate()
    {
        moneyDisplay.text = money.ToString("n0");
        upgradeDisplay.text = clickValue.ToString();
        autoClickerDisplay.text = autoClickPerSec.ToString("CPS: " + autoClickPerSec);

        money += autoClickPerSec * Time.deltaTime;
    }

    public void ClickerPress()
    {
        money += clickValue;
    }

    public void UpgradeButtonLvl1()
    {
        clickValue += 1;
    }

    
    public void UpgradeButtonLvl2()
    {
        clickValue += 10;
    }

    public void AutoClicker()
    {
        autoClickPerSec += 1;
        Debug.Log(autoClickPerSec);
    }
}
