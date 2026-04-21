using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public TMP_Text scoreText;
    public float worldScrollingSpeed = 7;

    float score = 0;

    private void Update()
    {
        score += Time.deltaTime * worldScrollingSpeed;
        scoreText.text = score.ToString("f0");
    }
}
