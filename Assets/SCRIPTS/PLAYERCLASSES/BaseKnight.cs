using UnityEngine;
using System.Collections;

public class BaseKnight : BasePlayerClass {

    public BaseKnight()
    {
        CharacterClassName = "Knight";
        CharacterClassDesc = "The Knights are unyielding fighters\nwho swear to protect their\nallies. With a heavy armor and\na shield, the Knights can withstand\nmore damage than the other classes.";
		Vitality = 10;
		Endurance = 5;
        Attack = 5;
        Defense = 9;
        Precision = 5;
        
    }
}

