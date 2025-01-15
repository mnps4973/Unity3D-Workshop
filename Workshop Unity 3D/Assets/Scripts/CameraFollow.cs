using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTransform;
    // Start is called before the first frame update
    void Start()
    {  
        transform.Rotate(60, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        //transform.position = new Vector3(FollowTransform.position.x - 30.0f, FollowTransform.position.y + 10.0f, FollowTransform.position.z);
        transform.position = FollowTransform.position + Vector3.back * 5.0f + Vector3.up * 20.0f;
    }
}
