using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 50;

    //�������̓��͏��
    private float horizontalInput;
    //�c�����̓��͏��
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Vector3�̑O�����Ɉړ�������
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Vector3�̉������Ɉړ�
        //�E�����~���ԁ~�����~����(-1~1)
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
