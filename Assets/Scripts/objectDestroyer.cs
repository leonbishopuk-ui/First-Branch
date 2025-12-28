using UnityEngine;

public class objectDestroy : MonoBehaviour , IInteractable
{
    public void Interact()

    {
        Debug.Log("Cube 2 Sucessfully Interacted With and destroyed");
        gameObject.SetActive(false);
    }
}

