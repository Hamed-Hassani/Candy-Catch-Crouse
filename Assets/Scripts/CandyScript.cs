using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            //Incresment Score
            GameManager.inctane.IncrementScore();

            Destroy(gameObject);
        }


        else if (collider.gameObject.tag == "Boundary")
        {
            //Decrement Lives
            GameManager.inctane.DecreaseLife();
            Destroy(gameObject);
        }
    }

}
