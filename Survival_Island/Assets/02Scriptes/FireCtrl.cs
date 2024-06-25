using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    [Header("���۳�Ʈ��")]
    public GameObject billetprefab;
    public Transform firePos;   //�߻� ��ġ
    public Animation fireAni;   //�߻�� �ִϸ��̼�
    public AudioSource source;
    public AudioClip clip;
    public ParticleSystem muzzleFlash;

    [Header("���� ������")]
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
        #region �ѹ߾� �߻��ϴ� ����
        //���콺 ���� ��ư�� ������ �� 0�� ���콺 ���� 1�� ������ 2�� �ٹ�ư.
        //if (Input.GetMouseButtonDown(0))
        //{
        //    fire();             //�Լ� ȣ��
        //}
        #endregion
        #region ����� �߻��ϴ� ����
        if (Hand_Ctrl.Isrun == false)
        {
            if (Input.GetMouseButton(0))
            {
                //���� �ð����� ���Žð��� ���� �귯�� �ð��� �ȴ�.
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
        Instantiate(billetprefab, firePos.position, firePos.rotation); //������Ʈ ����
        fireAni.Play("fire");
    }
}
