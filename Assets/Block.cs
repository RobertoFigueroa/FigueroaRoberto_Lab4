using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public MeshRenderer color;
    public float force = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo))
        {
       
            hitInfo.rigidbody.AddForce(-hitInfo.normal*force, ForceMode.Impulse);
            hitInfo.rigidbody.GetComponent<MeshRenderer>().material.color = Color.gray;

        }
        
    }

    public void OnMouseEnter()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo) && hitInfo.collider.gameObject.CompareTag("block"))
        {
            
            hitInfo.rigidbody.GetComponent<MeshRenderer>().material.color = Color.blue;
            hitInfo.rigidbody.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
   
}
