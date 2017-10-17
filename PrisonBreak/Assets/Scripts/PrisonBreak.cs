using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreak : MonoBehaviour {

    // Use this for initialization
    public Text myText;

    void Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
            "some dirty sheets on the bed, a mark where the mirror was, " +
            "and that pesky door is still there, and firmly locked!\n\n" +
            "Press R to go back Cell or T to Take the Mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            myStates = States.cell_mirror;
        }
    }

    void sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
            "any better. \n\n " +
            "Press R to Return roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell_mirror;
        }
    }


    void lock_01()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
            "so you can see the lock. You can just make out fingerprints around " +
            "the buttons. You press the dirty buttons, and hear a click. \n\n" +
            "Press O to Open or R to Return to your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell_mirror;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            myStates = States.freedom;
        }
    }

    void stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider. \n\n" +
            "Press R to Return to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.freedom;
        }
    }

    void freedom()
    {
        myText.text = "YOU ARE ALMOST FREE! You are in a corridor and decide where to go next.\n\n" +
            "Press S to go to Stairs, F to go to Floor or C to go to Closet";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.stairs_0;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            myStates = States.floor;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = States.closet_door;
        }
    }

    void floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip. \n\n" +
            "Press T to Take the hairclip or R to Return to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.freedom;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            myStates = States.corridor_1;
        }

    }

    void corridor_1()
    {
        myText.text = "You taken the hairclip. Still in the corridor. Floor still dirty. Hairclip in hand. " +
            "Now what? You wonder if that lock on the closet would succumb to " +
            "to some lock-picking? \n\n" +
            "Press S to go Stairs or P to Pick the lock of the closet";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.stairs_1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.in_closet;
        }
    }

    void stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
            "confidence to walk out into a courtyard surrounded by armed guards! \n\n" +
            "Press R to Return to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.corridor_1;
        }
    }

    void in_closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
            "Seems like your day is looking-up. \n\n" +
            "Press R to return to corridor or D to Dress the uniform";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.corridor_1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myStates = States.corridor_3;
        }
    }

    void corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner. " +
            "You strongly consider the run for freedom. \n\n" +
            "Press U to Undress the uniform or S to go to Stairs";

        if (Input.GetKeyDown(KeyCode.U))
        {
            myStates = States.in_closet;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.courtyard;
        }
    }

    void courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
            "The guard tips his hat as you waltz past, claiming " +
            "your freedom. Your heart races as you walk into the sunset. \n\n" +
            "Press P to Play again";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.cell;
        }

    }

    void closet_door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
            "Maybe you could find something around to help encourage it open? \n\n" +
            "Press R to Return to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.freedom;
        }
    }


    void cell_mirror()
    {
        myText.text = "You have taken the mirror! You are still in your cell, and you STILL want to escape! There are " +
            "some dirty sheets on the bed, a mark where the mirror was, " +
            "and that pesky door is still there, and firmly locked! \n\n" +
            "Press S to view Sheets or L to view Lock";

        if(Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_1;
        }

    }

    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
            "combination is. You wish you could somehow see where the dirty " +
            "fingerprints were, maybe that would help.\n\n" +
            "Press R to Return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
    }
        
       
    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's " + "time somebody changed them. The"
            + " pleasures of prison life, I guess! \n\n" + "Press R to Return to roaming your cell";

        if(Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
    }

    void cellInstructions()
    {
        myText.text = "You are in a Prison cell, and you want to escape. There are " + "some dirty sheets" +
                " on the bed, a mirror on the wall, and the door " + "is locked from the outside. \n\n" + "Press S to view Sheets, M to view Mirror and L to view Lock";

        if(Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_0;
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            myStates = States.mirror;
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_0;
        }
    }
    private enum States
    {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom, stairs_0, floor, closet_door,
        corridor_1, stairs_1, in_closet, corridor_3, courtyard
    };

    private States myStates;
        

	void Start () {
        myStates = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myStates);

        if(myStates == States.cell)
        {
            cellInstructions();
        }
        else if (myStates == States.sheets_0)
        {
            Sheets_0();
        }
        else if (myStates == States.mirror)
        {
            Mirror();
        }
        else if (myStates == States.lock_0)
        {
            Lock_0();
        }
        else if (myStates == States.cell_mirror)
        {
            cell_mirror();
        }
        else if (myStates == States.lock_1)
        {
            lock_01();
        }
        else if (myStates == States.sheets_1)
        {
            sheets_1();
        }
        else if (myStates == States.freedom)
        {
            freedom();
        }
        else if (myStates == States.stairs_0)
        {
            stairs_0();
        }
        else if (myStates == States.floor)
        {
            floor();
        }
        else if (myStates == States.closet_door)
        {
            closet_door();
        }
        else if (myStates == States.corridor_1)
        {
            corridor_1();
        }
        else if (myStates == States.stairs_1)
        {
            stairs_1();
        }
        else if (myStates == States.in_closet)
        {
            in_closet();
        }
        else if (myStates == States.corridor_3)
        {
            corridor_3();
        }
        else if (myStates == States.courtyard)
        {
            courtyard();
        }
	}
}
