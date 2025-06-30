
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public Button nextLevelButton;
    public Button restartButton;
    public Button homeButton;

  public void Start()
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

  public void OnNextLevelButtonClicked()
    {
        GameManager.instance.LoadNextLevel();
    }

  public void OnRestartButtonClicked()
    {
        GameManager.instance.RestartLevel();
    }

  public void OnHomeButtonClicked()
    {
        GameManager.instance.LoadLevel("Home");
    }
}

