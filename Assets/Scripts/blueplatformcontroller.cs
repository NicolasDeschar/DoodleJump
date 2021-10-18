using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueplatformcontroller : MonoBehaviour
{
    public bool moveleft = true;
    public float speed = 1.0f;
    public float pos = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(pos, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveleft)
        {
            pos -= speed;
        }
        else
        {
            pos += speed;
        }
        transform.position = new Vector3(pos, transform.position.y, transform.position.z);

        if (pos > 6.0f)
        {
            moveleft = true;
        }
        if (pos < -3)
        {
            moveleft = false;
        }

    }
}
