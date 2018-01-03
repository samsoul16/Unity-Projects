using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

	public Light redglow;
	float highlight;
	enum glowanim { FADEIN, FADEOUT};
	glowanim glowtype = glowanim.FADEIN;

	// Use this for initialization
	void Start () {
		highlight = 1.0f;
		InvokeRepeating("ChangeGlow", 0.1f, 0.1f);
		// 0.1 is the start time & 0.5 is the delay
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ChangeGlow (){
		switch(glowtype)
		{
		case glowanim.FADEOUT: 
			highlight= highlight - 0.1f;
			break;
		case glowanim.FADEIN:
			highlight = highlight + 0.1f;
			break;
		default:
			Debug.Log("WRONG GLOW TYPE");
			break;
		}
		redglow.intensity = highlight;
		if (highlight < 0.5f) {
			glowtype = glowanim.FADEIN;
		} else if (highlight > 1.0f) {
			glowtype = glowanim.FADEOUT;
		}
	}


}
