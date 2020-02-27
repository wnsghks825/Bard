using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GoodResult : MonoBehaviour {

    private int good = 0;
    public int n;
    private int good1 = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites = new Sprite[10];

    // Use this for initialization
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        good = GameManager.instance.good;

        //Debug.Log(combo);
        good1 = good / n;

        gameObject.GetComponent<Image>().sprite = sprites[good1 % 10]; //이미지 변경
    }
}
