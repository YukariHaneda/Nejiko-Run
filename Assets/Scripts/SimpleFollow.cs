using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
        Vector3 diff;

        public GameObject target;
        public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        diff = target.transform.position - transform.position; //メインカメラからねじこへのベクトル
    }

    // Update is called once per frame
    void LateUpdate()//Updateが終わったあとに動くのがLateUpdate関数
    {
        transform.position = Vector3.Lerp (
            transform.position,
            target.transform.position -diff,
            Time.deltaTime * followSpeed //ねじこが動いてちょっと後に動く。このちょいずれがいらなければねじこの子要素にメインカメラを持ってくる。
        );
    }
}
