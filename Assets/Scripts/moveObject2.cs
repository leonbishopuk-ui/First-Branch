using UnityEngine;

public class moveObject2 : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject objectToMove;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;
    [SerializeField] private GameObject object3;
    public float speed;
    private bool isMoving = false;

    public void Interact()
    {
        if(gameObject == object2)
        {
            Debug.Log("Correct Object Selected");
            isMoving = true;
        }
        else
        {
            Debug.Log("Wrong Object Selected");
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }
}
