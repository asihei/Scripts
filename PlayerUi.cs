using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 пространства имён UI и TMpro text
using UnityEngine.UI;
using TMPro;

public class PlayerUi : MonoBehaviour
{
    //Поле игрового объекта слайдер
    public Slider healthBar;
    // поле текста с количеством монет
    public TextMeshProUGUI CoinsCounter;
    //Поле скрипта игрока
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        //Присваивание значений для ui
        healthBar.maxValue = player.maxhealth;
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coin;
    }

    // Update is called once per frame
    void Update()
    {
        //Присваивание значений для ui
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coin;
    }
}
