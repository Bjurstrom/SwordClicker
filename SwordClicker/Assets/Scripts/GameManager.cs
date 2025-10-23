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
    public float money;

    UpgradeHandler handler;
    AutoClicker autoClicker;

    public void Awake()
    {
        handler = FindFirstObjectByType<UpgradeHandler>();
        autoClicker = FindFirstObjectByType<AutoClicker>();
    }

    public void FixedUpdate()
    {
        moneyDisplay.text = money.ToString("n0");
        upgradeDisplay.text = handler.clickValue.ToString();
        autoClickerDisplay.text = handler.autoClickPerSec.ToString();

        money += handler.autoClickPerSec * Time.deltaTime;
    }

    public void ClickerPress()
    {
        money += handler.clickValue;
    }
}
