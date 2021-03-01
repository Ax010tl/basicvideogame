using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tortuga : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }
    Vector3 vertical;
    [SerializeField] float speed;
    [SerializeField] float maxHeight;
    [SerializeField] float minHeight;
    // Update is called once per frame
    void Update() {
        vertical.y = Input.GetAxisRaw("Vertical");
        Vector3 newPos = transform.position + vertical*speed;
        transform.position = newPos;
    }
}
