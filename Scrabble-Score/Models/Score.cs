using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public static char[] onePoint = "aeioulnrst".ToCharArray();
    public static char[] twoPoint = "dg".ToCharArray();
    public static char[] threePoint = "bcmp".ToCharArray();
    public static char[] fourPoint = "fhvwy".ToCharArray();
    public static char[] fivePoint = "k".ToCharArray();
    public static char[] eightPoint = "jx".ToCharArray();
    public static char[] tenPoint = "qz".ToCharArray();
    // class methods goes here
    public static int GetScore(string input)
    {
      input = input.ToLower();
      int total = 0;
      
      for (int i = 0; i < input.Length; i++)
      {
        if (Array.Exists(Score.onePoint, letter => letter == input[i]))
        {
          total += 1;
        } 
        else if (Array.Exists(Score.twoPoint, letter => letter == input[i]))
        {
          total += 2;
        } 
        else if (Array.Exists(Score.threePoint, letter => letter == input[i]))
        {
          total += 3;
        } 
        else if (Array.Exists(Score.fourPoint, letter => letter == input[i]))
        {
          total += 4;
        } 
        else if (Array.Exists(Score.fivePoint, letter => letter == input[i]))
        {
          total += 5;
        } 
        else if (Array.Exists(Score.eightPoint, letter => letter == input[i]))
        {
          total += 8;
        } 
        else if (Array.Exists(Score.tenPoint, letter => letter == input[i]))
        {
          total += 10;
        }
      }
      return total;
    }
    // method(userInput) {
    //   char[] inputArr = userInput.ToCharArray();
    //   for(int i = 0; i < inputArr.length; i++){

    //   }
    //   if(Array.Exists(Score.onePoint, char => char == inputArr[i]))
    //   {
    //     int total += 1;
    //   }
    //   if(Array.Exists(Score.twoPoint, char => char == inputArr[i]))
    //   {
    //     int total += 2;
    //   }
    //   if(Array.Exists(Score.threePoint, char => char == inputArr[i]))
    //   {
    //     int total += 3;
    //   }
    // }
    // public static int TotalScore(string[] input)
    // {
    //   foreach (string letter in input)
    //   {
    //     switch(letter)
    //     {
    //     case "A": case "B": case "E": case "I": case "O": case "U": case "L": case "N": case "R": case "S": case "T":
    //     total += 1;
    //     break;
      
    //     }
    //   }
    // }
  }
}

// Array.Exists( arr, element => element == searchElement  );
// string[] onePoint = {A, E, I, O, U, L, N, R, S, T}
//take user input
//
