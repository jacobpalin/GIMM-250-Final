using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAfterPanel : MonoBehaviour
{
    public GameObject lever;
    bool despawn = false;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying && !despawn)
        {
            despawn = true;
            lever.SetActive(true);
        }
    }
}
