using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// this is a VARIABLE, a piece of data that remembers our "current room" / position in world
	string currentRoom = "intro";

	// Use this for initialization
	void Start () {
		// if you see "//" that's a comment, NOT code that is run
		// all instructions have to go inside functions
		Debug.Log ( "Hello World" );

	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<TextMesh>().text = "";

		// when you use an "if/else" structure, only ONE of those
		// blocks will ever run, it is an either/or scenario!
		if ( currentRoom == "intro" ) {
			GetComponent<TextMesh>().text += "You awaken to a dark, " +
				"\ncold room. The stale air hits " +
				"\nyour lungs like slivers of ice.";
			GetComponent<TextMesh>().text += "\n\n[L] to look around the room.";
			GetComponent<TextMesh>().text += "\nor [S] to go back to sleep.";
		}

		if ( Input.GetKeyDown (KeyCode.L) ) {
			currentRoom = "roomDesc";
		}
		if ( Input.GetKeyDown (KeyCode.S) ) {
			currentRoom = "sleep";
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			currentRoom = "bedDesc";
		}
		if ( Input.GetKeyDown (KeyCode.D) ) {
			currentRoom = "doorDesc";
		}
		if ( Input.GetKeyDown (KeyCode.O) ) {
			currentRoom = "bonesDesc";
		}
		if ( (Input.GetKeyDown (KeyCode.C)) || (Input.GetKeyDown (KeyCode.U)) ) {
			currentRoom = "ceilingDesc";
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			currentRoom = "intro";
		}


		if ( currentRoom == "roomDesc" ) {
			GetComponent<TextMesh>().text += "The [B]ed is hard against" +
				"\nyour back. In the dim light" +
				"\nyou can barely make out the " +
				"\njagged stone walls of a small" +
				"\nroom. A huge steel [D]oor" +
				"\nwaits against the far wall," +
				"\nand b[O]nes litter the floor." +
				"\nFinally, you have an" +
				"\noverwhelming fear of looking" +
				"\n[U]p.";
		} else if ( currentRoom == "sleep" ) {
			GetComponent<TextMesh>().text += "ZZzzZzzzzZzzzzz" +
				"\n\n [I] to wake up";
		} else if ( currentRoom == "bedDesc" ) {
			GetComponent<TextMesh>().text += "Your mattress is less" +
				"\nof a bed, and more of a" +
				"\nstone slab, accented by a" +
				"\nby a thin blanket and a sad" +
				"\nexcuse of a pillow." +
				"\n[L]ook around..." +
				"\nLook at the b[O]nes." +
				"\nLook at the [D]oor" +
				"\nbut for god's sake," +
				"\ndon't look [U]p.";
		} else if ( currentRoom == "doorDesc" ) {
			GetComponent<TextMesh>().text += "The door is enormous" +
				"\nand intimidating. In a room" +
				"\nof otherwise jagged edges," +
				"\nit is smooth and featureless." +
				"\nFeatureless, that is, except" +
				"\nfor the large keyhole and the" +
				"\nslot in the bottom, just big" +
				"\nenough to fit a tray of food." +
				"\n[L]ook around at the b[O]nes or" +
				"\nor [B]ed. Anything but [U]p.";
		} else if ( currentRoom == "bonesDesc" ) {
			GetComponent<TextMesh>().text += "You can barely see" +
				"\nthem in this light, but the" +
				"\nbut the bones have been" +
				"\npicked clean, smoothed to" +
				"\na fine polish by either time" +
				"\nor a thousand, tiny, gnawing" +
				"\nteeth. [L]ook around..." +
				"\nLook at the [B]ed. Look at " +
				"\nthe [D]oor. But for God's" +
				"\nsake... don't look [U]p.";
		} else if ( currentRoom == "ceilingDesc" ) {
			GetComponent<TextMesh>().text += "As you tentatively turn" +
				"\nyour gaze upward, your" +
				"\neyes find a large grate in" +
				"\nthe ceiling. The slits are just" +
				"\nbarely big enough to fit your" +
				"\nfingers, but you cannot find" +
				"\nthe courage to reach toward" +
				"\nit. [L]ook around... At the" +
				"\n[B]ed, the [D]oor, the b[o]nes" +
				"\n... Anywhere but here.";
		}


	} // closes out Update (), from line 18

} // closes out the class declaration, from line 4







