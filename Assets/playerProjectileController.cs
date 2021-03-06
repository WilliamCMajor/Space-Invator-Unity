using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerProjectileController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;


    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.Self);
        //Debug.Log("current score" + score);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if ((collider.gameObject.tag != "DeathZoneTop") && (collider.gameObject.tag != "Player" ) && (collider.gameObject.tag != "Barrier"))
        {

            Destroy(collider.gameObject);
        }


        if (collider.gameObject.tag == "ShipAllien")
        {
            
             FindObjectOfType<GameState>().updateScore();

        }
    }






}
