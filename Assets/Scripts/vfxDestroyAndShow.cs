using UnityEngine;

public class vfxDestroyAndShow : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject vfxToDestroy;
    [SerializeField] private GameObject vfxToDisplay;
    

    private void Start()
    {
        vfxToDisplay.SetActive(false);
    }
    public void Interact()
    {
        vfxToDestroy.SetActive(false);
        vfxToDisplay.SetActive(true);
    }
}
