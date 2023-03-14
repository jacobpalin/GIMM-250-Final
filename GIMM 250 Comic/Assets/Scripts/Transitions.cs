using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
    private GameObject transitionZone;

    public Animator animator;

    private int levelLoading;

    // Update is called once per frame
    void Update()
    {
       if(transitionZone != null)
        {
            this.gameObject.SetActive(false);
            FadeInToLevel();
        }
    }

    public void FadeInToLevel()
    {
        animator.SetTrigger("FadeOut");
    }

    public void FadeComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Transition"))
        {
            transitionZone = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Transition"))
        {
            transitionZone = null;
        }
    }
}
