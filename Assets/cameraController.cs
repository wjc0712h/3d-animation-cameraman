using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    Vector3 originPos;
    float tStart = 0.0f;
    public float tEnd = 5.0f;
    public float magnitude = 0.5f;
    public float shakeSpeed = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        originPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (tStart < tEnd)
        {
 
            float x = Mathf.PerlinNoise(tStart * shakeSpeed, 0.0f) * 2.0f - 1.0f;
            float y = Mathf.PerlinNoise(0.0f, tStart * shakeSpeed) * 2.0f - 1.0f;


            transform.localPosition = originPos + new Vector3(x * magnitude, y * magnitude, 0);
            
            tStart += Time.deltaTime;
        }
        else
        {
            transform.localPosition = originPos;
        }
    }
}
