using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindChildNameandComponent : MonoBehaviour
{
    Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Canvas").GetComponentInChildren<Transform>().Find("Text (10)").GetComponent<Text>();
        myText.text = "Hey Hey";
        // gameobject.GetComponentInChildren<Transform>().Find(Name).GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
