using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    private GameObject house;
    public bool inHouse = false;
    // Start is called before the first frame update
    void Start()
    {
        house = GameObject.Find("house");
    }

    // Update is called once per frame
    void Update()
    {
        CheckPresence();
    }

    void CheckPresence() {
        var dist = Vector3.Distance(transform.position, house.transform.position);
        if (dist > 2 && dist < 9)
        {
            inHouse = true;
        }
        else
            inHouse = false;
    }
}

