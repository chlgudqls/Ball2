using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 inputVec; // 입력 방향
    public float movePower; // 이동속도
    public float jumpPower; // 점프 파워
    public bool isGround; //바닥 닿기 유무

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
            //만족했을때 실행되는 로직
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            SendMessage("PlaySound", Sounder.Sfx.Jump);
        }
    }

    void FixedUpdate()
    {
        if(isGround)
        //force는 기본값임 지속적인값 생략가능 inpurse는 폭발적인 값
        rigid.AddForce(inputVec * movePower);
    }
    void OnCollisionStay(Collision collision)
    {
        //바닥에있으면 계속호출할거임
        isGround = true;
    }
    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
}
