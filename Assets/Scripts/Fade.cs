using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    CanvasGroup canvasGroup;


    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        FadeIn();        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFading) FadeInUpdate();
    }

    private bool isFading = false;
    public void FadeIn()
    {
        //StartCoroutine(DoFade());
        canvasGroup.alpha = 0;
        isFading = true;
        canvasGroup.interactable = false;
    }

    // good fade
    private void FadeInUpdate()
    {
        canvasGroup.alpha += Time.deltaTime / 3; // takes 3 second
        
        if (canvasGroup.alpha >= 1)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            isFading = false;
        }
    }
}
