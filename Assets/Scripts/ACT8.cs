using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACT8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ACT1());
    }

    private IEnumerator ACT1()
    {
        int suma = 0;

        for (int i = 1; i <= 10; i++)
        {
            yield return new WaitForSeconds(1);
            suma += i;
            Debug.Log(suma);
           
        }

        Debug.Log("Sum of numbers between 1 and 10: " + suma);
    }
}
