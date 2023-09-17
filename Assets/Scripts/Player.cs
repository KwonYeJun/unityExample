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
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);
        transform.position += moveTo * moveToSpeed * Time.deltaTime;
    }
}
