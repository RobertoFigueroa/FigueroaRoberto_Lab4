using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseOver()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo))
        {
            hitInfo.rigidbody.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

    }

    public void OnMouseExit()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo) && hitInfo.collider.gameObject.CompareTag("block"))
        {
            hitInfo.rigidbody.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
    }
}
