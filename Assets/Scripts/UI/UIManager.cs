using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public enum GAME_SCREEN
{
	SPLASH_SCREEN,
	UPGRADE_SCREEN,
	PAUSE_SCREEN,
	CREDITS,
	OPTIONS,
	STATS,
	GAMEOVER_SCREEN,
	DIED,
	QUIT,
	LOADING,
	NONE
}

public class UIManager : MonoBehaviour {

	public GameManager gm;
	Dictionary<string, GameObject> _resources;
	List<GameObject> _screens;
	GAME_SCREEN currGameScreen;
	List<Button> buttons; 
	Queue _flowQueue;
	bool paused = false;
	int pausedCounter = 0;
    public bool died;
    public bool gameOver;
    public bool restart;
    public bool credits;

	// Use this for initialization
	void Start () {
		gm = (GameManager)GameObject.Find ("GameManager").GetComponent (typeof(GameManager));
		_resources = new Dictionary<string, GameObject>();
		_screens = new List<GameObject>();
		buttons = new List<Button> ();
		currGameScreen = GAME_SCREEN.SPLASH_SCREEN;
		loadResources ();
		_flowQueue = new Queue();
		DoFlowEvent (GAME_SCREEN.SPLASH_SCREEN);
        restart = false;
        credits = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)){
			if(pausedCounter == 0){
				DoFlowEvent (GAME_SCREEN.PAUSE_SCREEN);
				pausedCounter++;
			}
		}

        if (died == true)
        {
            changeScreenTo("DeadScreen");
            GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.Find("PlayerRespawnPosition").transform.position;
            died = false;
        }

        if (gameOver == true)
        {
            changeScreenTo("GameOverScreen");
            gameOver = false;
        }

        if (restart == true)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().currentLives = 3;
            changeScreenTo("SplashScreen");
            restart = false;
        }

        if (credits == true)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().currentLives = 3;
            changeScreenTo("CreditsScreen");
            credits = false;
        }

		//Clear flow queue
		while (_flowQueue.Count > 0)
		{
			switch ((GAME_SCREEN) _flowQueue.Dequeue())
			{
				case GAME_SCREEN.SPLASH_SCREEN:
					changeScreenTo("SplashScreen");
                    paused = true;
					break;
				case GAME_SCREEN.PAUSE_SCREEN:
					changeScreenTo("PauseScreen");
                    paused = true;
					break;
				case GAME_SCREEN.DIED:
					changeScreenTo("DeadScreen");
                    paused = true;
					break;
				case GAME_SCREEN.CREDITS:
					changeScreenTo("Credits");
                    paused = false;
					break;
				case GAME_SCREEN.LOADING:
					changeScreenTo("Loading");
                    paused = false;
					break;
				case GAME_SCREEN.GAMEOVER_SCREEN:
					changeScreenTo("GameOverScreen");
                    paused = true;
					break;
				case GAME_SCREEN.QUIT:
					Application.Quit();
					break;
				case GAME_SCREEN.NONE:
					changeScreenTo("None");
                    paused = false;
					break;
			default:
				break;
			}
		}

		//remove any closed screens
		int tI = _screens.Count;
		while (--tI >= 0)
		{
			if (_screens[tI].GetComponent<ScreenBase>().isClosed())
			{
				Destroy(_screens[tI]);
				_screens.RemoveAt(tI);
			}
		}
	}

	//gets the gameObject attached to the resource
	public GameObject getResource(string name)
	{
		return _resources[name];
	}

	//changes game screen
	public void DoFlowEvent(GAME_SCREEN f)
	{
		_flowQueue.Enqueue(f);
	}
	
	//loads the screen prefabs/anything else we may need for UI
	void loadResources()
	{
		//Add prefabs here
		_resources.Add ("SplashScreen", Resources.Load<GameObject> ("Screens/SplashScreen"));
		_resources.Add ("PauseScreen", Resources.Load<GameObject> ("Screens/PauseScreen"));
		_resources.Add ("GameOverScreen", Resources.Load<GameObject> ("Screens/GameOverScreen"));
		_resources.Add ("DeadScreen", Resources.Load<GameObject> ("Screens/DeadScreen"));
		_resources.Add ("None", Resources.Load<GameObject> ("Screens/None"));
		_resources.Add ("Credits", Resources.Load<GameObject> ("Screens/Credits"));
		_resources.Add ("Loading", Resources.Load<GameObject> ("Screens/Loading"));
	}

	 void openScreen(string name)
	{
		GameObject canvas = GameObject.Find("UIManager");
		
		GameObject newScreen = Instantiate(_resources[name]);
		RectTransform t = newScreen.GetComponent<RectTransform>();
		t.SetParent(canvas.transform, false);
		newScreen.GetComponent<ScreenBase>().OpenScreen();
		_screens.Add(newScreen);
	}
	
	void changeScreenTo(string name)
	{
		foreach (GameObject s in _screens)
		{
			ScreenBase screen = s.GetComponent<ScreenBase>();
			if (screen.isOpen())
			{
				screen.CloseScreen();
			}
		}
		
		
		openScreen(name);
	}
	
	 void closeScreen(string name)
	{
		foreach (GameObject s in _screens)
		{
			if (s.name == name + "(Clone)")
			{
				_screens.Remove(s);
				Destroy(s);
				break;
			}
		}
	}

	public void changeScreenName(string name){
		if (name == "splash") {
			currGameScreen = GAME_SCREEN.SPLASH_SCREEN;
		} else if (name == "pause") {
			currGameScreen = GAME_SCREEN.PAUSE_SCREEN;
		}else if (name == "died") {
			currGameScreen = GAME_SCREEN.DIED;
		}else if (name == "over") {
			currGameScreen = GAME_SCREEN.GAMEOVER_SCREEN;
		}else if (name == "credits") {
			currGameScreen = GAME_SCREEN.CREDITS;
		}else if (name == "none") {
			currGameScreen = GAME_SCREEN.NONE;
		}
	}

	public void resetPausedCounter(){
		pausedCounter = 0;
	}

	public GAME_SCREEN GetCurrGameScreen(){
		return currGameScreen;
	}

    public bool GetPaused()
    {
        return paused;
    }
}
