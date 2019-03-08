using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class ScoreSaver {

    public static void SaveData(WordManager pData)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gamePlayer.ladyMalva";

        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(pData);

        formatter.Serialize(stream, data);
        stream.Close(); 

    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "gamePlayer.ladyMalva";
        if (File.Exists(path))
        {
            BinaryFormatter bFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData pData = (PlayerData)bFormatter.Deserialize(stream);
            stream.Close();
            return pData;
        }
        else
        {
            Debug.LogError("No hay archivo pa cargar po lonyi pollo");
            return null;
        }
    }

}
