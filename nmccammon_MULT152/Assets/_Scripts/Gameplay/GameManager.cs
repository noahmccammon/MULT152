using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameTime = 60;
    [SerializeField] private RestartUI restartUI;
    float totalTimeElapsed = 0;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
            return;
        totalTimeElapsed += Time.deltaTime;
        gameTime -= Time.deltaTime;

        if (gameTime <= 0)
            isGameOver = true;
    }

    public void AdjustTime(float amount)
    {
        gameTime += amount;

    }

    void OnGUI()
    {
        if (!isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            GUI.Box(boxRect, "Time Remaining");

            Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(labelRect, ((int)gameTime).ToString());
        }
        else
        {
            Time.timeScale = 0f;            // pause world
            if (restartUI) restartUI.ShowPanel();
            else Debug.LogWarning("[HealthComponent] Died but RestartUI not found.");
        }
    }

}
