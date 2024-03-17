using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hancur : MonoBehaviour
{
    public GameObject musuh;
    // Start is called before the first frame update
   // public GameObject musuh;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}


