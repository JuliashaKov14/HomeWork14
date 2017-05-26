using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject Pause_panel = null;
    public GameObject SubPanel = null;
	public bool _PanelForAboutOpened = false;

    public void Settings()
	{
		
	}

	public void GamePlay()
	{
		SceneManager.LoadScene ("Game Scena");
	}

	public void ToggleSubPanelOpen()
	{
        if (!GameManagerinstance.IsPaused)
        {
            _PanelForAboutOpened = !_PanelForAboutOpened;
        }
        SetSubPanelVisibility();
    }
	private void SetSubPanelVisibility()
    {
        if (SubPanel != null)
        {
            SubPanel.SetActive(_PanelForAboutOpened);
        }
    }
   private void CloseSubeMenu()
    {
      _PanelForAboutOpened = false;
        SubPanel.SetActive(_PanelForAboutOpened);
    }

    private class GameManagerinstance
    {
        public static bool IsPaused { get; internal set; }
    }
    public void CLOSE()
    {
        _PanelForAboutOpened = false;
        SubPanel.SetActive(_PanelForAboutOpened);
    }
    
    }

