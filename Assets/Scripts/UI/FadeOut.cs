using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    CanvasGroup canvasGroup;


    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        Fade();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFading) FadeInUpdate();
    }

    private bool isFading = false;
    public void Fade()
    {
        //StartCoroutine(DoFade());
        canvasGroup.alpha = 1;
        isFading = true;
        canvasGroup.interactable = true;
    }

    // good fade
    private void FadeInUpdate()
    {
        canvasGroup.alpha -= Time.deltaTime / 3; // takes 3 second

        if (canvasGroup.alpha <= 0)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            isFading = false;
        }
    }
}
