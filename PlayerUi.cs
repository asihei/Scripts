using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 ������������ ��� UI � TMpro text
using UnityEngine.UI;
using TMPro;

public class PlayerUi : MonoBehaviour
{
    //���� �������� ������� �������
    public Slider healthBar;
    // ���� ������ � ����������� �����
    public TextMeshProUGUI CoinsCounter;
    //���� ������� ������
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        //������������ �������� ��� ui
        healthBar.maxValue = player.maxhealth;
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coin;
    }

    // Update is called once per frame
    void Update()
    {
        //������������ �������� ��� ui
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coin;
    }
}
