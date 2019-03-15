using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{

    public float movingSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        int switchTime = Random.Range(1,3);
        GetComponent<Rigidbody2D>().velocity = Vector2.up * movingSpeed;
        InvokeRepeating("Switch", 0, switchTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Switch() {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
