using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity creates always a specific type of class

public class Main2 : MonoBehaviour // The name of the class is always the same with the file name
                                    // In order to be used as a component a class should include MonoBehaviour
{
    // A class describes the properties and the functionality that an object will have



    // Start is called before the first frame update
    void Start()
    {
        int value = 5;
        int  nNumber = MultiplyByTwo(value);
        Debug.Log(nNumber);

        Health myHealht = new Health(); // This is the way I create an object which has the specifications from the Health.cs file
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo(int number)
    {
        int res = number * 2;
        return res;
    }
}
