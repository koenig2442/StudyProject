using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public int id;
    public string playername;
    public string title;
    public string weapon;
    public  float strength;
    public int level;

    public string Talk()
    {
        return "��ȭ�� �ɾ����ϴ�.";
    }

    public string HasWeapon()
    {
        return weapon;
    }
    public  void LevelUp()
    {
        level = level + 1;
    }
}
