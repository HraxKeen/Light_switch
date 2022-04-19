using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] GameObject redLight;
    

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("redLight").SetActive(false);
        //GameObject.FindGameObjectWithTag("greenLight").SetActive(false);
        //GameObject.FindGameObjectWithTag("blueLight").SetActive(false);
    }
    void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(redLight.activeInHierarchy == false)
            {
                redLight.SetActive(true);
            }   
            else
            {
                redLight.SetActive(false);
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
