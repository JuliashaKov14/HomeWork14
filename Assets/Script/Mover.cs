using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

	
    public float speed;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed, ForceMode2D.Force);

    }
}
