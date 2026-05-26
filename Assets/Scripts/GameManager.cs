using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public TMP_Text scoreText;
    public TMP_Text coinsText;
    public float worldScrollingSpeed = 7;

    public GameObject gameOverPanel;

    float score = 0;
    int coins = 0;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        coinsText.text = coins.ToString();
    }

    private void Update()
    {
        score += Time.deltaTime * worldScrollingSpeed;
        scoreText.text = score.ToString("f0");
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Debug.Log("Restart!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void AddCoin()
    {
        coins++;
        coinsText.text = coins.ToString();
        PlayerPrefs.SetInt("Coins", coins);
    }

    public bool MagnetActive => magnetActive;
    private bool magnetActive = false;
    public float MagnetRange { get; private set; } = 4;
    public float MagnetDuration { get; private set; } = 4;
    public void ActivateMagnet()
    {
        CancelInvoke(nameof(DeactivateMagnet));
        magnetActive = true;
        Invoke(nameof(DeactivateMagnet), MagnetDuration);
    }

    void DeactivateMagnet()
    {
        magnetActive = false;
    }

    public bool BatteryActive => batteryActive;
    private bool batteryActive = false;
    public float BatteryDuration { get; private set; } = 4;
    public void ActivateBattery()
    {
        CancelInvoke(nameof(DeactivateBattery));
        batteryActive = true;
        Invoke(nameof(DeactivateBattery), BatteryDuration);
    }
    void DeactivateBattery()
    {
        batteryActive = false;
    }
}
