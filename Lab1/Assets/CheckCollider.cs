using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Произошло столкновение с " + other.gameObject.name);
        other.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Завершено столкновение с " + other.gameObject.name);
        other.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

    }
}
