using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    [SerializeField] GameObject SolidPurpleWall;
    [SerializeField] GameObject PurpleWall;
    [SerializeField] GameObject Collider;
    bool red = false;
    bool blue = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (red = true && blue == true)
        {
            SolidPurpleWall.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Red")
        {
        red = true; 
        }

        if (collision.gameObject.tag == "Blue")
        {
            blue = true;
        }

        if(collision.gameObject.tag == "Collision")
        {
            Collider.SetActive(false);
            SolidPurpleWall.SetActive(true);
            SolidPurpleWall.SetActive(true);
        }
    }
}
