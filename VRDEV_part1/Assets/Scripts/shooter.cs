using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class shooter : MonoBehaviour
{
    public GameObject bulles;
    public Transform spawnPos;

    private float speed = 20;

    void Start()
    {
        XRGrabInteractable GunGrab = GetComponent<XRGrabInteractable>();
        GunGrab.activated.AddListener(hanghang);
    }

    void Update()
    {
        
    }

    public void hanghang(ActivateEventArgs arg){
        GameObject newBullet = Instantiate(bulles);
        newBullet.transform.position = spawnPos.position;
        newBullet.GetComponent<Rigidbody>().velocity = spawnPos.forward * speed;

        Destroy(newBullet, 5);
    }
    // Simon Axelsen
}
