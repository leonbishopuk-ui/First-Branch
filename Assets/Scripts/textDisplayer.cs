using UnityEngine;
using TMPro;

public class textDisplayer : MonoBehaviour, IInteractable
{
    [Header("Text Settings")]
    [SerializeField] private string text;
    [SerializeField] private TMP_Text textDisplay;

    public void Interact()
    {
        Debug.Log(text);
        textDisplay.text = text;
    }
}
