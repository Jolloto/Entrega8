using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class ACT8 : MonoBehaviour
{
   
   [SerializeField] private TextMeshProUGUI sumText;
   [SerializeField] private TextMeshProUGUI versosText;
   [SerializeField] private TextMeshProUGUI cadenaletrasText;
    private string dondeestalaA = "I like videogames";

    void Start()
    {
        StartCoroutine(ACT1());
        StartCoroutine(ACT2());
        StartCoroutine(ACT3());
    }

    private IEnumerator ACT1()
    {
        int suma = 0;

        for (int i = 1; i <= 10; i++)
        {
            sumText.SetText($"{suma}");
            suma += i;
            yield return new WaitForSeconds(1);
        }

        sumText.SetText("Sum of numbers between 1 and 10: " + suma);
    }

    private IEnumerator ACT2()
    {
        for (int i = 10; i > 0; i--) 
        { 
            Debug.Log(i +  "  green bottles\nHanging on the wall");

            if(i == 1)
            {
                yield return new WaitForSeconds(0.5f);
                versosText.text = "And if one green bottle Should accidentally fall There'll be no green bottles Hanging on the wall";
            }
            else
            {
                yield return new WaitForSeconds(0.5f);
                versosText.text = "And if one green bottle Should accidentally fall There'll be "  + (i-1) +  " green bottles Hanging on the wall";
            }
        }
    }

    private IEnumerator ACT3()
    {
        for (int i = 0; i < dondeestalaA.Length; i++)
        {
            cadenaletrasText.SetText($"{dondeestalaA[i]}");
            yield return new WaitForSeconds(0.2f);
        }
    }



}


