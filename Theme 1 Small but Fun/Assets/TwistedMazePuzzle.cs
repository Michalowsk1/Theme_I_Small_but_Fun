using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwistedMazePuzzle : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject plate;
    [SerializeField] GameObject ramp;
    // Start is called before the first frame update
    void Start()
    {
        ramp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MazeCollision")
        {
            ramp.SetActive(true);
        }
    }
}
