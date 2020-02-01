using Microsoft.VisualStudio.TestTools.UnitTesting;
using kolkokrzyzyk;
using Class_Library;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CheckForWinnerTest
{

    [TestClass]
    public class Tie_Test
    {

        //11001
        //00110
        //11001
        //00110
        //11001
        private MarkType[] howToFillTableToMakeItTie = {
            MarkType.Cross,   MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,
            MarkType.Nought,  MarkType.Nought,    MarkType.Cross,     MarkType.Cross,     MarkType.Nought,
            MarkType.Cross,   MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,
            MarkType.Nought,  MarkType.Nought,    MarkType.Cross,     MarkType.Cross,     MarkType.Nought,
            MarkType.Cross,   MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,
            };
        


        [TestMethod]
        public void Check_For_Tie()
        { 
            CheckForWinner check = new CheckForWinner();

            var gameResult = check.CheckWin(howToFillTableToMakeItTie);

            Assert.AreEqual(gameResult, MarkType.Free);
        }

    }
}
