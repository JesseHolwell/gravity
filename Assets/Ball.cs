using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if player isnt holding the ball?

        Debug.Log("moving towards spawn");
        gameObject.GetComponent<Rigidbody>().velocity -= Vector3.MoveTowards(transform.position, GameObject.Find("Spawn").transform.position, 0.5f)/1000;
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "GoalCollider")
        {
            Debug.Log("Score!");

            gameObject.transform.position = GameObject.Find("Spawn").transform.position;
        }

    }
}
