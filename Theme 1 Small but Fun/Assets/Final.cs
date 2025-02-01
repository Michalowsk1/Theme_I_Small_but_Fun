using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        wall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "YellowPlate")
        {
            wall.SetActive(false);
        }
    }
}
