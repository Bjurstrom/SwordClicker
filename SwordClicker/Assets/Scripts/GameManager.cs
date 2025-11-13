using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Display")]
    [SerializeField] TextMeshProUGUI moneyDisplay;
    [SerializeField] TextMeshProUGUI upgradeDisplay;
    [SerializeField] TextMeshProUGUI autoClickerDisplay;
    [SerializeField] TextMeshProUGUI swordWorthDisplay;

    [Header("Money")]
    public float money;
    public float swordWorth;

    [Header("Cursor")]
    [SerializeField] Texture2D cursorTexture;
    [SerializeField] Vector2 cursorTarget;


    UpgradeHandler handler;
    AutoClicker autoClicker;

    public void Awake()
    {
        handler = FindFirstObjectByType<UpgradeHandler>();
        autoClicker = FindFirstObjectByType<AutoClicker>();
        Cursor.SetCursor(cursorTexture, cursorTarget, CursorMode.Auto);
    }

    public void FixedUpdate()
    {
        moneyDisplay.text = money.ToString("n0");
        upgradeDisplay.text = handler.clickValue.ToString();
        autoClickerDisplay.text = handler.autoClickPerSec.ToString();
        swordWorthDisplay.text = swordWorth.ToString("n0");

        swordWorth += handler.autoClickPerSec * Time.deltaTime;
    }

    public void ClickerPress()
    {
        swordWorth += handler.clickValue;
    }

    public void SwordSell()
    {
        money += swordWorth;
        swordWorth = 0;
    }
}
