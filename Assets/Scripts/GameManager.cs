using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;

    int score = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted )
        {
            StartSpawing();
            gameStarted = true;
            tapText.SetActive(false);
        }
    }

    private void StartSpawing() 
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }

    void SpawnBlock() {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range( -maxX, maxX);

        Instantiate(block, spawnPos, Quaternion.identity);
        score++;
        scoreText.text = score.ToString();
    }
}
