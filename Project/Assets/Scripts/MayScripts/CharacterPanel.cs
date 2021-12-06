using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject characterPanel;
    public Text characterText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (characterText.text == "")
        {
            Debug.Log("Empty Character");
            characterPanel.SetActive(false);
        }
        else
        { 
            Debug.Log("Character Active");
            characterPanel.SetActive(true);
        }
    }
}
