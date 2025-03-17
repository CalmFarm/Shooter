using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text enemiesLeftText;
    [SerializeField] GameObject youWinText;

    int enemiesLeft = 0;

    public void UpdateEnemiesLeftText(int amount)
    {
        enemiesLeft += amount;
        enemiesLeftText.text = "Enemies Left: " + enemiesLeft;

        if (enemiesLeft <= 0)
        {
            youWinText.SetActive(true);
        }
    }
   
    public void RestartLevelButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void QuitButton()
    {
        Debug.LogWarning("Quit");
        Application.Quit();
    }
}
