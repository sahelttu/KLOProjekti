using UnityEngine;
using System.Collections;

public class BaseMage: BasePlayerClass {

    public BaseMage()
    {
        CharacterClassName = "Mage";
        CharacterClassDesc = "The Mages of Warmcoast Isles use \nMana to from underground leylines\nto sharpen their senses and cast\npowerful spells. The Mages usually\ncarry staves and wands to amplify\ntheir spells.";
		Vitality = 4;
		Endurance = 7;
        Attack = 8;
        Defense = 3;
        Precision = 3;

    }

}
