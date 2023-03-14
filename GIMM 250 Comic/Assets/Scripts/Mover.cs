using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private GameObject Box1;
    private GameObject Box2;
    private GameObject Box3;
    public float min = -10.8f;
    public float max = 60.35f;

    // Start is called before the first frame update
    void Start()
    {
        Box1 = GameObject.Find("Boxxy");
        Box2 = GameObject.Find("Square");
        Box3 = GameObject.Find("Square2");
        Box1.transform.position = new Vector3(55.35f, Box1.transform.position.y, Box1.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Box2.transform.position = new Vector3(Mathf.PingPong(Time.time * 4, max - min) + min, Box2.transform.position.y, Box2.transform.position.z);
        Box3.transform.position = new Vector3(Mathf.PingPong(Time.time * 4, max - min) + min, Box3.transform.position.y, Box3.transform.position.z);
        Box1.transform.position = new Vector3(-1*Mathf.PingPong(Time.time * 4, max - min) + max, Box1.transform.position.y, Box1.transform.position.z);
        
    }
}
