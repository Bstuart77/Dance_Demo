using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoChangeColor : MonoBehaviour
{
    public Light light;
    private float timeLeft = 1f;

    private void Start()
    {
        StartCoroutine(TimeCheck());
        light = GetComponent<Light>();
    }

    IEnumerator TimeCheck()
    {
        while (timeLeft > 0)
        {
            light.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            yield return new WaitForSeconds(1.5f);
        }
    }
}
