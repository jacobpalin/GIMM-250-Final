using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPanelControls : MonoBehaviour
{
    public GameObject anim;
    public GameObject anim2;
    public GameObject image;
    public GameObject image2;
    public GameObject lever2;

    public AudioSource audioSource;

    private GameObject lever;
    public GameObject prevent;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lever2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(lever != null)
            {
                image.SetActive(false);
                image2.SetActive(false);
                anim.SetActive(true);
                anim2.SetActive(true);
                audioSource.Play();
                lever.SetActive(false);
                prevent.SetActive(false);
            }
        }

        if(!prevent.activeInHierarchy && !audioSource.isPlaying)
        {
            lever2.SetActive(true);
        }

        /*if(prevent == null)
        {
            if (!audioSource.isPlaying)
            {
                lever2.SetActive(true);
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("StoryPanel"))
        {
            lever = collision.gameObject;
        }

        /*if (collision.CompareTag("prevent"))
        {
            prevent = collision.gameObject;
        }*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("StoryPanel"))
        {
            lever = null;
        }

        /*if (collision.CompareTag("prevent"))
        {
            prevent = null;
        }*/
    }
}
