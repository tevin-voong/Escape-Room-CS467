using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Sets up interactable objects
public interface IInteractable
{
    public string InteractionPrompt { get; }
    public bool Interact (Interactor interactor);
}
