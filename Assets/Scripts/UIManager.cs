
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public Button nextLevelButton;
    public Button restartButton;
    public Button homeButton;

    void Start()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(false);
        }

        if (nextLevelButton != null)
        {
            nextLevelButton.onClick.AddListener(OnNextLevelButtonClicked);
        }
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(OnRestartButtonClicked);
        }
        if (homeButton != null)
        {
            homeButton.onClick.AddListener(OnHomeButtonClicked);
        }
    }

    public void ShowLevelCompletePanel()
    {
        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(true);
        }
    }

    void OnNextLevelButtonClicked()
    {
        GameManager.instance.LoadNextLevel();
    }

    void OnRestartButtonClicked()
    {
        GameManager.instance.RestartLevel();
    }

    void OnHomeButtonClicked()
    {
        GameManager.instance.LoadLevel("Home");
    }
}

