using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCTR : MonoBehaviour
{
    public float speed = 1500f;
    public Rigidbody rb;
    void Start()
    {
                    //Vector3.forward�� �۷ι� ��ǥ��.
        rb.AddForce(transform.forward * speed);  //���� ��ǥ�� ���ǵ常ŭ ������
        Destroy(this.gameObject, 3.0f);
    }
}
