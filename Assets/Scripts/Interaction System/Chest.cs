using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    
    // Setting up itereaction prompts when intereacting with chest
    public bool Interact (Interactor interactor)
    {
        Debug.Log(message:"Opening Chest!");
        return true;
    }
}
