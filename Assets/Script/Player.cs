using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameCore m_gameCore;

    //variables
    [SerializeField] private float m_thrust;
    [SerializeField] private float m_maxSpeedY;
    [SerializeField] private float m_minSpeedY;
    [SerializeField] private float m_angle = 0f;





    void Update()
    {
        Rigidbody2D f_rigid = GetComponent<Rigidbody2D>();


        if (Input.GetKeyDown(KeyCode.Space))
        {
            f_rigid.AddForce(Vector2.up * m_thrust, ForceMode2D.Impulse);
            m_angle += 40;
            if (m_angle > 40) m_angle = 40;
            
            
        }
        if(!m_gameCore.m_isPause)m_angle -= 0.10f;
        if (m_angle < -40) m_angle = -40;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, m_angle);



        if (f_rigid.velocity.y > m_maxSpeedY)  f_rigid.velocity = new Vector2(0f, m_maxSpeedY);

        if (f_rigid.velocity.y < m_minSpeedY) f_rigid.velocity = new Vector2(0f, m_minSpeedY);
    }

}
