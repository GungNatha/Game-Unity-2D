using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform Targetkamera;
    public float smoothspeed;
    public Vector3 offset;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x,-1.24f, 267f),
            Mathf.Clamp(transform.position.y,0.78f, 5.29f),
            transform.position.z);
    }

    private void FixedUpdate()
    {
        Vector3 positionkamera = Targetkamera.localPosition + offset;
        Vector3 smoothkamera = Vector3.Lerp(transform.position, positionkamera, smoothspeed);
        transform.position = smoothkamera;
    }
}