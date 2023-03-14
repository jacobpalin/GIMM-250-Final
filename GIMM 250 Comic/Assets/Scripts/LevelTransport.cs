using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransport : MonoBehaviour
{

    private GameObject levelLeverSeth;
    private GameObject levelLeverJacob1;
    private GameObject levelLeverJacob2;
    private GameObject levelLeverCarson1;
    private GameObject levelLeverCarson2;
    private GameObject storyLeverCarson;
    private GameObject levelLeverRedacted;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (levelLeverSeth != null)
            {
                SceneManager.LoadScene("LevelTwo");
            }

            if (levelLeverJacob1 != null)
            {
                SceneManager.LoadScene("Jacob 1");
            }

            if (levelLeverJacob2 != null)
            {
                SceneManager.LoadScene("Jacob 2");
            }

            if (levelLeverCarson1 != null)
            {
                SceneManager.LoadScene("Carson 1");
            }

            if (levelLeverCarson2 != null)
            {
                SceneManager.LoadScene("Carson 2");
            }

            if (storyLeverCarson != null)
            {
                SceneManager.LoadScene("CarsonStory1");
            }

            if (levelLeverRedacted != null)
            {
                SceneManager.LoadScene("Redacted 1");
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SethLvl2"))
        {
            levelLeverSeth = collision.gameObject;
        }

        if (collision.CompareTag("JacobLvl1"))
        {
            levelLeverJacob1 = collision.gameObject;
        }

        if (collision.CompareTag("JacobLvl2"))
        {
            levelLeverJacob2 = collision.gameObject;
        }

        if (collision.CompareTag("CarsonLvl1"))
        {
            levelLeverCarson1 = collision.gameObject;
        }

        if (collision.CompareTag("CarsonLvl2"))
        {
            levelLeverCarson2 = collision.gameObject;
        }

        if (collision.CompareTag("CarsonStory1"))
        {
            storyLeverCarson = collision.gameObject;
        }

        if (collision.CompareTag("RedactedLever"))
        {
            levelLeverRedacted = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("SethLvl2"))
        {
            levelLeverSeth = null;
        }

        if (collision.CompareTag("JacobLvl1"))
        {
            levelLeverJacob1 = null;
        }

        if (collision.CompareTag("JacobLvl2"))
        {
            levelLeverJacob2 = null;
        }

        if (collision.CompareTag("CarsonLvl1"))
        {
            levelLeverCarson1 = null;
        }

        if (collision.CompareTag("CarsonLvl2"))
        {
            levelLeverCarson2 = null;
        }

        if (collision.CompareTag("CarsonStory1"))
        {
            storyLeverCarson = null;
        }

        if (collision.CompareTag("RedactedLever"))
        {
            levelLeverRedacted = null;
        }
    }
}
