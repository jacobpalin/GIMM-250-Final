using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    // Code from https://youtu.be/0JXVT28KCIg

    private GameObject currentTeleporter;
    private GameObject teleporter;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<DoorTeleport>().GetDestination().position;
            }
        }

        if(teleporter != null)
        {
            transform.position = teleporter.GetComponent<DoorTeleport>().GetDestination().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Door"))
        {
            currentTeleporter = collision.gameObject;
        }

        if(collision.CompareTag("Teleporter"))
        {
            teleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            currentTeleporter = null;
        }

        if (collision.CompareTag("Teleporter"))
        {
            teleporter = null;
        }
    }
}
