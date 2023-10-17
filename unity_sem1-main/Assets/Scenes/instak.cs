using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instak : MonoBehaviour
{
    public GameObject prefab;
    public Transform Spawn;
    public void alahakbar()
    {
        Instantiate(prefab, Spawn.transform.position, Quaternion.identity);
    }
}
