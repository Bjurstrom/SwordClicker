using TMPro;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    [SerializeField] float upgradeAmount = 1;
    [SerializeField] float price = 10;
    [SerializeField] float priceIncrease = 1.5f;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI priceText;

    UpgradeHandler handler;
    GameManager gameManager;

    public void Awake()
    {
        handler = FindFirstObjectByType<UpgradeHandler>();
        gameManager = FindFirstObjectByType<GameManager>();

        text.text = upgradeAmount.ToString("Click + " + upgradeAmount);
        priceText.text = price.ToString("n0");
    }

    public void AutoClickerPress()
    {
        if (gameManager.money >= price)
        {
            handler.AutoClickUpgradeButtonPress(upgradeAmount);

            gameManager.money -= price;
            price *= priceIncrease;

            priceText.text = price.ToString("n0");
        }
        else { return; }
    }
}
