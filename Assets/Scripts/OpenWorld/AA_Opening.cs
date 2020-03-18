using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_Opening : MonoBehaviour
{

    public GameObject FadeIn;
    public GameObject theText;
    public GameObject initialCamera;
    public GameObject FadeOut;
    public GameObject thePlayer;
    public GameObject thePlayerFake;




    void Start()
    {
        StartCoroutine(OpenBegin());
    }

    IEnumerator OpenBegin()
    {
        yield return new WaitForSeconds(1);
        theText.SetActive(true);
        yield return new WaitForSeconds(5);
        FadeIn.GetComponent<Animator>().enabled = true;
        initialCamera.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(4);
        FadeOut.SetActive(true);
        FadeIn.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        thePlayerFake.SetActive(false);
        thePlayer.SetActive(true);
        initialCamera.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        FadeOut.SetActive(false);
        FadeIn.SetActive(true);
        FadeIn.GetComponent<Animator>().Play("FadeIn");

    }

}
