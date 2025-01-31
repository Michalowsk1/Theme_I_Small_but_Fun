using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    [SerializeField] GameObject solidPurpleWall;
    [SerializeField] GameObject purpleWall;
    [SerializeField] GameObject triggerBox;
    bool blue = false, red = false;
    // Start is called before the first frame update
    void Start()
    {
        solidPurpleWall.SetActive(false);
        purpleWall.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Red")
        {
            red = true;
        }

        if(collision.gameObject.tag == "Blue")
        {
            blue = true;
        }

        if(collision.gameObject.tag == "Collider")
        {
            triggerBox.SetActive(false);
            solidPurpleWall.SetActive(true);
            purpleWall.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (blue == true && red == true)
        {
            solidPurpleWall.SetActive(false);
        }
    }
}
