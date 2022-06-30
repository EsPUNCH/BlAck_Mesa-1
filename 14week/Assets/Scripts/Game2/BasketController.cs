using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    
    public GameObject Win;
    int speed = 10; //���ǵ�
    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
        Invoke("GameStop", 30f); // ���� 30�� ����
        Invoke("TimeLimit", 28f); //������ ���߱�?
        
    }

    void GameStop()
    {
        Win.SetActive(true); //�¸� �޽��� ���

        Time.timeScale = 0;
    }






    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x������ �̵��� ��
        this.transform.Translate(new Vector3(xMove, 0));  //�̵�
    }
}
