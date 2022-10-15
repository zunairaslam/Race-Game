using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject finishUI;
    public GameObject playerUI;
    public GameObject playerCar;

    public TMP_Text status;

    private void Start()
    {
        StartCoroutine(WaitForFinishUI());
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(FinishZone());
            gameObject.GetComponent<BoxCollider>().enabled = false;

            status.text = "You Win";
        }
        else if (other.gameObject.tag == "OpponentCar")
        {
            StartCoroutine(FinishZone());
            gameObject.GetComponent<BoxCollider>().enabled = false;

            status.text = "You Lose";
        }
    }

    IEnumerator WaitForFinishUI()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(25f);
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    IEnumerator FinishZone()
    {
        finishUI.SetActive(true);
        playerUI.SetActive(false);
        playerCar.SetActive(false);

        yield return new WaitForSeconds(3f);
        Time.timeScale = 0f;
    }
}
