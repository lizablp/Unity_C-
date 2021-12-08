using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 270)
        {
            transform.position += new Vector3(0, 0, 0.03f);
        }
        else if (transform.position.z < 300)
        {
            transform.Rotate(0, -0.03f, 0, Space.World);
            transform.position += new Vector3(-0.03f, 0, 0.03f);
        }
        else transform.position += new Vector3(-0.03f, 0, 0.03f);
    }
}
