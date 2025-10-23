using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public float clickValue = 1;
    [SerializeField] float upgradeLevel = 1;

    GameManager gameManager;

    public void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void UpgradeButtonPress()
    {
        clickValue += upgradeLevel;
    }
}
