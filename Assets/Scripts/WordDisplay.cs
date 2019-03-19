using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    private string myWord;
    public TextMeshPro text;
    public float fallingSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
        myWord = word;
    }

    public void SetWordSizeAndColor()
    {
        text.fontSize = 300;
        VertexGradient textGradient = text.colorGradient;
        textGradient.bottomLeft = new Color32(33, 255, 0, 255);
        textGradient.bottomRight = new Color32(112, 215, 167, 255);
        textGradient.topLeft = new Color32(18, 230, 154, 255);
        textGradient.topRight = new Color32(169, 223, 255, 255);
        text.colorGradient = textGradient;

    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        VertexGradient textGradient = text.colorGradient;
        textGradient.bottomLeft = new Color32(255, 185, 0, 255);
        textGradient.bottomRight = new Color32(255, 84, 84, 255);
        textGradient.topLeft = new Color32(255, 49, 96, 255);
        textGradient.topRight = new Color32(255, 0, 0, 255);
        text.colorGradient = textGradient;
    }

    public void RestartWordDisplay()
    {
        text.text = myWord;
        VertexGradient textGradient = text.colorGradient;
        textGradient.bottomLeft = new Color32(33, 255, 0, 255);
        textGradient.bottomRight = new Color32(112, 215, 167, 255);
        textGradient.topLeft = new Color32(18, 230, 154, 255);
        textGradient.topRight = new Color32(169, 223, 255, 255);
        text.colorGradient = textGradient;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallingSpeed * Time.deltaTime, 0);
    }
}
