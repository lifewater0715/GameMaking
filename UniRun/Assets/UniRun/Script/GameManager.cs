using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public void Awake()
    {
        if (GameManager.Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public bool m_IsGameover = false;
    public GameObject m_GameoverUI;
    public UnityEngine.UI.Text m_ScoreUI;
    public int m_score = 0;

    public void OnPlayerDead()
    {
        m_IsGameover = true;
        m_GameoverUI.SetActive(true);

        Tile_move[] tile_Moves = FindObjectsOfType<Tile_move>();
        foreach (var tile_move in tile_Moves)
        {
            tile_move.enabled = false;
        }

        FindObjectOfType<Grownd_Maker>().enabled = false;
    }
    public void OnAddScore()
    {
        m_score++;
        m_ScoreUI.text = string.Format("SCORE : {0}" , m_score);
    }
    // Start is called before the first frame update
    void Start()
    {
        m_score++;
        m_ScoreUI.text = string.Format("SCORE : {0}", m_score);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
