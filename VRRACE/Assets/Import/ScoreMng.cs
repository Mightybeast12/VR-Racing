using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreMng : MonoBehaviour
{
    public GameObject Player1;
  

    public int Score;


    public int Lives;



    [SerializeField] public GameObject MenuGameOver;

    public Text TXTLVES;
    public Text ScoreTXT;
    public Text FinalScoreTXT;
    private bool DEAD;
 

    void Start()
    {
        DEAD = false;
             UpdateMyUI();
    }
     
    public void UpdateMyUI()
    {

        if (TXTLVES != null) TXTLVES.GetComponent<UnityEngine.UI.Text>().text = Lives.ToString("D6");
        if (ScoreTXT != null) ScoreTXT.GetComponent<UnityEngine.UI.Text>().text = Score.ToString("D6");
        if (FinalScoreTXT != null) FinalScoreTXT.GetComponent<UnityEngine.UI.Text>().text = Score.ToString("D6");

      
    }

    public void AddScore(int player, int score)
    {
        if (player == 1)
        {
            if (DEAD == false)
            {
                Score += score;
                UpdateMyUI();
            }
        }

         }


    public void GameOver(int player)
    {
        DEAD = true;
        StartCoroutine(SetMenuGameOver(player));
    }

    private IEnumerator SetMenuGameOver(int player)
    {
        SetRecord(player);
        MenuGameOver.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");

    }
    void SetRecord(int player)
    {
        var GetBest = PlayerPrefs.GetInt("Record");
        if (player == 1)
        { 
            if (GetBest < Score) PlayerPrefs.SetInt("Record", Score);
        }
        }


    #region "Pause Game"
    public void ShowMenuMusic()
    {
        PauseGame();
    }

    public void HideMenuMusic()
    {
        ContinueGame();
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void PlayGame()
    {
        Score = 0;
        Lives = 5;
        Time.timeScale = 1;
    }

    private void ContinueGame()
    {
        Time.timeScale = 1;
    }
    #endregion


}
