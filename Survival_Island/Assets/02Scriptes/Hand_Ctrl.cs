using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Hand_Ctrl : MonoBehaviour
{
    public Animation ComBatSGAni;
    public Light flashLight;
    public AudioClip flashsound;   //�Ҹ�����
    public AudioSource A_sourse;   //����� �ҽ�
    public bool Isrun = false;
    void Start()    //���� ���� �� ȣ��
    {
        
    }

    void Update()    //���� ���� �� ��� ȣ��
    {
        GunCrtl();
        flashlightonoff();
    }

    private void flashlightonoff()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            A_sourse.PlayOneShot(flashsound, 1.0f);
            //�Ҹ� ����    �Ҹ� ����
            flashLight.enabled = !flashLight.enabled;
        }
    }

    private void GunCrtl()
    {
       
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {

                ComBatSGAni.Play("running");
            Isrun = true;
        }
        
        else if (Input.GetKeyUp(KeyCode.LeftShift))    //���� ����Ʈ Ű�� ����ٸ�
        {
            ComBatSGAni.Play("runStop");
            Isrun = false;
        }
    }
}

