using UnityEngine;
using System.Collections;

public class LoadData : MonoBehaviour {

    public static void LoadAllData()
    {
        GameData.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameData.Vitality = PlayerPrefs.GetInt("HEALTH");
		GameData.Endurance = PlayerPrefs.GetInt("STAMINA");
        GameData.Attack = PlayerPrefs.GetInt("ATTACK");
        GameData.Defense = PlayerPrefs.GetInt("DEFENSE");
        GameData.Precision = PlayerPrefs.GetInt("PRECISION");
	

    }

}
