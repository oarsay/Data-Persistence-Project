using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    
    public static string highScorePlayerName;
    public static int highScore;

    private class Data
    {
        public int score;
        public string name;
    }

    public static void SaveScore(string playerName, int playerScore)
    {
        Data data = new Data();
        data.score = playerScore;
        data.name = playerName;

        string json = JsonUtility.ToJson(data);
  
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public static void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);

            highScore = data.score;
            highScorePlayerName = data.name;
        }
    }

}
