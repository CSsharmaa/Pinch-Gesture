using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTextBehaviour : MonoBehaviour
{
    bool shouldSpin;
    bool isHighlighted;

    //Feel free to choose your own colors
    public Color idleColor = Color.white;
    public Color isHighlightedColor = Color.red;
    MeshRenderer textMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        textMeshRenderer = this.GetComponent<MeshRenderer>();
        shouldSpin = true;
        isHighlighted = false;
        UpdateColor();
    }

    private void FixedUpdate()
    {
        SpinBehavior();
    }


    /// <summary>
    /// Basic behavior of the SpiningCube 
    /// </summary>
    void SpinBehavior()
    {
        if (shouldSpin)
        {
            this.transform.Rotate(0, 1, 0);

        }
    }


    /// <summary>
    /// Updates the cubes material color according to the status (isActivated or Not)
    /// </summary>
    private void UpdateColor()
    {
        if (isHighlighted)
        {
            textMeshRenderer.material.color = isHighlightedColor;
        }
        else
        {
            textMeshRenderer.material.color = idleColor;
        }
    }

    /// <summary>
    /// Toggles the cubes activation value (isActive or Not)
    /// </summary>
    private void ToggleHighlight()
    {
        isHighlighted = !isHighlighted;
    }

    /// <summary>
    /// The code logic of the interaction. In our example, Toggle the status and update the visuals.
    /// </summary>
    public void InteractWithText()
    {
        ToggleHighlight();
        UpdateColor();
    }
}
