using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScale : MonoBehaviour
{

    // The material that will have its color changed
    public Material material;

    // The minimum and maximum scale values for the object
    public float minScale = 0.5f;
    public float maxScale = 2.0f;

    // The colors to use for the material at the minimum and maximum scale values
    public Color minColor = Color.red;
    public Color maxColor = Color.green;

    void Update()
    {
        // Get the current scale of the object
        float scale = transform.localScale.x;

        // Clamp the scale value to the min and max values
        scale = Mathf.Clamp(scale, minScale, maxScale);

        // Calculate the percentage of the current scale relative to the min and max values
        float t = (scale - minScale) / (maxScale - minScale);

        // Interpolate the material color based on the percentage
        material.color = Color.Lerp(minColor, maxColor, t);
    }
}
