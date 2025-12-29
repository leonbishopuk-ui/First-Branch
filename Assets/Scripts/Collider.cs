using UnityEngine;

public class CollidedObj : MonoBehaviour
{
    [SerializeField] private GameObject collidedObject;

    private void Start()
    {
        collidedObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has collided");
            collidedObject.SetActive(true);
        }
    }
}
