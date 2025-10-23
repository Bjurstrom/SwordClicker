using UnityEngine;

public class UpgradeHandler : MonoBehaviour
{
    [SerializeField] public float clickValue = 1;

    public float autoClickPerSec;


    GameManager gameManager;

    public void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void UpgradeButtonPress(float upgradeAmount)
    {
        clickValue += upgradeAmount;
    }

    public void AutoClickUpgradeButtonPress(float upgradeAmount)
    {
        autoClickPerSec += upgradeAmount;
    }
}
