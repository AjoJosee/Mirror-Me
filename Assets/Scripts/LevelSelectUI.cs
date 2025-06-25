
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectUI : MonoBehaviour
{
    public Button[] levelButtons;

    void Start()
    {
        UpdateLevelButtons();
    }

    void UpdateLevelButtons()
    {
        int lastCompletedLevel = PlayerPrefs.GetInt("lastCompletedLevel", 0);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i <= lastCompletedLevel)
            {
                levelButtons[i].interactable = true;
                int levelIndex = i + 1; // Levels are 1-indexed
                levelButtons[i].onClick.AddListener(() => LoadLevel("Level" + levelIndex));
            }
            else
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}

