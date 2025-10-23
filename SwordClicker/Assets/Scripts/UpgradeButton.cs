using TMPro;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] float upgradeAmount;
    [SerializeField] float price;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI priceText;

    UpgradeHandler handler;
    GameManager gameManager;


    private void Awake()
    {
        handler = FindFirstObjectByType<UpgradeHandler>();
        gameManager = GetComponent<GameManager>();

        text.text = upgradeAmount.ToString("Click + " + upgradeAmount);
        priceText.text = price.ToString();
    }

    public void UpgradeButtonClick()
    {
        if (gameManager.money >= price)
        {
            handler.UpgradeButtonPress(upgradeAmount);
        }
    }
}
