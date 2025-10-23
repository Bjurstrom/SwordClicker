using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Display")]
    [SerializeField] TextMeshProUGUI moneyDisplay;
    [SerializeField] TextMeshProUGUI upgradeDisplay;
    [SerializeField] TextMeshProUGUI autoClickerDisplay;

    [Header("Money")]
    [SerializeField] float money;

    UpgradeButton upgradeButton;
    AutoClicker autoClicker;

    public void Awake()
    {
        upgradeButton = FindFirstObjectByType<UpgradeButton>();
        autoClicker = FindFirstObjectByType<AutoClicker>();
    }

    private void FixedUpdate()
    {
        moneyDisplay.text = money.ToString("n0");
        upgradeDisplay.text = upgradeButton.clickValue.ToString();
        autoClickerDisplay.text = autoClicker.autoClickPerSec.ToString("CPS: " + autoClicker.autoClickPerSec);

        money += autoClicker.autoClickPerSec * Time.deltaTime;
    }

    public void ClickerPress()
    {
        money += upgradeButton.clickValue;
    }
}
