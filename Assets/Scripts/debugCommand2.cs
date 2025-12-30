using UnityEngine;

public class debugCommand2 : MonoBehaviour , IInteractable
{
    public string message;
    public void Interact()
    {
        Debug.Log(message);
        gameObject.SetActive(false);
    }
}

