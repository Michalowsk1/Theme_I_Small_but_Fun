using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redWallPuzzle : MonoBehaviour
{
    [SerializeField] GameObject Cube;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject floor;
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
        if(collision.gameObject.tag == "Collider")
        {
            wall.SetActive(false);
        }

        if (collision.gameObject.tag == "Collision")
        {
            floor.SetActive(true);
        }
    }
}
