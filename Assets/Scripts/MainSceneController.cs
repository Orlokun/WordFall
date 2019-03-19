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

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DisplayScenesAvailable()
    {
        msCanvas.ToggleMainSceneCanvas(false);
        msCanvas.ActivateStageSelectionCanvas();
    }



}
