using UnityEngine;
using System.Collections;

public class BasePlayerClass {

    private string ClassName;
    private string ClassDescription;
    //STATS
	private int VIT;
    //HP, if it goes 0, the character is wounded and can't fight
	private int END;
    //Used for some abilities
    private int ATK;
    //Damage
    private int DEF;
    //Damage resistance
    private int PRE;
    //Critical chance


    public string CharacterClassName
    {
        get { return ClassName; }
        set { ClassName = value; }
    }
    public string CharacterClassDesc
    {
        get { return ClassDescription; }
        set { ClassDescription = value; }
    }
    public int Vitality
    {
        get { return VIT; }
        set { VIT = value; }
    }
    public int Endurance
    {
        get { return END; }
        set { END = value; }
    }
    public int Attack
    {
        get { return ATK; }
        set { ATK = value; }
    }
    public int Defense
    {
        get { return DEF; }
        set { DEF = value; }
    }
    public int Precision
    {
        get { return PRE; }
        set { PRE = value; }
    }

}
