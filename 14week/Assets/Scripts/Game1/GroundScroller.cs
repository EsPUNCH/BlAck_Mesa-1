﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public SpriteRenderer[] tiles;
    public Sprite[] groundimg;
    public float speed;
    void Start()
    {
        temp = tiles[1];
    }
    SpriteRenderer temp;

    // Update is called once per frame
    void Update()
    {
        if(GameManager2.instance.isPlay)
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                if (-15 >= tiles[i].transform.position.x)
                {
                    for (int q = 0; q < tiles.Length; q++)
                    {
                        if (temp.transform.position.x < tiles[q].transform.position.x)
                            temp = tiles[q];
                    }
                    tiles[i].transform.position = new Vector2(temp.transform.position.x + 1.34f, -1.7481868f);
                }
            }
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime * GameManager2.instance.gameSpeed);
            }
        }
    }
}
