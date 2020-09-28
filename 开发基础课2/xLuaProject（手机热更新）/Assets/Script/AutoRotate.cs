using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0,Time.deltaTime*50,0);
    }
}
