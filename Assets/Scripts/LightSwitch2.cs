using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch2 : MonoBehaviour
{

    [SerializeField] GameObject blueLight;
    

    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("redLight").SetActive(false);
        //GameObject.FindGameObjectWithTag("greenLight").SetActive(false);
        GameObject.FindGameObjectWithTag("blueLight").SetActive(false);
    }
    void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(blueLight.activeInHierarchy == false)
            {
                blueLight.SetActive(true);
            }             
            else
            {
                blueLight.SetActive(false);
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
