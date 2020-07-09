using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GroundMovement groundMovement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log("Ouch!");
        //Debug.Log(collisionInfo.collider.name);

        if(collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("OBSTACLEE!");
            movement.enabled = false;
            groundMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }

    }

}
