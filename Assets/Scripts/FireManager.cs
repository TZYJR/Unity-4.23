using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour {

    [SerializeField]
    Transform yan;
    [SerializeField]
    GameObject gameObject;


    private static FireManager instance;
    public static FireManager Instance { get { return instance; } }


    void Awake()
    {
        instance = this;
    }
    public void Fire()
    {
        GameObject gameobject_1 = Instantiate(gameObject, yan.position, yan.rotation);
		//gameobject_1.GetComponent<Rigidbody>().AddForce(yan.transform.forward * 1000);
		gameobject_1.GetComponent<Rigidbody>().velocity = gameobject_1.transform.forward * 50;
    }
}
