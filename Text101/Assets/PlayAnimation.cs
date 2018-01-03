using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour {

	public Button play;
	public Animator animator1;
	public Animator animator2;
	//public Animation anim1;
	//public Animation anim2;

	//public GameObject pikachu;
	//public GameObject bulbasaur;

	//public GameObject tp;

	public bool play1;
	// Use this for initialization
	void Start () {
		//pikachu.GetComponent<Animation> ().Play ();
		play.onClick.AddListener (playAnimation);
	}

	void playAnimation () {

		//Debug.Log ("try");
		//tp.GetComponent<Animation> ().Play ("try");
		while (true) {
			if (play1) {
				animator1.Play ("shrink");
				play1 = false;
				/*if (!animator1.GetCurrentAnimatorStateInfo (0).IsName ("New State")) {
					play1 = false;
					}*/
			} else {
				animator2.Play ("grow");
				break;
			}
		}
		//pikachu.GetComponent<Animation> ().Play ();
		//bulbasaur.GetComponent<Animation> ().Play ();

		/*while (true) {
			if (play1) {
				pikachu.GetComponent<Animation> ().Play ();
				if (!pikachu.GetComponent<Animation> ().IsPlaying("shrink")) {
					play1 = false;
				}
			} else {
				bulbasaur.GetComponent<Animation> ().Play ();
				break;
			}
		}*/
	}

	// Update is called once per frame
	void Update () {
		
	}
}
