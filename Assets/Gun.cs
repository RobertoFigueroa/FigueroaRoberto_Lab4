using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float gunRange = 100f;
    public Renderer block;
    public Camera fpscam;
    private float points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    public void Shoot()
    {
        
        if(Physics.Raycast(fpscam.transform.position,fpscam.transform.forward,out RaycastHit hitInfo, gunRange))
        {

            
            if (hitInfo.collider.gameObject.CompareTag("target"))
            {
                Destroy(hitInfo.collider.gameObject);
                points += 1;

                }
                
            }
        }

  

 

    public float getPoints()
    {
        return points;
    }

    }
        
