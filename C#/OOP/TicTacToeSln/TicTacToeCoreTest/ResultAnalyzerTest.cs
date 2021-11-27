using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TicTacToeCoreTest
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Board board = new Board();
            board.MarkBoard(MarkType.O, 0);
            board.MarkBoard(MarkType.X, 1);
            board.MarkBoard(MarkType.O, 2);
            board.MarkBoard(MarkType.X, 3);
            board.MarkBoard(MarkType.O, 4);
            board.MarkBoard(MarkType.X, 5);
            board.MarkBoard(MarkType.X, 6);
            board.MarkBoard(MarkType.O, 7);
            board.MarkBoard(MarkType.X, 8);
            var resultAnalyze = new ResultAnalyzer(board);

            var result = resultAnalyze.Analyze();
            Assert.AreEqual<ResultType>(ResultType.DRAW, result);
        }

        [TestMethod]
        public void IsResultWin_or_NoResult()
        {
            Board board = new Board();
            board.MarkBoard(MarkType.O, 0);
            board.MarkBoard(MarkType.O, 1);
            board.MarkBoard(MarkType.O, 2);
            var resultAnalyze = new ResultAnalyzer(board);

            var result = resultAnalyze.Analyze();
            Assert.AreEqual<ResultType>(ResultType.WIN, result);
        }
    }
}
