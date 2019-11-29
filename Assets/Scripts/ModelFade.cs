using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        SetModelAlpha(0);
        isFading = true;
    }

    // good fade
    private void FadeInUpdate()
    {
        SetModelAlpha( GetModelAlpha() + Time.deltaTime / 3 ); // takes 3 second

        if (GetModelAlpha() >= 1)
        {
            SetModelAlpha(1f);
            isFading = false;
        }
    }

    private void SetModelAlpha(float a)
    {

    }

    private float GetModelAlpha()
    {
        return 0;
    }
}
