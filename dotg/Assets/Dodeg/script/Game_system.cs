using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_system : MonoBehaviour
{
    public Text ScoreUI;
    public Text RestartUI;

    public player_move Player_Move;
    public List<GameObject> BulletSpwner;

    public bool Playing;
    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        //GameStart;
    }

    // Update is called once per frame
    void Update()
    {
        if(Playing)
        {
            Score = Score + Time.deltaTime;
            ScoreUI.text = string.Format("Score : {0}", Score);
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                //GameStart;
            }
        }
        
    }
}
