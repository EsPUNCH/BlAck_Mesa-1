﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBase : MonoBehaviour
{
    public float mobSpeed = 0;
    public Vector2 StartPosition;

    private void OnEnable()
    {
        transform.position = StartPosition;
    }
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager2.instance.isPlay)
        transform.Translate(Vector2.left * Time.deltaTime * GameManager2.instance.gameSpeed);

        if (transform.position.x < -11)
        {
            gameObject.SetActive(false);
        }
    }
}
