using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
//using UnityEditor.Experimental.RestService;

public class SaveSystem 
{
   public static void SavePlayer (Health health)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);


        PlayerSave data = new PlayerSave(health);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerSave LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSave data = formatter.Deserialize(stream) as PlayerSave;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
