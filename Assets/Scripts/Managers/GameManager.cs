using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        ServiceHub.Instance.LevelManager
            .NewTransition()
            .Load(SceneDataBase.Slots.MainMenu, SceneDataBase.Scenes.MainMenu)
            .WithOverlay()
            .Perform();
    }
}