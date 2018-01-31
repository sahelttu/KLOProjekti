using UnityEngine;
using System.Collections;

public class BaseOrigin{

	private string OriginName;
	private string OriginDescription;

	public string CharacterOriginName
	{
		get{return OriginName; }
		set{ OriginName = value; }
	}
	public string CharacterOriginDescription
	{
		get{return OriginDescription; }
		set{OriginDescription = value; }
	}

}
	