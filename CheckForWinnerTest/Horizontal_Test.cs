﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using kolkokrzyzyk;
using Class_Library;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CheckForWinnerTest
{
    //Testy ktore sprawdzaja na przekatnej typu '-'
    //Raport:przechodzi wszystkie testy : zwycieza O, zwycieza X, nikt nie zwycieza w sytuacji (0X0, X0X) 


    [TestClass]
    public class Horizontal_Test

    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        public void Win_Outcome_Cross(int startPosition)
        {
            CheckForWinner check = new CheckForWinner();
            MarkType[] mResults = new MarkType[25];

            mResults[startPosition      ] = MarkType.Cross;
            mResults[startPosition + 1  ] = MarkType.Cross;
            mResults[startPosition + 2  ] = MarkType.Cross;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Cross);
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        public void Win_Outcome_Nought(int startPosition)
        {
            CheckForWinner check = new CheckForWinner();
            MarkType[] mResults = new MarkType[25];

            mResults[startPosition] = MarkType.Nought;
            mResults[startPosition + 1] = MarkType.Nought;
            mResults[startPosition + 2] = MarkType.Nought;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Nought);
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        public void Win_Outcome_None1(int startPosition)
        {
            CheckForWinner check = new CheckForWinner();
            MarkType[] mResults = new MarkType[25];

            mResults[startPosition] = MarkType.Nought;
            mResults[startPosition + 1] = MarkType.Cross;
            mResults[startPosition + 2] = MarkType.Nought;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Free);
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        public void Win_Outcome_None2(int startPosition)
        {
            CheckForWinner check = new CheckForWinner();
            MarkType[] mResults = new MarkType[25];

            mResults[startPosition] = MarkType.Cross;
            mResults[startPosition + 1] = MarkType.Nought;
            mResults[startPosition + 2] = MarkType.Cross;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Free);
        }
    }
}
