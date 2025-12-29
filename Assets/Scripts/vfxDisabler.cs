using UnityEngine;

public class onOffSwitch : MonoBehaviour , IInteractable
{
    public GameObject VFXObject;

    public void Interact()
    {
        if (VFXObject != null)
        {
            VFXObject.SetActive(!VFXObject.activeSelf);
        }
    }

    
}
