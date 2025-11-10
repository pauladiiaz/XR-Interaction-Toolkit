using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Renderer))]
public class CuboLejano : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    public Color highlightColor = Color.yellow;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        rend.material.color = highlightColor;
    }

    public void OnSelectExit(SelectExitEventArgs args)
  {
        rend.material.color = originalColor;
  }
}
