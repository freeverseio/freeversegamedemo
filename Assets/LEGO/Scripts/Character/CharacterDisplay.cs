using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum CharacterStyle {
    Pizza,
    Astronaut,
    Adventurer,
    Pirate
}

public class CharacterDisplay : MonoBehaviour
{    

    Image m_Image;
    public Sprite m_astro;
    public Sprite m_adventurer;
    public Sprite m_pirate;
    public Sprite m_pizza;
    public TextMeshProUGUI m_TMP_name;
    public TextMeshProUGUI m_TMP_speed;
    public TextMeshProUGUI m_TMP_jump;

    public CharacterStyle m_characterStyle;
    public string m_speed;
    public string m_jump;
    public string m_id;


    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
        //default values
    }

    public void SetCharacter(CharacterStyle new_style, string name, string speed, string jump, string id) {

        
        m_characterStyle = new_style;
        m_speed = speed;
        m_jump = jump;
        m_id = id;

        m_Image = GetComponent<Image>();

        switch (m_characterStyle) {
            case CharacterStyle.Astronaut:
                m_Image.sprite = m_astro;
                break;
            case CharacterStyle.Pizza:
                m_Image.sprite = m_pizza;
                break;
            case CharacterStyle.Pirate:
                m_Image.sprite = m_pirate;
                break;
            case CharacterStyle.Adventurer:
                m_Image.sprite = m_adventurer;
                break;
            default:
                break; 
        } 

        m_TMP_name.SetText(name);
        m_TMP_speed.SetText(speed);
        m_TMP_jump.SetText(jump);

    }
}
