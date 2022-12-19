using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    private Renderer rend;
    // The minimum and maximum scale values for the object
    private float minScale = 0.5F;
    private float maxScale = 1.5F;

    // The colors to use for the material at the minimum and maximum scale values
    private Color minColor = Color.white;
    private Color maxColor = Color.grey;


    private Vector2 range = new Vector2(0, 1);
   
    private float speed = 0.5f;
    private Vector3 direction = Vector3.right;
    private Vector3 startPosition;

    private bool handInteraction = false;
    private Color whiteCloud = new Color(255, 255, 255, 255);
    private Color greyCloud = new Color(50, 50, 50, 50);
    
    private float duration = 1f;


    void Start()
    {
        startPosition = transform.position;
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        //if (!handInteraction)
        //{
        //    Vector3 newPosition = startPosition + direction * Mathf.PingPong(Time.time * speed, range.y - range.x) + range.x * direction;
        //    transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
        //}
        //else
        //{
            float scale = transform.localScale.x;
            scale = Mathf.Clamp(scale, minScale, maxScale);
            float t = (scale - minScale) / (maxScale - minScale);
            rend.material.color = Color.Lerp(minColor, maxColor, t);
        //}
    }

    public void InteractBoolTrue()
    {
        handInteraction = true;
    }

    public void InteractBoolFalse()
    {
        handInteraction = false;
    }

}
