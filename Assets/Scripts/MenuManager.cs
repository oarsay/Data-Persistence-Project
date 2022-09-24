using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static string userName = "Player";
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SaveUserName();
        SceneManager.LoadScene(1);
    }

    void SaveUserName()
    {
        if(inputField.text != "")
            userName = inputField.text;
    }
}
