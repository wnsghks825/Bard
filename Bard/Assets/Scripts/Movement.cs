﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody _Rigidbody = null;
    public float Speed;
    //Speed=-124.72f;
    // Use this for initialization
    void Start () {
        _Rigidbody = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void FixedUpdate () {
        //기준값=374.1525  노트가 생성된 지점과 판정선과의 거리
        //속력값 계산식   기준값/시간(노트 생성~입력 기준 시간) 
        //n=lat. l은 배속값, a는 속력값, t는 시간값, n은 기준값
        //시간이 8이라면 374.1525/8=46.77
        //3초로 할 것
        //
        _Rigidbody.velocity = transform.right * Speed*Time.deltaTime;
        //Debug.Log(_Rigidbody.velocity);
        //Debug.Log(_Rigidbody.velocity.x);
        //transform.Translate(Vector3.right );
    }

}
