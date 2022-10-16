using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject playerUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClick()
    {
        SceneManager.LoadScene("MapSelection");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
        
    }

    public void Map01()
    {
        SceneManager.LoadScene("Map01");
        
    }

    public void Map02()
    {
        SceneManager.LoadScene("Map02");
       
    }

    public void Map03()
    {
        SceneManager.LoadScene("Map03");
        
    }

    public void Map04()
    {
        SceneManager.LoadScene("Map04");
       
    }

    public void GarageOption()
    {
        SceneManager.LoadScene("Garage Scene 1");

    }

    public void PauseMenu()
    {
        playerUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        playerUI.SetActive(true);

    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Garage Scene 1");
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
