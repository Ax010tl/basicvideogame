using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medusa : MonoBehaviour
{
    [SerializeField] float maxWidth;
    [SerializeField] float minWidth;
    Vector3 direccion;
    float speed = 0.05f; 
    // Start is called before the first frame update
    void Start()
    {
        direccion.x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3();
        if(transform.position.x <= minWidth){
            speed*=-1;
            newPos = transform.position - direccion*speed;
        }
        if(transform.position.x >= maxWidth){
            speed*=-1;
            newPos = transform.position - direccion*speed;
        }
        transform.position = newPos;
    }
}
