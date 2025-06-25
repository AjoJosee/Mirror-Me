
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomePageUI : MonoBehaviour
{
    public Button playButton;
    public Button levelSelectButton;
    public Button quitButton;

    void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        levelSelectButton.onClick.AddListener(OnLevelSelectButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Level1"); // Load the first level
    }

    public void OnLevelSelectButtonClicked()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }
}

