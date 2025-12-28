using UnityEngine;

public class lightCollider : MonoBehaviour
{
    [SerializeField] private Light controlledLight;

    private void Start()
    {
        controlledLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controlledLight.enabled = true;
        }
    }
}
