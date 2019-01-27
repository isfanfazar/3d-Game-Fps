using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogin : MonoBehaviour {

	public GameObject menuPanel;
	public GameObject howToPanel;
	public GameObject creditPanel;
	
	// Use this for initialization
	void Start () {
		menuPanel.SetActive(true);
		howToPanel.SetActive(false);
		creditPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void StartGameClicked(){
		Application.LoadLevel(1);
	}
	
	public void HowToClicked(){
		howToPanel.SetActive(true);
		creditPanel.SetActive(false);
		menuPanel.SetActive(false);
	}
	
	public void CreditClicked(){
		creditPanel.SetActive(true);
		menuPanel.SetActive(false);
		howToPanel.SetActive(false);
	}
	
	public void QuitGameClick(){
		Application.Quit();
	}
	
	public void BackToMenuClicked(){
		menuPanel.SetActive(true);
		howToPanel.SetActive(false);
		creditPanel.SetActive(false);
	}
}
