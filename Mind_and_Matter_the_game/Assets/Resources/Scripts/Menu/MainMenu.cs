using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CardRef;

public class MainMenu : MonoBehaviour
{
    //To see the list of possible scenes, look at File/build settings!
    enum Scene : int
    {
        Deckbuilder,
        Mainmenu,
        GameView
    };

   public void PressPlay()
    {
        SceneManager.LoadScene((int) Scene.GameView);
    }

    public void PressDeckBuilder()
    {
        SceneManager.LoadScene((int) Scene.Deckbuilder);
    }

    public void PressQuit()
    {
        Application.Quit();
    }
}
