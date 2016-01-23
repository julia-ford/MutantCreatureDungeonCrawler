using UnityEngine;
using System.Collections;

public class God : MonoBehaviour {

	private Card myCard;

	// Use this for initialization
	void Start () {
		this.myCard = new Card (Card.CardType.Curse, 4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 150, 100), Time.time + "")) {
			this.myCard.Show();
		}
	}
}
