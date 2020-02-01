using Microsoft.VisualStudio.TestTools.UnitTesting;
using kolkokrzyzyk;
using Class_Library;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CheckForWinnerTest
{
    //Testy ktore sprawdzaja na przekatnej typu 'pelne zapelnienie tablicy w sposob aby nikt nie zwyciazal'
    //Raport:przechodzi wszystkie testy


    [TestClass]
    public class Tie_Test
    {

        //11001//1
        //00110//0
        //11001//1
        //00110//0
        //11001//1
        static private MarkType[][] howToFillTableToMakeItTie1 = { new MarkType[] {
            MarkType.Cross,   MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,
            MarkType.Nought,  MarkType.Nought,    MarkType.Cross,     MarkType.Cross,     MarkType.Nought,
            MarkType.Cross,   MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,
            MarkType.Nought,  MarkType.Nought,    MarkType.Cross,     MarkType.Cross,     MarkType.Nought,
            MarkType.Cross,   MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,
            } };

        //1//10011
        //0//01100
        //1//10011
        //0//01100
        //1//10011
        static private MarkType[][] howToFillTableToMakeItTie2 = { new MarkType[] {
            MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,     MarkType.Cross,
            MarkType.Nought,    MarkType.Cross,     MarkType.Cross,     MarkType.Nought,    MarkType.Nought,
            MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,     MarkType.Cross,
            MarkType.Nought,    MarkType.Cross,     MarkType.Cross,     MarkType.Nought,    MarkType.Nought,
            MarkType.Cross,     MarkType.Nought,    MarkType.Nought,    MarkType.Cross,     MarkType.Cross,
            } };


        [TestCaseSource("howToFillTableToMakeItTie1")]
        [TestCaseSource("howToFillTableToMakeItTie2")]

        public void Check_For_Tie(MarkType[] howToFillTableToMakeItTie)
        { 
            CheckForWinner check = new CheckForWinner();

            var gameResult = check.CheckWin(howToFillTableToMakeItTie);

            Assert.AreEqual(gameResult, MarkType.Free);
        }

    }
}
