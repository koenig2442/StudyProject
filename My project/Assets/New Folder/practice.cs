using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //1. ����
        Debug.Log("Hello Unity!");

        int level = 5;
        float strength = 15.5f;
        string playerName = "���˻�";
        bool isFullLevel = false;

        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);

        //2.�׷��� ����

        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monstersLevel = new int[3];
        Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monstersLevel[0]);
        Debug.Log(monstersLevel[1]);
        Debug.Log(monstersLevel[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        items.RemoveAt(0);

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3.������
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�?" + isFullLevel);

        bool isEndTutoral = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutoral);

        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        //Debug.Log("����� ���°� ���޴ϱ�?" + isBadCondition);

        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ���°� ���޴ϱ�?" + condition);

        //4.Ű����
        //int float string new List

        //5.���ǹ�
        if(condition == "����")
        {
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }

        else
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }

        if(isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        switch (monsters[0]) 
        {
            case "������" :
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("�������Ͱ� ����!");
                break ;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;

        }

        //6. �ݺ���
        while (health > 0)
        {
                health--;
            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�. " + health);
            else
                Debug.Log("����Ͽ����ϴ�.");

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�");
                break;
            }
        }

        




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
