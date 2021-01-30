using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public Transform background1;
    public Transform background2;
    public float speed = 10f;
    public float moveAmount = 4870;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if(background1.transform.localPosition.y < -1800)
        {
            background1.transform.localPosition = new Vector3(background1.transform.position.x, background1.transform.position.y + moveAmount, background1.transform.position.z);
        }

        if(background2.transform.localPosition.y < -1800)
        {
            background2.transform.localPosition = new Vector3(background2.transform.position.x, background2.transform.position.y + moveAmount, background2.transform.position.z);
        }

        background1.Translate(-Vector2.up * speed, Space.World);
        background2.Translate(-Vector2.up * speed, Space.World);
    }
}
