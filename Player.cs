using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 inputVec; // �Է� ����
    public float movePower; // �̵��ӵ�
    public float jumpPower; // ���� �Ŀ�
    public bool isGround; //�ٴ� ��� ����

    Rigidbody rigid;
    FixedJoystick joy;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        joy = FindObjectOfType<FixedJoystick>();
    }

    void Update()
    {
        //inputVec.x = Input.GetAxis("Horizontal");
        //inputVec.z = Input.GetAxis("Vertical");
        //bool isJump = Input.GetButtonDown("Jump");
        inputVec.x = joy.Horizontal;
        inputVec.z = joy.Vertical;

    }
    public void Jump()
    {
        if (isGround)
        {
            //���������� ����Ǵ� ����
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            SendMessage("PlaySound", Sounder.Sfx.Jump);
        }
    }

    void FixedUpdate()
    {
        if(isGround)
        //force�� �⺻���� �������ΰ� �������� inpurse�� �������� ��
        rigid.AddForce(inputVec * movePower);
    }
    void OnCollisionStay(Collision collision)
    {
        //�ٴڿ������� ���ȣ���Ұ���
        isGround = true;
    }
    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
}
