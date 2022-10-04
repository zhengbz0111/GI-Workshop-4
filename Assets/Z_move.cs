using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_move : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float thresholdDistance;

    private int _dir = 1; // Either 1 or -1 depending on the movement direction


    // Update is called once per frame
    private void Update()
    {
        transform.localPosition +=
            Vector3.forward * (Time.deltaTime * this.moveSpeed * this._dir);
        
        // Switch direction if past a particular threshold in the z-axis
        if (transform.localPosition.z > this.thresholdDistance)
            this._dir = -1;
        else if (transform.localPosition.z < 0.0f) 
            this._dir = 1;
        
        // Is there an easier way to do this if using "total" time instead?
        
    }
}
