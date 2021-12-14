using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    [SerializeField] private GameCore GameScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameScene.AddPoint();
    }
}
