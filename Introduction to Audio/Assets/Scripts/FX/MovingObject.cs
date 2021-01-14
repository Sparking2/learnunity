using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public int speed = 0;
    public float maxTimer = 10.0f;
    private float currentTimer = 0.0f;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        currentTimer += Time.deltaTime;
        if (currentTimer >= maxTimer)
        {
            currentTimer = 0.0f;
            transform.position = startingPosition;
        }
    }
}
