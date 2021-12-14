using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameCore gameScene;
    public bool moveY = true;
    
    private void Update()
    {
        if(gameScene.m_isPause == false)
        {
            transform.position -= new Vector3(0.012f, 0f, 0f);
        }
        else transform.position -= new Vector3(0f, 0f, 0f);

    }
    void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)
        {
            gameScene.GameOver();
            p_collision.GetComponent<Player>().gameObject.SetActive(false);

        }
    }
}
