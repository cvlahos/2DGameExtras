using UnityEngine;
using System.Collections;

public class CoroutineEx : MonoBehaviour
{
    

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }


    IEnumerator MyCoroutine()
    {     
      
        print("do something 1");
        yield return new WaitForSeconds(5f);
        print("do something 2");

        yield return new WaitForSeconds(6f);

        print("MyCoroutine is now finished.");

        yield return null; // also use this in a loop to not lock up unity
    }
}
