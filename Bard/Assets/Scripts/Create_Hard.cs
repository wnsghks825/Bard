using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Create_Hard : MonoBehaviour {

    public GameObject notePrefab;
    GameObject obj1;
    //public GameObject Cube;
    public Transform[] points;
    public List<GameObject> notePool;
    public List<GameObject> notePool1;
    public TextAsset textAsset;
    bool isGameOver = false;

    public List<string> noteData;
    public List<string> time;
    public List<string> type;
    public static List<GameObject> noteObject;
    public static List<bool> noteCreate;
    float distance;
    public static float noteTime;
    Movement movement;
    SongInfo songtype = new SongInfo();
    Vector3 position;

    // Use this for initialization
    void Start()
    {
        movement = GetComponent<Movement>();
        notePool = new List<GameObject>();
        //points[0].transform.position = new Vector3(7.6f, -1.8f, -0.5f);
        points[0].transform.position = new Vector3(-39.9f, -8.614f, 39.769f);
        //points[1].transform.position = new Vector3(7.6f, -2.25f, -0.5f);
        points[1].transform.position = new Vector3(-39.9f, -9.175f, 39.769f);

        noteData = new List<string>();
        noteCreate = new List<bool>();

        //타이밍값만 가지고 있는 노트/0초 노트? 어떠한 패턴 파일이든 동일하게 노트가 움직이는 시간을 같게?
        //인게임 씬 하나. 패턴마다 Music의 딜레이값을 바꾼다면 계속해서 바꿔야 한다.
        //
        TextAsset textAsset = (TextAsset)Resources.Load("Indifferent_hard");

        StringReader sr = new StringReader(textAsset.text);

        // 먼저 한줄을 읽는다. 

        string source = sr.ReadLine();

        songtype.Type = source.Split(' ');                // 쉼표로 구분된 데이터들을 저장할 배열 (values[0]이면 첫번째 데이터 )


        while (source != null)
        {
            songtype.Time = source.Split(' ');
            time.Add(songtype.Time[0]);
            noteData.Add(source);

            songtype.Type = source.Split(' ');  // ' '로 구분한다. 저장시에 쉼표로 구분하여 저장하였다.
            source = sr.ReadLine();    // 한줄 읽는다.

            if (songtype.Type.Length == 0)

            {

                sr.Close();

                return;

            }
            noteCreate.Add(true);
        }

        for (int i = 0; i < noteData.Count; i++)
        {
            GameObject monster = (GameObject)Instantiate(notePrefab);
            monster.SetActive(false);
            notePool.Add(monster);

        }

        StartCoroutine(LoadNote());
    }

    //private void Update()
    //{


    //    for (int i = 0; i < noteData.Count; i++)
    //    {

    //        if (noteData.Count <= i)
    //        {
    //            break;
    //        }
    //        if (noteTime >= float.Parse(time[i]) / 1000
    //               && noteTime <= float.Parse(time[i])
    //               && noteCreate[i] == true)
    //        {
    //            //GameObject obj = (GameObject)Instantiate(notePrefab);

    //            //obj.transform.parent = GameObject.Find("DefaultNode 1(Clone)").transform;
    //            //obj.transform.localScale = new Vector3(0, 0, 0);
    //            //notePool1[i].transform.position = NotePos(noteData[i][12].ToString());
    //            //notePool1[i].SetActive(true);

    //            //if (i > 22)
    //            //{
    //            //    notePool1[i].transform.position = NotePos(noteData[i][13].ToString());
    //            //}
    //            //if (i > 409)
    //            //{
    //            //    notePool1[i].transform.position = NotePos(noteData[i][14].ToString());
    //            //}
    //            //notePool.Add(notePool1[i]);
    //            noteCreate[i] = false;
    //            //DontDestroyOnLoad(notePool[i]);

    //            //Debug.Log("CreateNote");
    //            //Debug.Log(noteDatas[i].name);
    //        }

    //    }
    //    noteTime += Time.deltaTime;

    //}


    IEnumerator LoadNote()
    {
        while (noteData.Count >= 1)
        {

            noteTime += Time.deltaTime;
            for (int i = 0; i < noteData.Count; i++)
            {

                if (noteData.Count <= i)
                {
                    break;
                }
                Debug.Log(noteTime);
                if (noteTime >= float.Parse(time[i]) / 1000
                       //&& noteTime <= noteDatas[i].time + 0.1f
                       && noteCreate[i] == true)
                {
                    GameObject obj = (GameObject)Instantiate(notePrefab);

                    //obj.transform.parent = GameObject.Find("DefaultNode 1(Clone)").transform;
                    //obj.transform.localScale = new Vector3(0, 0, 0);
                    obj.transform.position = NotePos(noteData[i][12].ToString());
                    obj.SetActive(true);
                    if (i > 22)
                    {
                        obj.transform.position = NotePos(noteData[i][13].ToString());
                    }
                    if (i > 409)
                    {
                        obj.transform.position = NotePos(noteData[i][14].ToString());
                    }
                    notePool.Add(obj);
                    noteCreate[i] = false;
                    DontDestroyOnLoad(notePool[i]);

                    //Debug.Log("CreateNote");
                    //Debug.Log(noteDatas[i].name);
                }

            }
            yield return null;
        }

    }
    /*
    private void FixedUpdate()
    {
        noteTime += Time.deltaTime;
        for (int i = 0; i < noteData.Count; i++)
        {
            if (noteData.Count <= i)
            {
                break;
            }

            if (noteTime <= (float.Parse(time[i]) / 1000)
                   && noteCreate[i] == true)
            {
                notePool[i].transform.position = NotePos(noteData[i][12].ToString());
                notePool[i].SetActive(true);
                if (i > 22)
                {
                    notePool[i].transform.position = NotePos(noteData[i][13].ToString());
                }
                if (i > 409)
                {
                    notePool[i].transform.position = NotePos(noteData[i][14].ToString());
                }

            }

        }
        //7번째에서 193
        //194부터 257까지
    }
    */
    Vector3 NotePos(string name)
    {
        switch (name)
        {

            case "U":
                position = points[0].transform.position;
                break;

            case "D":
                position = points[1].transform.position;
                break;

        }
        //Debug.Log(name);
        return position;
    }

}
