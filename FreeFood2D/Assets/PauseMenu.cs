// by @torahhorse

// Instructions:
// this is a pause menu for your drifting game
// it has options for field of view, invert y axis, and mouse sensitivity
// it also saves those values.
// To use it just put the script on something and change the styles in the inspector.
// the Menu prefab comes with an already defined style

// note: you're meant to use this as a starting point / debug. i dont wanna see this vanilla Arial stuff in yr games

using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
	public static bool paused = false;
	

	public GUIStyle pauseMenuStyle;
	public GUIStyle bgStyle;
	public GUIStyle scrollBarStyle;
	public GUIStyle scrollButtonStyle;
	
	private int littleButtonWidth;
	private int littleButtonHeight;
	private int buttonWidth;
	private int buttonHeight;
	private int sliderWidth;
	private int sliderHeight;
	
	private int fontSize;
	
	private bool mouseSettings = false;
	private bool quitDialog = false;
	
	
	// Use this for initialization
	void Start ()
	{
		//set button dimensions
		SetButtonDimensions();
		// just making this shit up
		fontSize = (int)(Screen.width / 24.4f);
	
		pauseMenuStyle.fontSize = fontSize;
	
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		if( Input.GetKeyDown(KeyCode.Escape) )
		{
			PauseGame();
		}
	}
	
	void OnGUI()
	{
		if( paused )
		{
			
			if( !mouseSettings && !quitDialog)
			{
				DrawPauseMenuBG();
				
				// Resume game button
				if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, buttonHeight, buttonWidth, buttonHeight), "Resume", pauseMenuStyle))
				{
					PauseGame();
				}
				
				// Reset level button
				if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, buttonHeight*2, buttonWidth, buttonHeight), "Reset Level", pauseMenuStyle))
				{
					print("Restart");
					PauseGame();
					Application.LoadLevel(Application.loadedLevel);
				}
				
				// Quit button
				if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, buttonHeight*4, buttonWidth, buttonHeight), "Quit Game", pauseMenuStyle))
				{
					quitDialog = true;
				}
			}
			else if( mouseSettings)
			{
				DrawPauseMenuBG();
				
				// BACK button
				if( GUI.Button(new Rect(littleButtonWidth/2, 0, littleButtonWidth, littleButtonHeight), "Back", pauseMenuStyle) )
				{
					mouseSettings = false;
				}
				
				
			}
			else if( quitDialog )
			{
				DrawPauseMenuBG();
				// Are you sure label
				GUI.Label(new Rect( Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight, buttonWidth, buttonHeight), "Are you sure?", pauseMenuStyle);
			
				// yes
				if( GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, Screen.height/2, buttonWidth, buttonHeight), "Yes", pauseMenuStyle) )
				{
					Application.Quit();
				}
				// no
				if( GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 + buttonHeight, buttonWidth, buttonHeight), "No", pauseMenuStyle) )
				{
					quitDialog = false;
				}
			}
		}
	}
	
	
	
	
	
	
	
	// toggle pause state
	public void PauseGame()
	{
		paused = !paused;
		Time.timeScale = 1.0f - Time.timeScale;
		
		// pause or unpause the music
		if( paused )
		{
			print("Game Paused");
		}
		else
		{
			print("Game Resumed");
		}
	}
	
	void DrawPauseMenuBG()
	{
		// Make a background box
		GUI.Box(new Rect(-10, -10, Screen.width + 20, Screen.height + 20), "", bgStyle);
	}
	
	
	
	
	void SetButtonDimensions()
	{
		littleButtonWidth = Screen.width / 12;
		littleButtonHeight = Screen.height / 8;
		buttonWidth = Screen.width / 2;
		buttonHeight = Screen.height / 6;
		sliderWidth = Screen.width / 6;
		sliderHeight = Screen.height / 12;
	}
}
