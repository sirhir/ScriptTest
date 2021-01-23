using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
        private int mp = 53;

        // 攻撃用の関数
        public void Attack()
        {
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage)
        {
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

        // 魔法攻撃関数
        public  void Magic(){
            if (mp >= 5){
                mp = mp - 5;
                Debug.Log( "魔法攻撃をした。残りMPは"+mp+"。" );
            }else{
                Debug.Log( "MPが足りないため魔法が使えない。" );
            }
        }

}

public class Test : MonoBehaviour
{

        int[] arr = {5,3,1,4,2};

        void Start ()
        {
                for(int i=0; i<arr.Length; i++){
                    Debug.Log( arr[i] );
                }

                for(int i=0; i<arr.Length; i++){
                    Debug.Log( arr[ arr.Length-1 - i ] );
                }

                // Bossクラスの変数を宣言してインスタンスを代入
                Boss boss = new Boss ();

                // 攻撃用の関数を呼び出す
                boss.Attack();
                // 防御用の関数を呼び出す
                boss.Defence(3);

                // 魔法を11回行う
                for(int i=0; i<11; i++){
                    boss.Magic();
                }
        }

        // Update is called once per frame
        void Update ()
        {

        }
}