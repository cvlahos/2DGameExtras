using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchTwo : MonoBehaviour
{
    public GameObject newHexagon_Prefab;
    public GameObject new_Circle_Prefab;

    float timeInLevel = 0;  // each copy of this script has a timeInLevel variable


   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

        timeInLevel += Time.deltaTime;   // counting how long the object is in the level
    }


    //IEnumerator

    private IEnumerator OnCollisionStay2D(Collision2D other)
    {
        Sphere1 otherGameObjectsSript = other.gameObject.GetComponent<Sphere1>();   // ref to the class (script) for the other object that has made contact. 

            if (other.gameObject.tag == "square" && this.gameObject.tag == "square")
            {
                if (otherGameObjectsSript.timeInLevel > timeInLevel) //finding out if the other object has been in the level longer. This is to force one to destroy first
                {

                Vector3 relocateother = new Vector3(other.transform.position.x, other.transform.position.y - 100f, other.transform.position.z); //finding a location for other object south of the camera
                other.gameObject.transform.position = relocateother;  //relocating instead of destroying first to solve a null ref bug because code was running on a destroyed script or component
                Destroy(other.gameObject, 2f);

            }


                yield return new WaitForSeconds(.1f); //slight delay
                Instantiate(newHexagon_Prefab, this.transform.position, this.transform.rotation); //new prefab

            ///Destroy(gameObject);
            Vector3 relocate = new Vector3(transform.position.x, transform.position.y - 100f, transform.position.z); //same as above but for this gameobject - remebmer for one to live both touching objects must go bye bye
            this.transform.position = relocate;

            }
            

            if (other.gameObject.tag == "Hexagon" && this.gameObject.tag == "Hexagon")
            {

                if (otherGameObjectsSript.timeInLevel > timeInLevel)
                {

                Vector3 relocateother = new Vector3(other.transform.position.x, other.transform.position.y - 100f, other.transform.position.z);
                
                other.gameObject.transform.position = relocateother;
                Destroy(other.gameObject,2f);

            }
           
            yield return new WaitForSeconds(.1f);
            Instantiate(new_Circle_Prefab, this.transform.position, this.transform.rotation);

             
            Vector3 relocate = new Vector3(transform.position.x, transform.position.y - 100f, transform.position.z);
            this.transform.position = relocate;
            Destroy(gameObject, 2f);


        }
        
       
    }

}
