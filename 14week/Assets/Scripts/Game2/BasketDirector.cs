using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰�

public class BasketDirector : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject lose;
    void Start()
    {
        lose.SetActive(false);
        this.hpGauge = GameObject.Find("hpGauge");

    }

    public void DecreaseHp()
    {
        Debug.Log("����!");
        lose.SetActive(true);
        Time.timeScale = 0;
    }




}
