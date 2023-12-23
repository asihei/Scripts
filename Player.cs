using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Поля

    public AudioSource audioSource;

    public AudioClip damageSound;

    //Здоровье
    public int health = 10;
    public int maxhealth = 10;

    //Монеты
    public int coin = 0;

    //Префаб огненого шара
    public GameObject fireballPrefab;

    //Место откуда огненый шар появляеться
    public Transform attackPoint;




    private void Update()
    {
        //Условие нажатие на лкм
        if (Input.GetMouseButtonDown(0))
        {
            //Создание копии(префаб,где появиться,поворот)
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }

    //Метод получения урона
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            print("Health:" + health);
            audioSource.PlayOneShot(damageSound);

        }
        else
        {
            print("You Dead");
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    //Метод увелечения монет
    public void CollectCoins()
    {
        coin += 1;
        print("coins" + coin);
    }
}
