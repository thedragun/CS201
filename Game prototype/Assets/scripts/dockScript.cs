using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dockScript : MonoBehaviour
{
    Canvas dockMenu;
    Collider collider;
    MeshRenderer text;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();

        text = GetComponent<MeshRenderer>();
        
        dockMenu = GetComponent<Canvas>();
        dockMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (Input.GetKey(KeyCode.E) == true)
            {
                dockMenu.enabled = true;
                
            }

        }
        OnTriggerEnter(collider);
    }
}
