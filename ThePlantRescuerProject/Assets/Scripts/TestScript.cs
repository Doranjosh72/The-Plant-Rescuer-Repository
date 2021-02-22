using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
   //Variables that will be used in unity
    public string StartText;
    public string UpdateText;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StartText); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(UpdateText);
    }
}
