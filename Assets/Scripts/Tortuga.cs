/*
Controla el movimiento vertical de la tortuga. Cuando colisiona con otros
objetos, cambia de tamaño momentáneamente.

Lalo Villalpando
02/03/2021
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tortuga : MonoBehaviour {
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
            // encojer a tortuga
	        transform.localScale = new Vector3(0.65f, 0.65f, 1);            
        } else if (other.gameObject.tag == "Meta"){
	        // hacer más grande a la tortuga
            transform.localScale = new Vector3(1.3f, 1.3f, 1);
        }
        yield return new WaitForSeconds(0.5f);
            // Wait n sec
            transform.localScale = new Vector3(1, 1, 1);
    }
}
