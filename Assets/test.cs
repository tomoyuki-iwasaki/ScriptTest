using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}


public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();


        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(3);

        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 11;
        array[2] = 12;
        array[3] = 13;
        array[4] = 14;

        // 配列の要素を昇順ですべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素を降順ですべて表示する
        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
