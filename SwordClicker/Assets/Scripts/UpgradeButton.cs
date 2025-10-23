using TMPro;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] float upgradeAmount;
    [SerializeField] TextMeshProUGUI text;
    UpgradeHandler handler;


    private void Awake()
    {
        handler = FindFirstObjectByType<UpgradeHandler>();
        text.text = upgradeAmount.ToString("Click + " + upgradeAmount);
    }

    public void UppgradeButtonClick()
    {
        handler.UpgradeButtonPress(upgradeAmount);
    }
}
