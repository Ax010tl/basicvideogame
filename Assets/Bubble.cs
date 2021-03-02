using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] float maxHeight;
    [SerializeField] float minHeight;
    [SerializeField] float maxWidth;
    [SerializeField] float minWidth;
    [SerializeField] AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // print(transform.position.y);
        if(transform.position.y > maxHeight) relocate();
    }
    // Cuando se toque la burbuja, generar una nueva :D
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            // Sonidos kul
            sound.Play();
            relocate();
        }
    }

    private void relocate(){
        Vector3 newPos;
        newPos.x = Random.Range(minWidth, maxWidth);
        newPos.y = Random.Range(minHeight, maxHeight);
        newPos.z = 0;
        transform.position = newPos;
        print("Count++");
    }

}
