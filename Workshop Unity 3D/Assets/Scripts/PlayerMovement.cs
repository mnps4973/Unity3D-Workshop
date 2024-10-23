using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody _rb;
    private float speed = 8.0f;
    Vector3 m_Movement;

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

        m_Movement.Set(horizontalValue, 0f, verticalValue);
        if (horizontalValue != 0 && verticalValue != 0) {
            m_Movement.Normalize();
		}

        Vector3 deltaMovement = m_Movement * speed * Time.deltaTime;
        _rb.MovePosition(transform.position + deltaMovement);
    }
}
