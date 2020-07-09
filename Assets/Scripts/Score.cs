using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{
    
    public Transform player;
    public Text scoreText;
    public float position;

    // Update is called once per frame
    void Update(){
        //Debug.Log(player.position.z);
        //Vector3 p = Mathf.Abs(Transfo
        position = -(player.position.z - 100);
        scoreText.text = position.ToString("0");
        //scoreText.text = player.position.z.ToString("0");
    }
}
