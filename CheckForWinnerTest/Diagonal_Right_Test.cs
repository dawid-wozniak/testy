using Microsoft.VisualStudio.TestTools.UnitTesting;
using kolkokrzyzyk;
using Class_Library;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CheckForWinnerTest
{
    [TestClass]
    public class Diagonal_Right_Test
    {
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void Win_Outcome_Cross(int startPosition)
        {

            MarkType[] mResults = new MarkType[25];
            CheckForWinner check = new CheckForWinner();

            mResults[startPosition      ] = MarkType.Cross;
            mResults[startPosition + 4  ] = MarkType.Cross;
            mResults[startPosition + 8  ] = MarkType.Cross;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Cross);

        }


        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void Win_Outcome_Nought(int startPosition)
        {

            MarkType[] mResults = new MarkType[25];
            CheckForWinner check = new CheckForWinner();

            mResults[startPosition      ] = MarkType.Nought;
            mResults[startPosition + 4  ] = MarkType.Nought;
            mResults[startPosition + 8  ] = MarkType.Nought;

            var gameResult = check.CheckWin(mResults);

            Assert.AreEqual(gameResult, MarkType.Nought);
        }

    }
}
