using UnityEngine;

public class collideDestroy : MonoBehaviour
{
    [SerializeField] private GameObject objectToDestroy;
    private void Start()
    {
        objectToDestroy.SetActive(true);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectToDestroy.SetActive(false);
        }   
    }
}
