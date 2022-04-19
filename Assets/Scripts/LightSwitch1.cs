using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch1 : MonoBehaviour
{

    [SerializeField] GameObject greenLight;

    

    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("redLight").SetActive(false);
        GameObject.FindGameObjectWithTag("greenLight").SetActive(false);
        //GameObject.FindGameObjectWithTag("blueLight").SetActive(false);
    }
    void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(greenLight.activeInHierarchy == false)
            {
                greenLight.SetActive(true);
            }       
            else
            {
                greenLight.SetActive(false);
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
