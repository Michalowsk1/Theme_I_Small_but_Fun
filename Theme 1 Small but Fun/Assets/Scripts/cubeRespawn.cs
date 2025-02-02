using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRespawn : MonoBehaviour
{
    [SerializeField] GameObject killZone;
    [SerializeField] GameObject Cube;
    [SerializeField] GameObject wall;
    public Transform spawnPoint;
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
        if(collision.gameObject.tag == "KillCube")
        {
            Cube.transform.position = spawnPoint.position;
        }

        if(collision.gameObject.tag == "RedPlate")
        {
            wall.SetActive(false);
        }
    }
}
