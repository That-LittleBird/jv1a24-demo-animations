using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeReference] Animator door;

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            print("Open door!");
            door.SetBool("IsOpen", true);
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){
            print("Close door!");
            door.SetBool("IsOpen", false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
