using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball;
    public float xOffset, yOffset, zOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(ball.transform.position);
    }
}
