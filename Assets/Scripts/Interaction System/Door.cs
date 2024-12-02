using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    
    // Sets up intereaction prompts for Doors depending on HasKey
    public bool Interact(Interactor interactor)
    {   

        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null) return false;

        if (inventory.HasKey)
        {
            Debug.Log(message:"Opening door!");
            return true;
        }

        Debug.Log(message:"No key found!");
        return false;
    }
}
