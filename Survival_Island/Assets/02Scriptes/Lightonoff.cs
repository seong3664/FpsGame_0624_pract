using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_sensour : MonoBehaviour
{
    public Light StairLight;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {
        
    }
    //is trrgger ���� �� ��� �ϸ鼭 �浹 ���� �ϴ� �Լ�
    //�ݹ� �Լ���� �� ������ ȣ�� �ϱ� ����
    private void OnTriggerEnter(Collider other)     //�ݶ��̴��� �浹 ���ñ���ü
    {
        if(other.gameObject.tag == "Player")
        {
            source.PlayOneShot(clip,1.0f);
            StairLight.enabled = true;
            //�浹ü�� �±׸� ������ �� ������ ����Ʈ ��
        }
    }
    //�ݶ��̴� ������ ���Դٰ� ���������� ��
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            source.PlayOneShot(clip, 1.0f);
            StairLight.enabled = false;
        }
    }
    void Update()
    {
        
    }
}
