using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    public static BestScoreManager Instance;
    public Text BestScoreText;

    private int bestScore = 0;
    private string bestScorePlayerName;
    private string playerName;

    // Start is called before the first frame update
     private void Awake(){
        if (Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData{
        public int bestScore;
        public string bestScorePlayerName;
        public string playerName;
    }

    public void UpdateBestScore(int score){
        if (score > bestScore){
            bestScore = score;
            bestScorePlayerName = playerName;
        } 
        BestScoreText.text = $"Best Score : {bestScorePlayerName} : {bestScore}";
    }

    public void setPlayerName(string nameInput){
        playerName = nameInput;
    }

}
