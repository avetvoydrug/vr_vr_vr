using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        //Cube.SetActive(true);
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick()
    {
        if (Cube.activeInHierarchy == true)
            Cube.SetActive(false);
        else
            Cube.SetActive(true);
    }
}

