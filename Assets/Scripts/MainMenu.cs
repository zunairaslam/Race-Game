using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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


}
