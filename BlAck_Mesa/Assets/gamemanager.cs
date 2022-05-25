using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    private int D, H, M, Time = 141120; // ��¥, �ð�
    private int Gold = 0;               // ������
    private int Intelligence = 0;       // ����
    private int Endurance = 100;        // ü��
    private int MAXEndurance = 100;     // �ִ� ü��

    public GameObject Work;     // �� ��ư
    public GameObject Study;    // ���� ��ư
    public GameObject Exercise; // � ��ư
    public GameObject Rest;     // �޽� ��ư
    public GameObject MAXEnduImage; // ü���� �̹� ���� ã���ϴ�!!
    public GameObject MINEnduImage; // ü���� �����ϴ�!!

    public Text timeText;       // �ð��� ��Ÿ���� �ؽ�Ʈ
    public Text GoldText;       // �������� ��Ÿ���� �ؽ�Ʈ
    public Text IntelligencText;// ������ ��Ÿ���� �ؽ�Ʈ
    public Text EnduranceText;  // ü���� ��Ÿ���� �ؽ�Ʈ


    private void Start()
    {
        MAXEnduImage.SetActive(false);
        MINEnduImage.SetActive(false);
    }

    void Update()
    {
        D = Time / 1440;
        H = (Time - D * 1440) / 60;
        M = (Time - D * 1440) % 60;
        timeText.text = D + "�� " + H + "�� " + M + "��";
        GoldText.text = "������ : " + Gold + "��";
        IntelligencText.text = "���� : " + Intelligence;
        EnduranceText.text = "ü�� : " + Endurance + "/" + MAXEndurance;
        if(Time <= 0)
        {
            SceneManager.LoadScene("ending1");
        }
    }

    public void ClickWork()     // �� ��ư�� Ŭ��������
    {
        if (Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            Gold += 100;
            Endurance -= 5;
            Time -= 300;
        }
    }
    public void ClickStudy()    // ���� ��ư�� Ŭ��������
    {
        if (Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            Intelligence += 10;
            Endurance -= 5;
            Time -= 60;
        }
    }
    public void ClickExercise() // � ��ư�� Ŭ��������
    {
        if (Endurance <= 0)
        {
            StartCoroutine(MINEndu());
        }
        else
        {
            Endurance -= 5;
            MAXEndurance += 10;
            Time -= 300;
        }
    }
    public void ClickRest()     // �޽� ��ư�� Ŭ��������
    {
        if(Endurance >= MAXEndurance)
        {
            StartCoroutine(MAXEndu());
        }
        else
        {
            Endurance = MAXEndurance;
            Time -= 480;
        }
    }

    IEnumerator MAXEndu()       // ü���� ������ ��
    {
        MAXEnduImage.SetActive(true);
        yield return new WaitForSeconds(2);
        MAXEnduImage.SetActive(false);
    }
    IEnumerator MINEndu()       // ü���� ���� ��
    {
        MINEnduImage.SetActive(true);
        yield return new WaitForSeconds(2);
        MINEnduImage.SetActive(false);
    }
}