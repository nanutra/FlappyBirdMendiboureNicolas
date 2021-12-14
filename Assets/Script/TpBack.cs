using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpBack : MonoBehaviour
{
    public float c_initTPValue_X;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Pipe>() != null)
        {

            //get the object
            Pipe f_pipe = collision.GetComponent<Pipe>();
            //if collision, tp back with random nmb on y
            if(f_pipe.moveY == true) f_pipe.transform.position = new Vector3(c_initTPValue_X, Random.Range(-12f, -5.7f), 0f);
            //is ground don't tp random position on y
            else f_pipe.transform.position = new Vector3(c_initTPValue_X, f_pipe.transform.position.y, 0f);
        }
    }

}
