using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTest
  {
    [TestMethod]
    public void ScoreStaticFields_StaticFieldPopulateCorrectValues_Array()
    {
      //arrange
      char[] onePointTest = "aeioulnrst".ToCharArray();
      char[] twoPointTest = "dg".ToCharArray();
      char[] threePointTest = "bcmp".ToCharArray();
      char[] fourPointTest = {'f', 'h', 'v', 'w', 'y'};
      char[] fivePointTest = {'k'};
      char[] eightPointTest = {'j', 'x'};
      char[] tenPointTest = {'q', 'z'};
      //act
      char[] onePoint = Score.onePoint;
      char[] twoPoint = Score.twoPoint;
      char[] threePoint = Score.threePoint;
      char[] fourPoint = Score.fourPoint;
      char[] fivePoint = Score.fivePoint;
      char[] eightPoint = Score.eightPoint;
      char[] tenPoint = Score.tenPoint;
      //asssert

      CollectionAssert.AreEqual(onePointTest, onePoint);
      CollectionAssert.AreEqual(twoPointTest, twoPoint);
      CollectionAssert.AreEqual(threePointTest, threePoint);
      CollectionAssert.AreEqual(fourPointTest, fourPoint);
      CollectionAssert.AreEqual(fivePointTest, fivePoint);
      CollectionAssert.AreEqual(eightPointTest, eightPoint);
      CollectionAssert.AreEqual(tenPointTest, tenPoint);
    }
    [TestMethod]
    public void GetScore_OnePointArrayOnePointTest_Int()
    {
      char[] onePointTest = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      string input = "slot";
      Assert.AreEqual(4, Score.GetScore(input));
    }
    [TestMethod]
    public void GetScore_TwoPointArrayTwoPointTest_Int()
    {
      char[] twoPointTest = "dg".ToCharArray();
      string input = "dg";
      Assert.AreEqual(4, Score.GetScore(input));
    }
    [TestMethod]
    public void GetScore_ThreePointArrayThreePointTest_Int()
    {
      char[] threePointTest = "bcmp".ToCharArray();
      string input = "bc";
      Assert.AreEqual(6, Score.GetScore(input));
    }
    [TestMethod]
    public void GetScore_FourPointArrayFourPointTest_Int()
    {
      char[] fourPointTest = {'f', 'h', 'v', 'w', 'y'};
      string input = "fwy";
      Assert.AreEqual(12, Score.GetScore(input));
    }
    [TestMethod]
    public void GetScore_FivePointArrayFivePointTest_Int()
    {
      char[] fivePointTest = {'k'};
      string input = "kk";
      Assert.AreEqual(10, Score.GetScore(input));
    }
    [TestMethod]
    public void GetScore_EightPointArrayEightPointTest_Int()
    {
      char[] eightPointTest = {'j', 'x'};
      string input = "jx";
      Assert.AreEqual(16, Score.GetScore(input));
    }
    [TestMethod]
    public void GetScore_TenPointArrayTenPointTest_Int()
    {
      char[] tenPointTest = {'q', 'z'};
      string input = "qz";
      Assert.AreEqual(20, Score.GetScore(input));
    }
  }
}