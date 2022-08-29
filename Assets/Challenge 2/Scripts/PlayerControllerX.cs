using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool dogCreateReady;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogCreateReady== false)
        {
            StartCoroutine(createDogs());
        }
    }
    IEnumerator createDogs(){
        //sets boolean to true
        dogCreateReady = true;
        // Creates the Dog
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        // add 1 second wait time
        yield return new WaitForSeconds(1);
        // sets boolean to false after wait
        dogCreateReady = false;
    }   
}
