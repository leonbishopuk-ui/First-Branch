using UnityEngine;

public class vfxDisplay : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject vfxToDisplay;

    private void Start()
    {
        vfxToDisplay.SetActive(false);
    }

    public void Interact()
    {
        vfxToDisplay.SetActive(true);
    }

}
