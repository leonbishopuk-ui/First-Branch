using UnityEngine;
using TMPro;

public class onAwake : MonoBehaviour
{
   
   [Header("Text Settings")]
   [SerializeField] private string textToDisplay;
    [SerializeField] private TMPro.TMP_Text textDisplay;
    [SerializeField] private float fontSize;

    [Header("VFX Settings")]
    [SerializeField] private GameObject vfxToDestroy;
    [SerializeField] private GameObject vfxToDisplay;

    [Header("Light Settings")]
    [SerializeField] private Light lightToToggle;

    private void Awake()
    {
        // Display text on awake
        if (textDisplay != null)
        {
            textDisplay.text = textToDisplay;
        }

        // Toggle VFX on awake
        if (vfxToDestroy != null)
        {
            vfxToDestroy.SetActive(false);
        }
        if (vfxToDisplay != null)
        {
            vfxToDisplay.SetActive(true);
        }

        // Toggle light on awake
        if (lightToToggle != null)
        {
            lightToToggle.enabled = !lightToToggle.enabled;
        }
    }
}
