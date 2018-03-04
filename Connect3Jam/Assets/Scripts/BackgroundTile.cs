using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
    public GameObject[] animals;

	void Start ()
    {
		
	}
	

    void Initialize ()
    {
        int animalToUse = Random.Range(0, animals.Length);
        GameObject go = Instantiate(animals[animalToUse], transform.position, Quaternion.identity);
        go.transform.parent = transform;
    }
}
