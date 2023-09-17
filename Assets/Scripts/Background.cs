using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // 이곳에 Background 컴포넌트의 동작과 속성을 정의합니다.
    private float moveSpeed = 0.5f;
     // 'f' 접미사를 사용하여 float 형식임을 나타내주어야 실수로 사용이 가능하다.
    private int check = 0;
    // Update is called once per frame
    void Update()
    {
        // 게임이 실행 되는 동안 자동으로 호출이 되는 메서드 이다.
        // 이곳에 매 프레임마다 실행되는 코드를 작성합니다.
        transform.position += Vector3.down * moveSpeed;
        if (transform.position.y < -17)
        {
            transform.position += new Vector3(0, 34f);
            check++;
        }

        if (check >= 20)
        {
            moveSpeed += 0.1f;
             check = 0; 
        }

    }
}
