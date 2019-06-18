using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Complete
{
    public class GameManager : MonoBehaviour
    {
        public Text enemy_num_text;
        public Text life_text;
        public Text resurt_text;

        static int enemy_num = 20;
        static int life = 4;

        public static int end = 0; // 1 Áü 2 ½Â¸®

        public void text_print()
        {
            enemy_num_text.text = "X " + enemy_num;
            life_text.text = "X " + life;

            FindObjectOfType<life>().view(life);
        }

        public static int get_life(){ return life; }

        public static void down_life(){ life--; }

        public static void down_enemy(){ enemy_num--; }

        public static int get_end() { return end; }

        void Start()
        {
            enemy_num = 20;
            life = 4;

            text_print();
            resurt_text.text = "";
        }

        void Update()
        {
            if (life < 0)
            {
                resurt_text.text = "Lose";
                end = 1;
            }
            if (enemy_num == 0)
            {
                resurt_text.text = "Win";
                end = 2;
            }

            if(Input.GetKey(KeyCode.Space))
            {
                if(life < 0 || enemy_num == 0)
                    SceneManager.LoadScene("_Complete-Game");
            }
        }
    }
}