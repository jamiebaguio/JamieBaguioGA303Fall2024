using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datatyepractice : MonoBehaviour
{
    public int num1;
    public int num2;
    
    public long num3;

    public uint num4;
    public ulong num5;

    public int additionTotal;

    public char babydadyb = 'B';
    public char babydadya = 'a';
    public char babydadyd = 'd';
    public char babydadyy = 'y';
    public char babydadyz = 'z';

    public string Dada = "He left to get some ciggaretes and milk" + "It's been 34 years";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting number for num1 is: " + num1);
        num1 = num1 + 1;
        Debug.Log("The end number for num1 after adding 1 is: " + num1);

        Debug.Log("Starting number for num2 is: " - num2);
        num2 = num2 - 1;
        Debug.Log("The end number for num2 subtracting 1 is: " - num1);

        Debug.Log("Starting number for num5 is: " * num5);
        num5 = num5 * 2;
        Debug.Log("The end number for num5 multiply 2 is: " * num10)

        Debug.Log("Starting number for num6 is: " / num3);
        num6 = num6 / 3;
        Debug.Log("The end number for num6 is: " / 2)

       Debug.log(babydadyb.ToString() + babydadya.ToString() + babydadyd.ToString() + babydadyy.ToString() + babydadyz.ToString())

        
    }
}

    // Update is called once per frame
    void Father()
    {
        
    }
}
