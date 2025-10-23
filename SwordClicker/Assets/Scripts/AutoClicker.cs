using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    [SerializeField] float autoClickLevel = 1;

    UpgradeHandler handler;
    GameManager gameManager;

    public void Awake()
    {
        handler = FindFirstObjectByType<UpgradeHandler>();
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void AutoClickerPress()
    {
        handler.AutoClickUpgradeButtonPress(autoClickLevel);
        Debug.Log(handler.autoClickPerSec);
    }
}
