using UnityEngine;

public class moveObject : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject objectToMove;
    [SerializeField] private Transform targetPosition;
    public float speed;
    private bool isMoving = false;
    public string message;

    public void Interact()
    {
        Debug.Log(message);
        isMoving = true;
    }

    private void Update()
    {
        if (isMoving)
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }
}
