using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MissResult : MonoBehaviour {

    private int miss = 0;
    public int n;
    private int miss1 = 0;
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
        miss = GameManager.instance.miss;

        //Debug.Log(combo);
        miss1 = miss / n;

        gameObject.GetComponent<Image>().sprite = sprites[miss1 % 10]; //이미지 변경
    }
}
