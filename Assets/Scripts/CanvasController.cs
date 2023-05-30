using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI tmp;

    private float currentAlpha = 1f;
    private bool s = false;

    private void Start()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
        tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, currentAlpha);
        Invoke("S", 2f);
    }

    private void S() => s = true;

    private void FixedUpdate()
    {
        if (!s)
            return;
        currentAlpha -= 0.025f;
        image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
        tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, currentAlpha);
        if (currentAlpha <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
