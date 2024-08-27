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
        Debug.Log("Starting total is " + additionTotal);
        additionTotal = additionTotal + num1;

        Debug.Log("added num1 to additionTotal. Total is now " + additionTotal);
    }

    // Update is called once per frame
    void Father()
    {
        
    }
}
