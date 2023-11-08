using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyControllerVector3DistanceExample : MonoBehaviour

{
   
    //reference variable to the transform class
    public Transform playerTR;
   // public Rigidbody playerRB;
    public float attackSpeed;
    public float attackDistance;
    // Use this for initialization
    public float enemyToPlayerDistance;
    public GameObject enemyObject;
    public GameObject PlayerObject;
    public bool isEnemyAttacking;
    public GameObject enemyLazerPrefab;
    float coundDown = 5.54f;

    // Update is called once per frame
    void Update()
    {
        coundDown -= Time.deltaTime;
        Debug.Log(coundDown);
        LookAtPlayer();
        MoveAtPlayer();
        enemyToPlayerDistance = Vector3.Distance(enemyObject.transform.position, PlayerObject.transform.position);
        //InvokeRepeating("fireAtPlayer", 2, 1);
        
    }

    //this is not intro level scripting so just know that the enemy bot   
    //will always rotate to face the player
    void LookAtPlayer()
    {
        if (enemyToPlayerDistance > attackDistance)
        {
            isEnemyAttacking = true;
            
        }
        else
        {
            isEnemyAttacking = false;
        }
    }
    void MoveAtPlayer()
    {
       //layerRB.AddRelativeForce(new Vector2(0, attackSpeed));
        transform.Translate(attackSpeed, 0, 0);
    }
    void fireAtPlayer()
    {
        if (enemyToPlayerDistance < 12)
        {
            Instantiate(enemyLazerPrefab, transform.position, transform.rotation);
        }
    }
}




