﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu(); 
    }

    void ShowMainMenu()
    {
        Terminal.WriteLine("What would you like to HACK today?");
        Terminal.WriteLine("Press 1 to hack the local library.");
        Terminal.WriteLine("Press 2 to hack the local police station.");
        Terminal.WriteLine("Enter your selection: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
