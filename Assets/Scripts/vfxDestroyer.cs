using UnityEngine;

public class vfxDestroyer : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject vfxToDestroy;

    private void Start()
    {
        vfxToDestroy.SetActive(true);
    }

    public void Interact()
    {
        vfxToDestroy.SetActive(false);
    }
}
