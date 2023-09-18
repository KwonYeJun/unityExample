using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //public를 하게 되면 그냥 사용이 가능하다.
    [SerializeField]
    private float moveSpeed = 20;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }
}
