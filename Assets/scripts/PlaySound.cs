using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource playSound;
    double counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter = counter + 1;
            Debug.Log("shots fired");
            playSound.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("shots stopped: " + counter);
            playSound.Stop();
        }
    }
}
