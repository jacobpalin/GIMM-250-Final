using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverControls : MonoBehaviour
{
    private GameObject leverOne;
    private GameObject leverTwo;

    public GameObject firstLeverOff;
    public GameObject firstLeverOn;

    public GameObject secondLeverOff;
    public GameObject secondLeverOn;

    public GameObject doorOne;
    public GameObject doorTwo;
    public GameObject doorTwoExit;
    public GameObject doorThree;
    public GameObject doorFour;
    public GameObject doorFourExit;
    public GameObject doorFive;
    public GameObject doorSix;
    public GameObject doorSixExit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (leverOne != null)
            {
                firstLeverOff.SetActive(false);
                firstLeverOn.SetActive(true);

                doorTwo.SetActive(false);
                doorTwoExit.SetActive(false);
                doorThree.SetActive(true);
                doorFour.SetActive(true);

            }

            if (leverTwo != null)
            {
                secondLeverOff.SetActive(false);
                secondLeverOn.SetActive(true);

                doorFourExit.SetActive(false);
                doorFive.SetActive(true);
                doorOne.SetActive(false);
                doorSix.SetActive(true);
                doorSixExit.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lever1"))
        {
            leverOne = collision.gameObject;
        }

        if (collision.CompareTag("Lever2"))
        {
            leverTwo = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Lever1"))
        {
            leverOne = null;
        }

        if (collision.CompareTag("Lever2"))
        {
            leverTwo = null;
        }
    }
}
