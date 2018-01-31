using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	public static bool isMale { get; set;}
    public static string PlayerName { get; set; }
	public static BaseOrigin PlayerOrigin { get; set; }
    public static BasePlayerClass PlayerClass { get; set; }
    public static int Vitality { get; set; }
    public static int Endurance { get; set; }
    public static int Attack { get; set; }
    public static int Defense { get; set; }
    public static int Precision { get; set; }


}
