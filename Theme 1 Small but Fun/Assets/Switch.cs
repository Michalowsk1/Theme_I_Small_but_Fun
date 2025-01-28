using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private GameObject blue;
    [SerializeField] private GameObject red;
    private int Count;
    // Start is called before the first frame update
    void Start()
    {
        Count = -1;
        blue.SetActive(true); red.SetActive(true); //stars game with neither blue nor red mode on
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Count++;
        }

        if (Count % 2 == 0) //even number of presses, red mode active
        {
            blue.SetActive(true); red.SetActive(false);
        }
        else //blue mode active for odd number of pressed
        {
            blue.SetActive(false); red.SetActive(true);
        }
    }
}