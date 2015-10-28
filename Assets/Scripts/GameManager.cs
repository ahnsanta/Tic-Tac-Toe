using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private bool turn;
	public Text t1;
	public Text t2;
	public Text t3;
	public Text t4;
	public Text t5;
	public Text t6;
	public Text t7;
	public Text t8;
	public Text t9;

	public Button b1;
	public Button b2;
	public Button b3;
	public Button b4;
	public Button b5;
	public Button b6;
	public Button b7;
	public Button b8;
	public Button b9;

	public GameObject loadingImageXwin;
	public GameObject loadingImageOwin;
	public GameObject loadingImageDrawn;

	public int s;


	
	// Use this for initialization
	void Start () {
		turn = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (t1.text == "X" && t4.text == "X" && t7.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t2.text == "X" && t5.text == "X" && t8.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t3.text == "X" && t6.text == "X" && t9.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t1.text == "X" && t2.text == "X" && t3.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t4.text == "X" && t5.text == "X" && t6.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t7.text == "X" && t8.text == "X" && t9.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t1.text == "X" && t5.text == "X" && t9.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t3.text == "X" && t5.text == "X" && t7.text == "X") {
			loadingImageXwin.SetActive(true);
			Debug.Log ("X win");
		} else if (t1.text == "O" && t4.text == "O" && t7.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t2.text == "O" && t5.text == "O" && t8.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t3.text == "O" && t6.text == "O" && t9.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t1.text == "O" && t2.text == "O" && t3.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t4.text == "O" && t5.text == "O" && t6.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t7.text == "O" && t8.text == "O" && t9.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t1.text == "O" && t5.text == "O" && t9.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (t3.text == "O" && t5.text == "O" && t7.text == "O") {
			loadingImageOwin.SetActive(true);
			Debug.Log ("O win");
		} else if (s == 9){

			Debug.Log ("Drawn");
			loadingImageDrawn.SetActive(true);

		}

	}

	public void Frist(){
		if (turn) {
			t1.text = "X";
			turn = false;

		} else {
			t1.text = "O";
				turn = true ;
		}
		b1.enabled = false;
		s+=1;
	}

	public void Second(){
		if (turn) {
			t2.text = "X";
			turn = false;
		} else {
			t2.text = "O";
			turn = true ;
		}
		b2.enabled = false;
		s+=1;
	}

	public void Third(){
		if (turn) {
			t3.text = "X";
			turn = false;
		} else {
			t3.text = "O";
			turn = true ;
		}
		b3.enabled = false;
		s+=1;
	}

	public void Fourth(){
		if (turn) {
			t4.text = "X";
			turn = false;
		} else {
			t4.text = "O";
			turn = true ;
		}
		b4.enabled = false;
		s+=1;
	}

	public void Fift(){
		if (turn) {
			t5.text = "X";
			turn = false;
		} else {
			t5.text = "O";
			turn = true ;
		}
		b5.enabled = false;
		s+=1;
	}

	public void Sixth(){
		if (turn) {
			t6.text = "X";
			turn = false;
		} else {
			t6.text = "O";
			turn = true ;
		}
		b6.enabled = false;
		s+=1;
	}

	public void Seventh(){
		if (turn) {
			t7.text = "X";
			turn = false;
		} else {
			t7.text = "O";
			turn = true ;
		}
		b7.enabled = false;
		s+=1;
	}
	public void Eighth(){
		if (turn) {
			t8.text = "X";
			turn = false;
		} else {
			t8.text = "O";
			turn = true ;
		}
		b8.enabled = false;
		s+=1;
	}

	public void Ninth(){
		if (turn) {
			t9.text = "X";
			turn = false;
		} else {
			t9.text = "O";
			turn = true ;
		}
		b9.enabled = false;
		s+=1;
	}

	public void Onstart(string name){
		Application.LoadLevel (Application.loadedLevel);
	}


}

