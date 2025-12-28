using UnityEngine;

public class destroySelector : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject selectedObject;

    public void Interact()
    {
        Destroy(selectedObject);
    }
}


