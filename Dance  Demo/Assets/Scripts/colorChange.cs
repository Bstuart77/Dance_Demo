﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public GameObject[] floors;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while(true)
        {
            Color newColor = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
            foreach(GameObject go in floors)
            {
                go.GetComponent<Renderer>().material.color = newColor;
            }
           yield return new WaitForSeconds(.1f);

        }
    }
}
