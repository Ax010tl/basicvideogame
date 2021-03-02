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

    public IEnumerator OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Medusa"){
            transform.localScale = new Vector3(0.65f, 0.65f, 1);            
        } else if (other.gameObject.tag == "Meta"){
            transform.localScale = new Vector3(1.3f, 1.3f, 1);
        }
        yield return new WaitForSeconds(0.5f);
            // Wait n sec
            transform.localScale = new Vector3(1, 1, 1);
    }
}
