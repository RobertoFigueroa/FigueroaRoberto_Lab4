using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        
        transform.Rotate(0,2, 0);
        transform.position += new Vector3(Mathf.Sin(Time.fixedTime * Mathf.PI * 0.5f) * 0.3f, 0, 0);
    }
}
