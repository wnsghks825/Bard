using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PerfectResult : MonoBehaviour {

    private int perfect = 0;
    public int n;
    private int perfect1 = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites = new Sprite[10];

    // Use this for initialization
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update () {
        perfect = GameManager.instance.perfect;

        //Debug.Log(combo);
        perfect1 = perfect / n;

        gameObject.GetComponent<Image>().sprite = sprites[perfect1 % 10]; //이미지 변경
    }
}
