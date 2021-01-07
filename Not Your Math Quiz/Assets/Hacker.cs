using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour
{
    string currentScreen = "MainMenu";

    double x;
    double y;
    double z = 0;
    string op = " + ";
    int whatVar;



    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Greetings summoner");

    }
    void ShowMainMenu(string firstLine)
    {
        Terminal.WriteLine(firstLine);
        Terminal.WriteLine("Type start if you ready!!");


    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Terminal.ClearScreen();
            ShowMainMenu("Ok buddy");
            currentScreen = "MainMenu";
        }
        else if (currentScreen == "MainMenu")
        {
            SetLevel(input);

        }
        else if (currentScreen == "EQ")
        {

            CheckEq(input);


        }

    }

    void CheckEq(string inp)
    {
        switch (whatVar)
        {
            case 1://x
                if (inp == x.ToString())
                {
                    Terminal.WriteLine("You Won!!\n");
                    currentScreen = "MainMenu";
                    ShowMainMenu("Ok winner.");
                }
                else
                {
                    Terminal.WriteLine("Wrong!!\nTry Again or type menu to go back.");

                }
                break;
            case 2://y
                if (inp == y.ToString())
                {
                    Terminal.WriteLine("You Won!!\n");
                    currentScreen = "MainMenu";
                    ShowMainMenu("Ok winner.");

                }
                else
                {
                    Terminal.WriteLine("Wrong!!\nTry Again or type menu to go back.");
                }
                break;
            case 3://z
                if (inp == z.ToString())
                {
                    Terminal.WriteLine("You Won!!\n");
                    currentScreen = "MainMenu";
                    ShowMainMenu("Ok winner.");
                }
                else
                {
                    Terminal.WriteLine("Wrong!!\nTry Again or type menu to go back.");
                }
                break;
        }



    }
    void ShowEq()
    {
        whatVar = Random.Range(1, 4);
        switch (whatVar)
        {
            case 1://x
                Terminal.WriteLine("x" + op + y + " = " + z); ;
                break;
            case 2://y
                Terminal.WriteLine(x + op + "y" + " = " + z);
                break;
            case 3://z
                Terminal.WriteLine(x + op + y + " = " + "z");
                break;
        }
        if (x == 6 && y == 9)
            Terminal.WriteLine("Noice");


        
    }

    void SetLevel(string start)
    {
        if (start == "start")
        {
            
            currentScreen = "EQ";
            GenerateEq();
            ShowEq();

        }
        else
            Terminal.WriteLine("invalid input");


    }

    void GenerateEq()
    {
        x = Random.Range(1, 16);
        y = Random.Range(1, 16);
        int opr = Random.Range(1, 4);

        switch (opr)
        {
            case 1:
                op = " + ";
                break;
            case 2:
                op = " - ";
                break;
            case 3:
                op = " * ";
                break;
        }

        switch (op)
        {
            case " + ":
                z = x + y;
                break;
            case " - ":
                z = x - y;
                break;
            case " * ":
                z = x * y;
                break;

        }

    }







}
