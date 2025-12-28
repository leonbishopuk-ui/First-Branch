using UnityEngine;

public class debugCommand1 : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Cube 1 Sucessfully Interacted With and Color Changed");
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}