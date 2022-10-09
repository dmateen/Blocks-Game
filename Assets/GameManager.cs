using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject GameWonPanel;
    public static GameManager instance;
    // Start is called before the first frame update

    void Awake(){
        instance=this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        print("Game End");
        GameOverPanel.SetActive(true);
    }

    public void GameWon()
    {
        print("YOU WON!");
        GameWonPanel.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale=1;
        GameOverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
