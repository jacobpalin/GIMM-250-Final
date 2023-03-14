using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsonStoryFunction : MonoBehaviour
{
    GameObject apple;
    public AudioSource audioSource;
    public GameObject lever2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        apple = GameObject.Find("AppleAnimationOne(Clone)");

        if(apple.activeInHierarchy && !audioSource.isPlaying)
        {
            lever2.SetActive(true);
        }
    }
}
