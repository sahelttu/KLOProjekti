using UnityEngine;
using System.Collections;

public class BaseWarrior : BasePlayerClass {

    public BaseWarrior()
    {
        CharacterClassName = "Warrior";
        CharacterClassDesc = "The Warriors of Mt. Coldabove are\nproud of their power and large\nmuscles. With a trusty battleaxe\nat their side, the Warriors can\nstrike down anything in one swing.\nOr at least hurt them badly.";
        Vitality = 4;
        Endurance = 5;
        Attack = 10;
        Defense = 5;
        Precision = 7; 

    }

}
