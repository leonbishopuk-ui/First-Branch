using UnityEngine;

public class teleportScript : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform targetLocation;
    [SerializeField] private GameObject player;
    public void Interact()
    {
        player.transform.position = targetLocation.transform.position;
        player.transform.rotation = targetLocation.transform.rotation;
    }

}
