using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace CrosswordDLL
{
    public class CrosswordCreator
    {
        /// <summary>
        /// This is used to generate the crossword puzzle
        /// </summary>
        /// <param name="difficulty">Total difficulty of the crossword</param>
        /// <param name="size">Width of the square</param>
        /// <returns></returns>
        public CrosswordCell[,] CreateCrossword(int difficulty, int size, string category)
        {
            //Generate the Crossword
            CrosswordCell[,] myArray = new CrosswordCell[size, size];

            //Do the Queries to get the correct data

            //Add to the data base

            //Should called this createcrossword function in the game.cs file
            return myArray;
        }

    }
}
