/*
Crear una burbuja en una posición aleatoria cada 10 segundos y borrarla después
de 10 segundos.
(Al final ya no lo usamos.)

Lalo Villalpando
01/03/2021
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleAdder : MonoBehaviour
{
    [SerializeField] GameObject newBubble;
    [SerializeField] float maxHeight;
    [SerializeField] float minHeight;
    [SerializeField] float maxWidth;
    [SerializeField] float minWidth;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addBubble", 0f, 10f);
    }

    void addBubble(){
        // Crear nuevo vector
        Vector3 newPos;
        newPos.x = Random.Range(minWidth, maxWidth);
        newPos.y = Random.Range(minHeight, maxHeight);
        newPos.z = 0;
        // Crear objeto
        GameObject newObject = Instantiate(newBubble, newPos, Quaternion.identity);
        // Esperar n segundos
        
        Destroy(newObject, 10);
    }
}
