using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TicTacToeCoreTest
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void WhenCellCreatedMarkHasTobeEmpty()
        {
            Cell c = new Cell();
            var mark = c.Mark;
            Assert.AreEqual<MarkType>(mark, MarkType.Empty);
        }

        [TestMethod]
        public void IsCellAlreadyMarked()
        {
            Cell c = new Cell();
            c.Mark = MarkType.X;
            Assert.IsTrue(c.IsMarked() == true);
        }

        [TestMethod]
        public void ShouldBeAbleToMarkCell()
        {
            Cell c = new Cell();
            c.Mark = MarkType.Empty;
            Assert.IsTrue(c.IsMarked() != true);
        }

        [TestMethod]
        public void ShouldThrowExceptionIfYouTryToMarkCellTwice()
        {
            Cell c = new Cell();
            c.Mark = MarkType.X;
            var input = MarkType.X;
            var isMarkTwice = c.IsMarkCellTwice(input);
            Assert.IsTrue(isMarkTwice == true);
        }
    }
}
