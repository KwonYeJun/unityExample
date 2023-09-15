using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // 이곳에 Background 컴포넌트의 동작과 속성을 정의합니다.
    private float moveSpeed = 3;
    // Update is called once per frame
    void Update()
    {
        // 이곳에 매 프레임마다 실행되는 코드를 작성합니다.
        transform.position += new Vector3.down * moveSpeed;
    }
}
