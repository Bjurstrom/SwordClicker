using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public float autoClickPerSec;
    [SerializeField] float autoClickLevel = 1;

    GameManager gameManager;

    public void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void AutoClickerPress()
    {
        autoClickPerSec += autoClickLevel;
        Debug.Log(autoClickPerSec);
    }
}
