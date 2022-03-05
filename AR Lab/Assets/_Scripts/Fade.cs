using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image logo;
    public Button[] buttons;
    [SerializeField]
    GameObject splash, mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        if(!BackManager.instance.back)
        StartCoroutine(Steps());
        else { 

        for (int i = 0; i < buttons.Length; i++)
                buttons[i].image.color = new Color(1, 1, 1, 1);

            splash.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

    IEnumerator FadeOut()
    {
        while (logo.color.a > 0)
        {
            logo.color = new Color(1, 1, 1, logo.color.a - (Time.deltaTime / 3.0f));
            yield return null;
        }
    }
    IEnumerator FadeIn()
    {
        while (logo.color.a < 1)
        {
            logo.color = new Color(1, 1, 1, logo.color.a + (Time.deltaTime / 3.0f));
            yield return null;
        }
    }
    IEnumerator FadeInButtons()
    {
        while (buttons[0].image.color.a < 1)
        {
            for(int i =0;i<buttons.Length;i++)
                buttons[i].image.color = new Color(1, 1, 1, buttons[i].image.color.a + (Time.deltaTime / 3.0f));
            yield return null;
        }
    }
    IEnumerator Steps()
    {
        yield return StartCoroutine(FadeIn());
        //yield return StartCoroutine(FadeOut());
        splash.SetActive(false);
        mainMenu.SetActive(true);
        yield return StartCoroutine(FadeInButtons());
    }
}
