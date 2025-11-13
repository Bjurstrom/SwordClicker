using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartButtonPress()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int lastSceneIndex = currentSceneIndex - 1;

        if (lastSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            lastSceneIndex = 0;
        }

        SceneManager.LoadScene(lastSceneIndex);

    }
}
