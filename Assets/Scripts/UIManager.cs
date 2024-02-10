using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI sumText;
    public TextMeshProUGUI LyricsSongText;
    public TMPro.TextMeshProUGUI textMeshPro;

    public void UpdateSumText(string newText)
    {
        sumText.text = newText;
    }

    public void UpdateSongText(string verse)
    {
        LyricsSongText.text = verse;
    }

    public void UpdateText(string newText)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = newText;
        }
        else
        {
            Debug.LogError("TextMeshProUGUI not assigned in the UIManager.");
        }
    }

}
