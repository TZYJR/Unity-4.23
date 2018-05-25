using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameras : MonoBehaviour {


    public Transform targetTransform;
    public float Distance = 5f;
    public float Height = 7f;

    private Vector3 offset;

    private void Awake()
    {
        this.transform.position = targetTransform.position - targetTransform.forward * Distance + targetTransform.up * Height;
        offset = this.transform.position - targetTransform.position;
    }


    private void LateUpdate()
    {
        Follow();
    }

    void Follow()
    {
        //this.transform.position = targetTransform.position - targetTransform.forward * Distance + targetTransform.up * Height;
        this.transform.LookAt(targetTransform);
        this.transform.position = offset + targetTransform.position;
    }
}
