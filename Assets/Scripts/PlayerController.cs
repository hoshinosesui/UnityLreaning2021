using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 50;

    //横方向の入力情報
    private float horizontalInput;
    //縦方向の入力情報
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

        //Vector3の前方向に移動させる
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Vector3の横方向に移動
        //右方向×時間×速さ×入力(-1~1)
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
