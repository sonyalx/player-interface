using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player Interface : MonoBehaviour
{ 
   public Text scoreText;
   public Slider healthSlider;
   public Image gameOverBackground;
   public Text gameOverText;

   private int score;
   private int maxHealth;
   private int currentHealth;

   private void Start()
{
    score = 0;
    maxHealth = 100;
    currentHealth = maxHealth;

    UpdateScoreText();
    UpdateHealthSlider();
    HideGameOver();
}
public void AddScore(int points)
{
    score += points;
    UpdateScoreText();
}

public void TakeDamage(int damageAmount)
{
    currentHealth -= damageAmount;
    if (currentHealth <= 0)
    {
        currentHealth = 0;
        GameOver();
    }
    UpdateHealthSlider();
}

private void UpdateScoreText()
{
    scoreText.text = "Score: " + score.ToString();
}

private void UpdateHealthSlider()
{
    healthSlider.value = currentHealth;
    healthSlider.maxValue = maxHealth;
}

private void GameOver()
{
    gameOverBackground.gameObject.SetActive(true);
    gameOverText.text = "Game Over";
}

private void HideGameOver()
{
    gameOverBackground.gameObject.SetActive(false);
    gameOverText.text = string.Empty;
}
}


