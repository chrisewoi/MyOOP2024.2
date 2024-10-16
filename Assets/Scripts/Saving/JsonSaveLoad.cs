using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public static class JsonSaveLoad
{
    public static string file = Application.dataPath + "/save.json";

    public static void Save(GameData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(file, json);
    }

    public static GameData Load()
    {
        if (File.Exists(file))
        {
            string json = File.ReadAllText(file);
            return JsonUtility.FromJson<GameData>(json);
        }

        return null;
    }
}
