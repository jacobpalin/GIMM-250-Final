using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    // Code from https://youtu.be/0JXVT28KCIg

    [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
}
