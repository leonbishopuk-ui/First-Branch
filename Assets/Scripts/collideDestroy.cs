using UnityEngine;

public class collideDestroy : MonoBehaviour
{
    [SerializeField] private GameObject objectToDestroy;
    private void Start()
    {
        objectToDestroy.SetActive(true);
    }

    private void OnTriggerEnter(Collider Player)
    {
        Destroy(objectToDestroy);
    }
}
