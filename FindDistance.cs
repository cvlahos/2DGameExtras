using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDistance : MonoBehaviour
{
    float distanceBetweenTwoThings;

    public Transform aThing;
    public Transform bThing;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetweenTwoThings = Vector3.Distance(aThing.position, bThing.position); //the xyz of both a and b are being tracked in real time inside update loop so the Distance method inside the Vector 3 class can return the distance
        Debug.Log(distanceBetweenTwoThings);
    }
}
