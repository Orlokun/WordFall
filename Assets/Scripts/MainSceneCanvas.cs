using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainSceneCanvas : MonoBehaviour {

    private MainSceneController msController;
    public GameObject[] availableStages;
    public GameObject[] mainSceneObjects;


    // Use this for initialization
    void Start()
    {
        if (FindObjectOfType<MainSceneController>())
        {
            msController = FindObjectOfType<MainSceneController>();
        }
        else
        {
            Debug.LogError("Te equivocaste loco!");
        }

        //Encontrar el Archivo del cual sacar las etapas
        //Contar cuántas etapas son
        //Calcular tamaño y cuadrícula de posición para crear cada uno de los objetos
        //
        //Considerar si es necesario un scrolling
        //Generar los prefabs al tamaño indicado

    }

    public void ToggleCanvasObject(GameObject button, bool switchValue)
    {
        if (switchValue)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }

    public void DeactivateStageSelectionCanvas()
    {
        foreach (GameObject gObject in availableStages)
        {
            ToggleCanvasObject(gObject, false);
        }
    }

    public void ActivateStageSelectionCanvas()
    {
        foreach (GameObject gObject in availableStages)
        {
            ToggleCanvasObject(gObject, true);
        }
    }

    public void ToggleMainSceneCanvas(bool switchStatus)
    {
        foreach (GameObject gObject in mainSceneObjects)
        {
            ToggleCanvasObject(gObject, switchStatus);
        }
    }

}
