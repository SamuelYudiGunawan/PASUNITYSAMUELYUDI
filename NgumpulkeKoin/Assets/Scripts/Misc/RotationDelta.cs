using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDelta : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Vector3 rotationDelta = new Vector3(15f, 30f, 45f);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationDelta, Space.World);   
    }
}
