using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gun) { 
        float p = gun.getPoints();
            if (p == 3) { 
        transform.Find("points").GetComponent<Text>().text = p.ToString() + "/3 You win!";
            }
            else
            {
                transform.Find("points").GetComponent<Text>().text = p.ToString() + "/3";
            }
        }

    }
}
