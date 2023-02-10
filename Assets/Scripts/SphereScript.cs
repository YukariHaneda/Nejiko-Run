using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    /*
    //4秒（第3引数分）間でゴール地点まで向かう等速運動
    transform.position = Vector3.MoveTowards(
        transform.position,
        target.position,
        4f*Time.deltaTime
        );
    */
        
    //ゴールに近づくほど減速する関数
        transform.position = Vector3.Lerp(
        transform.position,
        target.position,
        1f*Time.deltaTime
        );
        
    }
}
