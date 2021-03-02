using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] float maxHeight;
    [SerializeField] float minHeight;
    [SerializeField] float maxWidth;
    [SerializeField] float minWidth;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Cuando se toque la burbuja, generar una nueva :D
    public void OnTriggerEnter2D(Collider2D other){
        Vector3 newPos;
        newPos.x = Random.Range(minWidth, maxWidth);
        newPos.y = Random.Range(minHeight, maxHeight);
        newPos.z = 0;
        transform.position = newPos;
        print("Count++");
    }
}
