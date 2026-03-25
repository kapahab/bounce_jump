using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    void Awake()
    {
        score = 0;
        Time.timeScale = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void LoseGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
