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
        canvasGroup.alpha = 0;
        FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIn()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.interactable = false;
            canvasGroup.alpha += Time.deltaTime / 3;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;
    }
}
