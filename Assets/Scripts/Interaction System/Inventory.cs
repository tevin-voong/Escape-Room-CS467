using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    // Initialize the HasKey bool to false
    public bool HasKey = false;

    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) HasKey = !HasKey;
    }
}
