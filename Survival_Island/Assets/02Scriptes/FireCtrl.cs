using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    [Header("컴퍼넌트들")]
    public GameObject billetprefab;
    public Transform firePos;   //발사 위치
    public Animation fireAni;   //발사시 애니메이션
    public AudioSource source;
    public AudioClip clip;
    public ParticleSystem muzzleFlash;

    [Header("각종 변수들")]
    public float fireTime;
    public Hand_Ctrl Hand_Ctrl;
    void Start()
    {
        fireTime = Time.time;
        Hand_Ctrl = this.gameObject.GetComponent<Hand_Ctrl>();
        muzzleFlash.Stop();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            muzzleFlash.Stop();
        }
        #region 한발씩 발사하는 로직
        //마우스 왼쪽 버튼이 눌렸을 때 0은 마우스 왼쪽 1은 오른쪽 2는 휠버튼.
        //if (Input.GetMouseButtonDown(0))
        //{
        //    fire();             //함수 호출
        //}
        #endregion
        #region 연사로 발사하는 로직
        if (Hand_Ctrl.Isrun == false)
        {
            if (Input.GetMouseButton(0))
            {
                //현재 시간에서 과거시간을 뺴면 흘러간 시간이 된다.
                if (Time.time - fireTime > 0.5f)
                {
                    fire();
                    fireTime = Time.time;
                    muzzleFlash.Play();
                }
            }
        }
        #endregion
    }
    void fire()
    {
        source.PlayOneShot(clip, 1f);
        Instantiate(billetprefab, firePos.position, firePos.rotation); //오브젝트 생성
        fireAni.Play("fire");
    }
}
