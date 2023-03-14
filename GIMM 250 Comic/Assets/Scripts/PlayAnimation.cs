using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public GameObject knife;
    public GameObject appleOne; //apple one animation
    public GameObject appleTwo; //apple two animation 
    public GameObject imageOne; //image one 
    public GameObject imageTwo; //image two

    public bool animOne = true;
    public bool animTwo = true;

    void Update()
    {
        PlayAnimations();
    }

    public void PlayAnimations()
    {
        //play the first aniamtion
        if (knife.transform.position.y <= 5 && animOne)
        {
            Instantiate(appleOne); //plays animation
            imageOne.SetActive(false); //disables image

            animOne = false;
        }
        
        //plays second animation
        if (knife.transform.position.y <= 5 && animTwo)
        {
            Instantiate(appleTwo); //plays animation
            imageTwo.SetActive(false); //disables image

            animTwo = false;
        }
    }
}
