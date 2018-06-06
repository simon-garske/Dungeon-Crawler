using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RätselQuest : MonoBehaviour {

	public int eps = 20;
	private Text messageText;	//uGUI
	private string questMessage = "Hinter dem Gitter ist ein Schein, doch wie komme ich da rein? Irgendwas in diesem Raum muss Gegensetzlich sein.";
	public bool Questfinished = false;
	private string questEndedMessage = "Dieser Behälter eignet sich um Wasser zu trinken." ;
	private GameObject player;
	private PlayerController playerController;
	private EPController epController;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerController = player.GetComponent<PlayerController>();
		messageText = GameObject.FindGameObjectWithTag ("Message").
			GetComponent<Text>();	//uGUI
		epController = GameObject.FindGameObjectWithTag("GameController").
			GetComponent<EPController>();

	}
	
	void OnTriggerEnter(Collider other) 
	{	
		if(other.gameObject == player)
		{
			messageText.text = questMessage;
		}
	}
	
	void OnTriggerExit(Collider other) 
	{	
		if(other.gameObject == player)
		{
			messageText.text = "";
		}
		if(Questfinished == true)
		{
			messageText.text = questEndedMessage;
		}
	}

	void finishQuest()
	{
		Questfinished = true;
	}

}

