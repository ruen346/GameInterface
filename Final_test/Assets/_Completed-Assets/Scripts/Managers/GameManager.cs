using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Complete
{
    public class GameManager : MonoBehaviour
    {
        public AudioClip background_music;
        public AudioClip lose_music;
        public AudioClip win_music;

        private AudioSource audioSource;


        int a = -1;
        public Text enemy_num_text;
        public Text enemy_num_text2;
        public Text life_text;
        public Text resurt_text;

        static int enemy_num = 20;
        static int life = 4;

        public static int end = 0; // 1 Áü 2 ½Â¸®

        public void text_print()
        {
            enemy_num_text.text = "X " + enemy_num;
            enemy_num_text2.text = "X " + enemy_num;
            life_text.text = "X " + life;

            FindObjectOfType<life>().view(life);
        }

        public static int get_life(){ return life; }

        public static void down_life(){ life--; }

        public static void down_enemy(){ enemy_num--; }

        public static int get_end() { return end; }

        void Start()
        {
            audioSource = GetComponent<AudioSource>();

            enemy_num = 20;
            life = 0;
            a = -1;
            end = 0;

            text_print();
            resurt_text.text = "";
        }

        void Update()
        {
            if (life < 0 && end == 0)
            {
                resurt_text.text = "Lose";
                end = 1;
                FindObjectOfType<happy>().get_end(end);
                FindObjectOfType<dark>().dark_view();
                FindObjectOfType<color>().enemy();

                FindObjectOfType<Enemy>().no();

                audioSource.clip = lose_music;
                audioSource.Play();

                a = 35;
            }
            if (enemy_num == 0 && end == 0)
            {
                resurt_text.text = "Win";
                end = 2;
                FindObjectOfType<happy>().get_end(end);
                FindObjectOfType<dark>().dark_view();
                FindObjectOfType<color>().character();

                audioSource.clip = win_music;
                audioSource.Play();

                a = 35;
            }

            if(Input.GetKey(KeyCode.Space))
            {
                if(life < 0 || enemy_num == 0)
                    SceneManager.LoadScene("_Complete-Game");
            }

            if(a > 0)
            {
                a--;
            }
            if(a == 0)
            {
                FindObjectOfType<fuck>().move();
                a--;
            }
        }
    }
}