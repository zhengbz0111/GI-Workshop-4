using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        float dx = 0.0f, dz = 0.0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow");
            dx += 1.0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("LeftArrow");
            dx -= 1.0f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow");
            dz += 1.0f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow");
            dz -= 1.0f;
        }

        transform.localPosition +=
            new Vector3(dx, 0.0f, dz) * (this.speed * Time.deltaTime);
    }
        
    }

