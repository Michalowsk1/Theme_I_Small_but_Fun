using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource behindYou, Red, Ramp, Orange, youWin;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Win")
        {
            youWin.Play();
        }

        if (collision.gameObject.tag == "Collider")
        {
            behindYou.Play();
        }

        if (collision.gameObject.tag == "RedPlate")
        {
            Red.Play();
        }

        if (collision.gameObject.tag == "MazeCollision")
        {
            Ramp.Play();
        }

        if (collision.gameObject.tag == "YellowPlate")
        {
            Orange.Play();
        }
    }
}
