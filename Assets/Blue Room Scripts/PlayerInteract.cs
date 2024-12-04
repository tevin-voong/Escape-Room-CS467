using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                if (collider.TryGetComponent(out FountainInteractable fountainInteractable)) {
                    fountainInteractable.Interact();
                }
            }
        }
    }
    public FountainInteractable GetInteractableObject() {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray) {
            if (collider.TryGetComponent(out FountainInteractable fountainInteractable)) {
                    return fountainInteractable;
            }
        }
        return null;
    }
}
