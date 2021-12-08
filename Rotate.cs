using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 0, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.02f*rotateSpeed, 0, Space.World);
    }
}
