using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //1. 변수
        Debug.Log("Hello Unity!");

        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);

        //2.그룹형 변수

        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monstersLevel = new int[3];
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monstersLevel[0]);
        Debug.Log(monstersLevel[1]);
        Debug.Log(monstersLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3.연산자
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutoral = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutoral);

        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        //Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까?" + condition);

        //4.키워드
        //int float string new List

        //5.조건문
        if(condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }

        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if(isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }
        switch (monsters[0]) 
        {
            case "슬라임" :
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형몬스터가 출현!");
                break ;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;

        }

        //6. 반복문
        while (health > 0)
        {
                health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망하였습니다.");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다");
                break;
            }
        }

        




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
