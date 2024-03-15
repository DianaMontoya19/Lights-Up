using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MenuSelectPlayer");
    }
    public void Settings()
    {
        SceneManager.LoadScene("MenuSettings");
    }
    public void Player1()
    {
        SceneManager.LoadScene("Game");
    }
    public void Player2()
    {
        SceneManager.LoadScene("GamePl2");
    }
    public void Return()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    



}
