using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuControl : MonoBehaviour {

    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        StartBlinking();
    }


    IEnumerator Blink()
    {
        while (true)
        {
            switch (image.color.a.ToString())
            {
                case "0.5":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
                    //Play sound
                    yield return new WaitForSeconds(0.6f);
                    break;
                case "1":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 0.5f);
                    //Play sound
                    yield return new WaitForSeconds(0.6f);
                    break;
            }
        }
    }

    void StartBlinking()
    {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopAllCoroutines();
    }

}
