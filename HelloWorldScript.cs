using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = gameObject.name;
        Debug.Log("Hello World " + name); 
    }

    // Update is called once per frame
    void Update()
    {
        // Objetivo: aumentar o z do transform ao atualizar o fps
        transform.position = transform.position + new Vector3(0,0,0.1f);
    }
}
