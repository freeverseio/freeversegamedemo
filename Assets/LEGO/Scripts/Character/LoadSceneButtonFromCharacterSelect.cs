using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this class handles stuff when user selects Play from character menu
public class LoadSceneButtonFromCharacterSelect : MonoBehaviour
{

    public void LoadScene()
    {
        //get displayed character - this component contains all the info
        CharacterDisplay cd = GetComponentInParent<CharacterDisplay>();

        //get jump and speed stats and pass to game config
        ConfigStatic.SceneCharacterSpeed = float.Parse(cd.m_speed);
        ConfigStatic.SceneCharacterJump = float.Parse(cd.m_jump);

        // get character style
        switch(cd.m_characterStyle) {
            case CharacterStyle.Pizza:
                ConfigStatic.SceneCharacter = "pizza";
                break;
            case CharacterStyle.Astronaut:
                ConfigStatic.SceneCharacter = "astronaut";
                break;
                case CharacterStyle.Pirate:
                ConfigStatic.SceneCharacter = "pirate";
                break;
                case CharacterStyle.Adventurer:
                ConfigStatic.SceneCharacter = "adventurer";
                break;
        }

        SceneManager.LoadScene("LEGO Tutorial");
    }

    public void LoadMenu() {
        SceneManager.LoadScene("Menu Intro");
    }

    public void GoToSellURL() {

        CharacterDisplay cd = GetComponentInParent<CharacterDisplay>();

        Application.OpenURL("https://demo.games.gorengine.com/asset/" + cd.m_id);
    }

    public void GoToLoginURL() {

        Application.OpenURL("https://demo.games.gorengine.com/");
    }

    public void GoToMarketURL() {

        Application.OpenURL("https://demo.games.gorengine.com/drops");
    }

}
