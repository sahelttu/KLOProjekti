using UnityEngine;
using System.Collections;

public class BasePlayer {

    private string playerName;
    private BasePlayerClass playerClass;
	private BaseOrigin playerOrigin;
    private int Vitality;
	private int Endurance; 
    private int Attack;
    private int Defense;
    private int Precision;
	private int statPointsToAlloc;
    //Get/Set

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public BasePlayerClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }
	public  BaseOrigin PlayerOrigin
	{
		get{ return playerOrigin;}
		set{ playerOrigin = value;}
	}	
    public int vitality
    {
		get { return Vitality; }
		set { Vitality = value; }
    }
    public int endurance
    {
		get { return Endurance; }
		set { Endurance = value; }
    }
    public int attack
    {
        get { return Attack; }
        set { Attack = value; }
    }
    public int defense
    {
        get { return Defense; }
        set { Defense = value; }
    }
    public int precision
    {
        get { return Precision; }
        set { Precision = value; }
    }
	public int StatPointsToAlloc
	{
		get { return statPointsToAlloc; }
		set { statPointsToAlloc = value; }
	}
}
