using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SceneCharacterActivator : MonoBehaviour
{
    public GameObject characterPizza;
    public GameObject characterAdventurer;
    public GameObject characterAstronaut;
    public GameObject characterPirate;
    public CinemachineFreeLook cam;

    // Start is called before the first frame update
    void Start()
    {
        //get global config
        string sceneCharacter = ConfigStatic.SceneCharacter;

        //reset scene character
        characterPizza.SetActive(false);
        characterAstronaut.SetActive(false);
        characterAdventurer.SetActive(false);
        characterPirate.SetActive(false);

        float theSpeed = ConfigStatic.SceneCharacterSpeed * 4;
        float theJump = ConfigStatic.SceneCharacterJump * 20;

        switch (sceneCharacter) {
            case "pizza":
                SetCharacter(characterPizza, theSpeed, theJump);
                break;
            case "astronaut":
                SetCharacter(characterAstronaut, theSpeed, theJump);
                break;
            case "adventurer":
                SetCharacter(characterAdventurer, theSpeed, theJump);
                break;
            case "pirate":
                SetCharacter(characterPirate, theSpeed, theJump);
                break;
        }
    }

    public void SetCharacter(GameObject character, float speed, float jump) {
        character.SetActive(true);
        character.GetComponent<Unity.LEGO.Minifig.MinifigController>().maxForwardSpeed = speed;
        character.GetComponent<Unity.LEGO.Minifig.MinifigController>().jumpSpeed = jump;
        character.GetComponent<Unity.LEGO.Minifig.MinifigController>().acceleration = speed * 4; 
        cam.m_Follow = character.transform;
        cam.m_LookAt = character.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
