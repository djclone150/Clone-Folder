using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Creates the integer number values
    int minNum = 1;
    int maxNum = 1000;
    int guessNum = 500;

    void StartGame() //Declaring the function/method that acts like the startup of the game
    {
        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number in your head between " + minNum + " and " + maxNum);
        NextGuess();
    }

    //3 Int variables
    void NextGuess() //Declaring the function/method that acts like the progression of the game where it asks for user input
    {
        print("Is the number greater or smaller than " + guessNum);
        print("UP: Greater DOWN: Smaller ENTER: Equal");

        //function/method declaration
    }

    
    // Use this for initialization
    void Start()
    {
        StartGame();   
        //Prints once to the console
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UP Arrow Pressed");  //Print that the up arrow has been detected
            minNum = guessNum;  //Replaces the minimum number value to the value of the guess depending on what the user inputted
            guessNum = (minNum + maxNum) / 2;   //Making up the new guess number which will be the center of the maximum and minimum numbers

            //Print statement and variable declaration and mathematical function

            NextGuess();

            //2 Print statements
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DOWN Arrow Pressed");    //Print that the down arrow has been detected
            maxNum = guessNum;  //Replaced the maximum number value to the value of the guess depending on what the user inputted
            guessNum = (minNum + maxNum) / 2;   //Making up the new guess number which will be the center of the maximum and minimum numbers

            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("RETURN Button Pressed"); //Return declares the number has been guessed and ends the game
            print("YOU WON! The number  was " + guessNum);
        }
    }
}