using UnityEngine;
using System.Collections;

public class SaveData{

    public static void SaveAllData()
    {
 
        PlayerPrefs.SetString("PLAYERNAME", GameData.PlayerName);
        PlayerPrefs.SetInt("HEALTH", GameData.Vitality);
		PlayerPrefs.SetInt("SPECIAL", GameData.Endurance);
        PlayerPrefs.SetInt("ATTACK", GameData.Attack);
        PlayerPrefs.SetInt("DEFENSE", GameData.Defense);
        PlayerPrefs.SetInt("PRECISION", GameData.Precision);
}
}