using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CuboCercano : MonoBehaviour
{
    void Start()
    {
        var grab = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grab.selectEntered.AddListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("¡Has agarrado el cubo cercano!");
    }
}

