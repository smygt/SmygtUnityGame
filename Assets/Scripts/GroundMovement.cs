using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Rigidbody rbg;
    public float groundForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, 0, 100);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = transform.position + new Vector3(0, 0, -groundForce);
        rbg.AddForce(0, 0, -groundForce * Time.deltaTime);

    }
}
