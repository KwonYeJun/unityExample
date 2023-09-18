using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   

 //public를 하게 되면 그냥 사용이 가능하다.
    [SerializeField]
    private float moveSpeed = 5f;
    // Update is called once per frame
    private float minY = -7f;
    void Update()
    {
     
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if(transform.position.y < minY){
            Destroy(gameObject);
        }
    }
 // Start is called before the first frame update
    void Start()
    {
      
        
    }
}
