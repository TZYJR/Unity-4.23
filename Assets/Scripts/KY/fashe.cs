using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fashe : MonoBehaviour {

    public GameObject zidan;
    public Transform qiangkou;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject shengcheng = Instantiate(zidan, qiangkou);
            shengcheng.transform.parent = null;
            shengcheng.GetComponent<Rigidbody>().AddForce(shengcheng.transform.forward*20000);
        }
		
	}
}
