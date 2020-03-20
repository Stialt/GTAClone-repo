using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{

    public GameObject ourPistol;
    public AudioSource gunPickUp;

    private void OnTriggerEnter()
    {
        gunPickUp.Play();
        ourPistol.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
