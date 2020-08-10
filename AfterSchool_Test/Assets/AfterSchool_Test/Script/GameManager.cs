using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public Text LiefText;

    public GameObject GameOverText;
    public GameObject BlockSpwaner;

    public static GameManager Instance;

    public float Life=100;
    public float Score=0;

    public bool Playing;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        Playing = true;
    }
    void Update()
    {
        LiefText.text = string.Format("Life : {0}", Life);
        ScoreText.text = string.Format("Score : {0}", Score);

        if(Life<=0)
        {
            Playing = false;
        }

        if(Playing==false)
        {
            BlockSpwaner.SetActive(false);
            GameOverText.SetActive(true);
            Input.GetKey(KeyCode.R);
            {
                Playing = true;
            }

        }
        else
        {
            GameOverText.SetActive(false);
            BlockSpwaner.SetActive(true);
        }
    }
}
