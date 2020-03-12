using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;
    public GameObject credits_LeadDesigner;
    public GameObject credits_Story;

    void Start()
    {
        StartCoroutine(CamSwitcher());
    }
    
    IEnumerator CamSwitcher()
    {
        yield return new WaitForSeconds(2);
        credits_LeadDesigner.SetActive(true);
        yield return new WaitForSeconds(5);
        credits_Story.SetActive(true);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
    }
}
