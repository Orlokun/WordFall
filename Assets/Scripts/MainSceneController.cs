using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{
    MainSceneCanvas msCanvas;

    private string userPlaying;
    private int sceneToGo;


    void Start()
    {
        msCanvas = FindObjectOfType<MainSceneCanvas>();
        msCanvas.DeactivateStageSelectionCanvas();
    }

    public void ChangeDifficulty(int dif)
    {
        Difficulty.difficulty = dif;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DisplayScenesAvailable()
    {
        msCanvas.ToggleMainSceneCanvas(false);
        msCanvas.ActivateStageSelectionCanvas();
        msCanvas.ToggeDifficultyButtons(false, 0);
        msCanvas.ToggeDifficultyButtons(false, 1);
    }

    public void DisplayDifficulty(int level)
    {
        msCanvas.ToggeDifficultyButtons(true, level);
    }



}
