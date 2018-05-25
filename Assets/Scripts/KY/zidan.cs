using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidan : MonoBehaviour
{

    public GameObject TeXiao;
    //public GameObject TX;
    // Use this for initialization
    void Start()
    {

        //Invoke("Del", 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision Col)
    {
        Boom();
    }
    /// <summary>
    /// 爆炸
    /// </summary>
    void Boom()
    {
        Instantiate(TeXiao, gameObject.transform.position, gameObject.transform.rotation);
        //GameObject.Instantiate(TeXiao, gameObject.transform);
        Del();
    }
    /// <summary>
    /// 删除
    /// </summary>
    void Del()
    {
        Destroy(gameObject);  //删除
    }
}
