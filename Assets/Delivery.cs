using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(255, 125, 255, 255);
    [SerializeField] Color32 defaultColor = new Color32(255, 255, 255, 255);
    [SerializeField] float delayTime = 0.3f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = defaultColor;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, delayTime);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = defaultColor;
        }
    }
}
