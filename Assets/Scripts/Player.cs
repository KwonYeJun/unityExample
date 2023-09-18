using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Unity에서 사용되는 어트리뷰트(Attribute)중 하나이다.
    // 인스펙터에 노출시켜 직접 설정을 해줄수 있게 할 수 있다.
    [SerializeField]
    private float moveToSpeed;
    [SerializeField]

    private float TestFloat;

    // Update is called once per frame
    void Update()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal"); // 가로 방향
        // float verticalInput = Input.GetAxisRaw("Vertical"); // 세로 방향
        // Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);
        // transform.position += moveTo * moveToSpeed * Time.deltaTime;
        // Debug.Log(Input.mousePosition);
        // Vector3 moveTo = new Vector3(moveToSpeed * Time.deltaTime, 0, 0);
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.position -= moveTo;
        // }
        // else if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.position += moveTo;
        // }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        // Debug.Log(mousePos);
        // value값이 최솟값, 최대값 보다 크거나 작으면 최대 , 최솟값으로 하고 사이의 값이면 그대로 사용한다.
        // float toY = Mathf.Clamp(mousePos.x, -4.44f, 4.45f);
        float toX = Mathf.Clamp(mousePos.y, -2.35f, 2.35f);

        //마우스로 캐릭터 이동이 가능하게 작성
        transform.position = new Vector3(toX,transform.position.y, transform.position.z);



    }
}
