using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
� ��//�������� ������
� ��public int health = 10;
    public int maxHealth = 10;

    //����� ��������� �����
    public int coins;

    //������ ��������� ���� � �������� Transform ����� �����
    public GameObject fireballPrefab;
    public Transform attackPoint;
    //���������, ���������� �� ������������ ������
    public AudioSource audioSource;
 //�������� ����, ���������� �������� ������ ��������� �����
    public AudioClip damageSound;
    //�����, ���������� �������� ������
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);

        }

        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }


    //�����, ������������� ����� �������
    public void CollectCoins()
    {
        coins++;
        print("��������� �������: " + coins);
    }


    void Update()
    {

        //���� ����� ������� ����� ������� ����, �� �������� �������� ���
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }
}