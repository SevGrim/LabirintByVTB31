using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public static int currentScore;
	public static  int highscore;

	public static int currentLevel=0;
	public static int unlockedLevel;

	public static void CompleteLevel()
	{
		if (currentLevel < 3) {
						currentLevel += 1;
						Application.LoadLevel (currentLevel);
				} 
		else 
		{
			print("You win!");
		}
		 
	}

}
