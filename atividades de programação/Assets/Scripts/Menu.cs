using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    
    public void StartGame() {
        SceneManager.LoadScene(1);
    }

    public void Cansei()
    {
        SceneManager.LoadScene(0);
    }

    public void Activeconfig(GameObject config){

        config.SetActive(true);
    }

    public void Desactiveconfig(GameObject config)
    {

        config.SetActive(false);
    }


    public void Activepause(GameObject pause)
    {
        pause.SetActive(true);
        Time.timeScale = 0;

    }

    public void Desactivepause(GameObject pause)
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        

    }
}
