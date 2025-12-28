using UnityEngine;

public class vfxDisplayer : MonoBehaviour , IInteractable
{
    [SerializeField] private GameObject vfxObject;

    public void Interact()
    {
        Debug.Log("VFX Triggered");
        vfxObject.SetActive(true);

    }

    
}
