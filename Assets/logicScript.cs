using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
   public int  playersScore = 0;
   public Text scoreText;
   public GameObject gameOverScreen; 

    [ContextMenu("Increase Score")]
   public void addScore()
   {
     playersScore = playersScore +1;
     scoreText.text = playersScore.ToString();
   }

   public void restartGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver(){
        gameOverScreen.SetActive(true);
   }
}
