using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tanzaku.Models;

namespace Tanzaku.Tests.Model
{
    [TestClass]
    public class TanzakuMakerTest
    {
        private TanzakuMaker _sut = new TanzakuMaker();

        [TestMethod]
        public void 何も入力がないときは枠だけ表示する()
        {
            var actual = _sut.Generate("");

            Assert.AreEqual(@"┏┻┓
┗━┛
", actual);
        }

        [TestMethod]
        public void 入力文字を縦書きで表示する()
        {
            var actual = _sut.Generate("テスト");

            Assert.AreEqual(@"┏┻┓
┃テ┃
┃ス┃
┃ト┃
┗━┛
", actual);
        }
    }
}
