using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{

    public GameObject ourPistol;
    public AudioSource gunPickUp;
    public GameObject pistolFireObj;

    private void OnTriggerEnter()
    {
        gunPickUp.Play();
        ourPistol.SetActive(true);
        pistolFireObj.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
