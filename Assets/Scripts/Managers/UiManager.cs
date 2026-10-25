using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject gameOverUI;

    private void Update()
    {
        FindUI();
    }

    public void FindUI()
    {
        mainMenuUI = GameObject.FindGameObjectWithTag("MainMenuUI");
        gameplayUI = GameObject.FindGameObjectWithTag("GameplayUI");
        gameOverUI = GameObject.FindGameObjectWithTag("GameOverUI");
    }

    public void HideAllUI()
    {
        if(mainMenuUI != null) mainMenuUI.SetActive(false);
        if(gameplayUI != null) gameplayUI.SetActive(false);
        if(gameOverUI != null) gameOverUI.SetActive(false);
    }

    public void ShowMainMenuUI()
    {
        if (mainMenuUI != null) mainMenuUI.SetActive(true);
    }

    public void ShowGameplayUI()
    {
        if (mainMenuUI != null) mainMenuUI.SetActive(false);
        if (gameplayUI != null) gameplayUI.SetActive(true);
        if (gameOverUI != null) gameOverUI.SetActive(false);
    }

    public void ShowGameOverUI()
    {
        if (gameOverUI != null) gameOverUI.SetActive(true);
        if (gameplayUI != null) gameplayUI.SetActive(false);
    }

}


