using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody _rb;
    private float _speed = 8.0f;
    private Vector3 m_Movement;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontalValue = Input.GetAxisRaw("Horizontal");
        float verticalValue = Input.GetAxisRaw("Vertical");
        //Quaternion m_Rotation = Quaternion.identity;

        m_Movement.Set(horizontalValue, 0f, verticalValue);

        if (horizontalValue != 0 || verticalValue != 0) {
            m_Movement.Normalize();

            // float x = 0, y = 0, z = 0;
            
            // if (horizontalValue != 0) z = horizontalValue*5;
            // if (verticalValue != 0) x = verticalValue*5;
            //transform.Rotate(x, y, z);

            Vector3 deltaMovement = m_Movement * _speed * Time.deltaTime;
            _rb.MovePosition(transform.position + deltaMovement);

            //Vector3 desiredForward = Vector3.RotateTowards(transform.forward, deltaMovement, _speed * Time.deltaTime, 0f);
            //m_Rotation = Quaternion.LookRotation(desiredForward);
            //_rb.MoveRotation(m_Rotation);
		}

        
    }
}
