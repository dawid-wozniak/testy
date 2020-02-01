using Microsoft.VisualStudio.TestTools.UnitTesting;
using kolkokrzyzyk;
using Class_Library;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CheckForWinnerTest
{
    [TestClass]
    public class Vertical_Test

    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void Win_Outcome_Cross(int startPosition)
        {

            CheckForWinner check = new CheckForWinner();
            MarkType[] mResults = new MarkType[25];

            mResults[startPosition] = MarkType.Cross;
            mResults[startPosition + 5] = MarkType.Cross;
            mResults[startPosition + 10] = MarkType.Cross;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Cross);

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void Win_Outcome_Nought(int startPosition)
        {

            CheckForWinner check = new CheckForWinner();
            MarkType[] mResults = new MarkType[25];

            mResults[startPosition] = MarkType.Nought;
            mResults[startPosition + 5] = MarkType.Nought;
            mResults[startPosition + 10] = MarkType.Nought;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Nought);

        }
    }
}
