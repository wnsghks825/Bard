using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCheck : MonoBehaviour
{
    public bool CanbePressed;
    public Camera SecondCamera;
    public Camera MainCamera;
    public static bool IsTouch { get; set; }
    public Vector3 TouchedPos { get; set; }
    public static float SwipeLength = 0.5f;
    public GameObject note;
    private Touch tempTouchs;

    // Use this for initialization
    void Start()
    {
        CanbePressed = true;

        IsTouch = false;
    }
    void Update()
    {
        Check();
        RaycastTrigger();
    }

    public void ApplyForce()
    {

        Debug.Log("Touch Occured");
    }
    /*
        void OnTriggerEnter(Collider collision)
        {
            distance = Vector3.Distance(gameObject.transform.position, collision.transform.position);
            //if (gameObject.transform.position.x < 0.2f && gameObject.transform.position.x>0.06f)

            if (collision.gameObject.tag == "Collider"&& gameObject.transform.position.y == -8.614f&&Input.GetKeyDown(KeyCode.J))
            {
                Debug.Log("OK");
                CanbePressed = true;
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(200);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Perfect");

            }


        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Collider" && gameObject.transform.position.y == -8.614f)
            {
                CanbePressed = false;
                GameManager.instance.MissCombo(0);
                GameManager.instance.Judge("Miss");
                Destroy(gameObject);
            }
        }
    */
    /*
                    //gameObject.SetActive(false);
                    //판정 콜라이더를 4개 만든다 Perfect, Good, 나머지는 Miss
                    //첫번째 안 : 노트와 충돌한 현재 충돌박스가 몇개?
                    //박스 종류: P=Perfect 콜라이더 / G=Good 콜라이더 / M=Miss 콜라이더
                    //Perfect: P=True & G=True & M=True
                    //Good: P=False & G=True & M=True
                    //Miss: P=False & G=False & M=True

                    //두 번째 안
                    //현재 노드가 있는 부분이 어디에 가까운지 비교하여 판정
            }
    */
    //판정 범위 구하기
    //Collider를 사용해야 하는데
    //Coroutine

    IEnumerator TouchEvent()
    {
        yield return new WaitForFixedUpdate();
        IsTouch = false;
    }

    void RaycastTrigger()
    {
        Rect bounds = new Rect(Screen.width / 2, 0, Screen.height, Screen.width);
        Rect bounds2 = new Rect(0, 0, Screen.height, Screen.width / 2);

        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                tempTouchs = Input.GetTouch(i);
                if (tempTouchs.phase == TouchPhase.Began && bounds.Contains(Input.GetTouch(i).position))
                {
                    if (gameObject.transform.position.x > -47.648f && gameObject.transform.position.x <= -46.936f && gameObject.transform.position.y == -9.175f)
                    {
                        GameManager.instance.AddScore(200);
                        GameManager.instance.AddCombo();
                        GameManager.instance.Judge("Perfect");
                        GameManager.instance.Perfect();
                        gameObject.SetActive(false);
                        //Destroy(gameObject);
                    }
                }
                if (tempTouchs.phase == TouchPhase.Began && bounds2.Contains(Input.GetTouch(i).position))
                {
                    if (gameObject.transform.position.x > -47.648f && gameObject.transform.position.x <= -46.936f && gameObject.transform.position.y == -8.614f)
                    {
                        GameManager.instance.AddScore(200);
                        GameManager.instance.AddCombo();
                        GameManager.instance.Judge("Perfect");
                        GameManager.instance.Perfect();
                        gameObject.SetActive(false);
                        //Destroy(gameObject);
                    }
                }
            }
        }
            /*
            Ray ray = SecondCamera.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))    // 레이저를 끝까지 쏴보자. 충돌 한넘이 있으면 return true다.
            {

                if (hit.collider.name == "DefaultNode 1(Clone)")
                {
                    GameManager.instance.AddScore(200);
                    GameManager.instance.AddCombo();
                    GameManager.instance.Judge("Perfect");
                    GameManager.instance.Perfect();
                    Destroy(hit.collider.gameObject);
                    Debug.Log(hit.collider.name);
                }
            }
            */
        }

    void Check()
    {

        if (Input.GetKey(KeyCode.F))
        {

            CanbePressed = false;
/*
            if (gameObject.transform.position.x > -47.4f && gameObject.transform.position.x <= -47.1f && gameObject.transform.position.y == -8.614f)
            {
                //Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(200);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Perfect");
                GameManager.instance.Perfect();

            }
*/
/*
            if (gameObject.transform.position.x > -47.65f && gameObject.transform.position.x <= -47.4f && gameObject.transform.position.y == -8.614f)
            {
                //Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(140);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Good");
                GameManager.instance.Good();
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }


            if (gameObject.transform.position.x > -47.1f && gameObject.transform.position.x <= -46.95f && gameObject.transform.position.y == -8.614f)
            {
                //Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(140);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Good");
                GameManager.instance.Good();
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
 */

   
        }
        CanbePressed = true;
        if (Input.GetKeyUp(KeyCode.F)&&CanbePressed==true&& 
            gameObject.transform.position.x > -47.45f && gameObject.transform.position.x <= -47.05f && gameObject.transform.position.y == -8.614f)
        {
            GameManager.instance.AddScore(200);
            GameManager.instance.AddCombo();
            GameManager.instance.Judge("Perfect");
            GameManager.instance.Perfect();
            CanbePressed = false;
            Destroy(gameObject);

        }

        if (Input.GetKeyUp(KeyCode.F) && CanbePressed == true &&
            gameObject.transform.position.x > -47.65f && gameObject.transform.position.x <= -47.45f && gameObject.transform.position.y == -8.614f)
        {
            GameManager.instance.AddScore(140);
            GameManager.instance.AddCombo();
            GameManager.instance.Judge("Good");
            GameManager.instance.Good();
            CanbePressed = false;
            Destroy(gameObject);
        }

        if (Input.GetKeyUp(KeyCode.F) && CanbePressed == true &&
            gameObject.transform.position.x > -47.05f && gameObject.transform.position.x <= -46.85f && gameObject.transform.position.y == -8.614f)
        {
            GameManager.instance.AddScore(140);
            GameManager.instance.AddCombo();
            GameManager.instance.Judge("Good");
            GameManager.instance.Good();
            CanbePressed = false;
            Destroy(gameObject);
        }

        if (gameObject.transform.position.x < -48.0f)
        {
            GameManager.instance.MissCombo(0);
            GameManager.instance.Judge("Miss");
            GameManager.instance.Miss();
            CanbePressed = false;
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }

        if (Input.GetKey(KeyCode.J))
        {

            if (gameObject.transform.position.x > -47.355f && gameObject.transform.position.x <= -47.184f && gameObject.transform.position.y == -9.175f)
            {
                //Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(200);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Perfect");
                GameManager.instance.Perfect();
                //gameObject.SetActive(false);
                Destroy(gameObject);

            }
            /*
            if (gameObject.transform.position.x > -47.55f && gameObject.transform.position.x < -47.355f && gameObject.transform.position.y == -9.175f)
            {
                //Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(140);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Good");
                GameManager.instance.Good();
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
            if (gameObject.transform.position.x > -47.184f && gameObject.transform.position.x < -46.981f && gameObject.transform.position.y == -9.175f)
            {
                //Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(140);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Good");
                GameManager.instance.Good();
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
            */
        }
    }
}