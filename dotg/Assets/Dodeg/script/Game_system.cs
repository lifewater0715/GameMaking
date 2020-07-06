using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_system : MonoBehaviour
{
    public Text ScoreUI;
    public Text HighScoreUI;
    public Text RestartUI;
    public player_move Player_Move;
    public List<GameObject> BulletSpwner;

    public bool Playing;
    public float Score;
    public float Top;

    private void Start()
    {
        GameStart();
    }
    public void GameStart()
    {
        Playing = true;
        Score = 0;
        RestartUI.gameObject.SetActive(false);
        Player_Move.gameObject.SetActive(true);
        for (int i = 0; i < BulletSpwner.Count; i++)
        {
            BulletSpwner[i].gameObject.SetActive(true);
        }

    }
    public void Gameover()
    {
        Playing = false;
        RestartUI.gameObject.SetActive(true);
        Player_Move.gameObject.SetActive(false);

        for (int i = 0; i < BulletSpwner.Count; i++)
        {
            BulletSpwner[i].gameObject.SetActive(false);
        }

        Bullet[] bullets = FindObjectsOfType<Bullet>();

        for (int i=0; i<bullets.Length; i++)
        {
            Destroy(bullets[i].gameObject);
        }
        float topScore = PlayerPrefs.GetFloat("TopScore", 0);
        if(topScore < Score)
        {
            topScore = Score;
            Top = Score;
        }
        PlayerPrefs.SetFloat("TopScore", topScore);
        PlayerPrefs.Save();
    }
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            Gameover();
            //player.transform.position = new Vector3(0,0,0);
        }

        if (Playing)
        {
            Score = Score + Time.deltaTime;
            ScoreUI.text = string.Format("Score : {0}", Score);
            //HighScoreUI.text = string.Format("HighScore : {0}", Top);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                GameStart();
            }
        }
    }
}
