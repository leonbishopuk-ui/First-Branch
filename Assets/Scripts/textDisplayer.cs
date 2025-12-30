using UnityEngine;
using TMPro;

public class textDisplayer : MonoBehaviour, IInteractable
{
    [Header("Text Settings")]
    [SerializeField] private string text;
    [SerializeField] private TMP_Text textDisplay;

    public void Interact()
    {
        textDisplay.text = text;
    }
}
