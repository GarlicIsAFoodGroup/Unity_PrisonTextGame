using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {
		cell, 
		mirror, 
		sheets_0, 
		lock_0, 
		cell_mirror, 
		sheets_1, 
		lock_1, 
		corridor_0, 
		stairs_0, 
		floor, 
		closet_door, 
		corridor_1, 
		stairs_1, 
		in_closet, 
		corridor_2, 
		stairs_2, 
		corridor_3, 
		courtyard};
		
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
	
		print (myState);
		if (myState == States.cell) 			{state_cell();} 
		else if (myState == States.sheets_0) 	{state_sheets_0();} 
		else if (myState == States.lock_0) 		{state_lock_0();} 
		else if (myState == States.mirror) 		{state_mirror();} 
		else if (myState == States.cell_mirror) {state_cell_mirror();} 
		else if (myState == States.sheets_1) 	{state_sheets_1 ();} 
		else if (myState == States.lock_1) 		{state_lock_1 ();} 
		else if (myState == States.corridor_0) 	{state_corridor_0 ();}
		else if (myState == States.stairs_0)	{state_stairs_0 ();}
		else if (myState == States.floor)		{state_floor ();}
		else if (myState == States.closet_door) {state_closet_door ();}
		else if (myState == States.corridor_1)	{state_corridor_1 ();}
		else if (myState == States.in_closet)	{state_in_closet ();}
		else if (myState == States.stairs_1)	{state_stairs_1 ();}
		else if (myState == States.corridor_2)	{state_corridor_2 ();}
		else if (myState == States.stairs_2)	{state_stairs_2 ();}
		else if (myState == States.corridor_3)	{state_corridor_3 ();}
		else if (myState == States.courtyard)	{state_courtyard ();}
	}
	
			
	void state_cell () {
	
		text.text = "You wake up in a prison cell, & you need to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and a locked " +
					"door.\n\n" +
					"Press S to view Sheets, M for Mirror, L for Lock";
	
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.sheets_0;}
		
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.mirror;} 
		
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_0;}
	}
	
	void state_sheets_0 () {
		
		text.text = "You can't believe you sleep in these things. Surely, it's " +
					"time somebody changed them. The pleasures of prison life " +
					"I guess!\n\n" +
					"Press R to Return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void state_lock_0 () {
		
		text.text = "You examine your cell door. It's locked but has some give. " +
					"You'll need to find something to unlock the door. " +
					"Time to look around.\n\n" +
					"Presss R to Roam around your to cell.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void state_mirror () {
	
		text.text = "You examine the mirror. You pull it open " +
					"and find a rusty bobby pin. Maybe you can " +
					"use it to pick the lock.\n\n" +
					"Press T to Take the pin, or R to return to cell";
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_mirror;} 
		
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;} 
	}
	
	void state_cell_mirror () {
		
		text.text = "With the bobby pin in hand, you wonder " +
					"if there could be anything else useful. " +
					"Maybe there's something in the sheets.\n\n" +
					"Press S to search Sheets, press L to try the lock";
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.sheets_1;} 
		
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_1;}
	}
	
	void state_sheets_1 () {
		
		text.text = "You rummage through the sheets and find " +
					"lint and more lint. Nothing that helps. " +
					"Well, it didn't hurt to look.\n\n" +
					"Press R to Return to your cell.";
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_mirror;}
	}
	
	void state_lock_1 () {
		
		text.text = "You prod the inside of the keyhole with the bobby pin. " +
					"Huzzah! You hear two clicks! " +
					"750+ hours of Skyrim clearly prepared you for this!\n\n" +
					"Press O to open the door & slip into the corridor!";
		if (Input.GetKeyDown(KeyCode.O)) 		{myState = States.corridor_0;}
	}
	
	void state_corridor_0 () {
		
		text.text = "Yay, out of the cell. Time to navigate the corridors " +
					"to freedom! Before the guards find you, " +
					"examine your surroundings.\n\n" +
					"Press S for Stairway, F for floor, C for closet";
			
			if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs_0;}
			else if (Input.GetKeyDown(KeyCode.F))	{myState = States.floor;}
			else if (Input.GetKeyDown (KeyCode.C))	{myState = States.closet_door;}
	}
	
	void state_stairs_0 () {
		
		text.text = "Ack! The staircase requires a magnetic keycard carried by the prison " +
					"guards. There's no way to get one undetected. Try something else.\n\n" +
					"Press R to Return to the corridor";
					
			if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.corridor_0;}
	}
	
	void state_floor () {
			
			text.text = "Your eyes scan the floor. A tool, inspiration, you hope " +
						"for anything at this point. Your eye catches a grey cap crumpled on the floor.\n\n" +
						"Press P to Pick up the cap, or R to Return";	
			if (Input.GetKeyDown (KeyCode.P))		{myState = States.corridor_1;}
			else if (Input.GetKeyDown (KeyCode.R))	{myState = States.corridor_0;}
	}	
	
	void state_closet_door () {
			
			text.text = "The closet is locked, but you pick it easily. " +
						"Inside, you find a grey custodial uniform" +
						"and sanitation cart. Even with the disguise, guards know your face.\n\n" +
						"Press R to Return to corridor";
			if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;}
	}	

	void state_corridor_1 () {
			
			text.text = "You hear guards coming. With the cap in hand, you scan your surroundings. " +
						"There's the staircase or the closet. Where will you hide?\n\n" +
						"Press S for Staircase, press C for closet";
			
			if (Input.GetKeyDown (KeyCode.S)) 			{myState = States.stairs_1;}
			else if (Input.GetKeyDown (KeyCode.C))		{myState = States.in_closet;}	
	}

	void state_stairs_1 () {
			
			text.text = "Just as you lunge for the staircase door, its knob begins to turn. " +
						"Guard chatter can be clearly heard, they're going to walk in on you! " +
						"Quickly, you need to hide!\n\n" +
						"Press R to quickly Return to the corridor.";
						
			if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_1;} 
	}
	
	void state_in_closet () {
		
			text.text = "You jump in the closet. Quickly & quietly, you shut the door. " +
						"Clenching the grey cap, your eyes turn " +
						"toward the hanging grey custodian uniform...\n\n" +
						"Press C to Change & exit, or press R to Return"; 
			
			if (Input.GetKeyDown (KeyCode.C))			{myState = States.corridor_2;}
			else if (Input.GetKeyDown (KeyCode.R))		{myState = States.corridor_1;}
	}

	void state_corridor_2 () {
	
			text.text = "Walking down the hall, you pull down" +
						"the cap to further obscure " +
						"your identity. The guards can still recognize you if you're too close.\n\n" +
						"Press S for Staircase, press C down Corridor"; 
						
			if (Input.GetKeyDown (KeyCode.S))			{myState = States.stairs_2;}
			else if (Input.GetKeyDown(KeyCode.C))		{myState = States.corridor_3;}
	}
	
	void state_stairs_2 () {
		
			text.text = "You walk toward the stairway, where the guards have congregated. " +
						"As you get closer, more and more guards look up at you. " +
						"Turn back, you might get discovered.\n\n" +
						"Press R to Return to the corridor";
			
			if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_2;}
	}
	
	void state_corridor_3 () {
			
			text.text = "This end of the corridor is clear. Deep exhale of relief. " +
						"You continue walking and recognize another stairway--" +
						"it leads to the courtyard.\n\n" +
						"Press S for Stairway, press R to Return";
			
			if (Input.GetKeyDown(KeyCode.S))			{myState = States.courtyard;}
			else if (Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_2;}
	}

	void state_courtyard () {
	
			text.text = "Oh, yes! You've made it outside! You're in the courtyard! " +
						"Even luckier, there's no one outside!\n\n" +
						"Press R to Replay this text adventure";
			
			if(Input.GetKeyDown(KeyCode.R))			{myState = States.cell;}
	
	}
	

}

	
