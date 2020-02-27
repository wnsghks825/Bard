using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class SelectClick : MonoBehaviour, IPointerClickHandler {

    public Sprite[] m_Sprite = new Sprite[4];
    public Image[] m_Image=new Image[2];
    public static SelectClick Selectinstance;
    public static bool normal;
    public static bool  hard;
    /*
        void OnGUI()
        {
            if (Event.current.Equals(Event.KeyboardEvent(KeyCode.S.ToString())))
            {
                Debug.Log("Space key is pressed.");
            }
        }
    */
    private Touch tempTouchs;
    private Vector3 touchedPos;
    public Button button;
    public Button button1;
    private bool touchOn;
    void Start()
    {
        //Fetch the Image from the GameObject
        //m_Image = GetComponent<Image[]>();
        normal = true;
        hard = false;
    }

    public void NormalCheck()
    {
        m_Image[0].sprite = m_Sprite[1];
        m_Image[1].sprite = m_Sprite[2];
        hard = false;
        normal = true;
    }

    public void HardCheck()
    {
        m_Image[0].sprite = m_Sprite[0];
        m_Image[1].sprite = m_Sprite[3];
        normal = false;
        hard = true;
    }
    void Update()
    {
        /*
        touchOn = false;

        if (Input.touchCount > 0)
        {    //터치가 1개 이상이면.
            for (int i = 0; i < Input.touchCount; i++)
            {
                tempTouchs = Input.GetTouch(i);
                if (tempTouchs.phase == TouchPhase.Began && normal == true)
                {    //해당 터치가 시작됐다면.

                    touchOn = true;
                    SceneManager.LoadScene("Demo_Scene_Normal");

                    //break;   //한 프레임(update)에는 하나만.
                }
                if (tempTouchs.phase == TouchPhase.Began && hard == true)
                {
                    touchOn = true;
                    SceneManager.LoadScene("Demo_Scene_Hard");

                }
            }

        }

        */
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (name == "Button")
        {
            SceneManager.LoadScene("Demo_Scene_Normal");
        }
        if (name == "Button (1)")
        {
            SceneManager.LoadScene("Demo_Scene_Hard");
        }
    }
}
