using CaremetxAnagramExercise.Models;
using NUnit.Framework;
namespace NUnitTestCaremetxAnagramExercise
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAreAnagrams()
        {
            TextInput Text = new TextInput();
            string text1 = "silent";
            string text2 = "listen";
            Assert.IsTrue(Text.AreAnagram(text1,text2));
        }

        [Test]
        public void TestAreNotAnagrams()
        {
            TextInput Text = new TextInput();
            string text1 = "abc";
            string text2 = "acd";
            Assert.IsFalse(Text.AreAnagram(text1, text2));
        }
    }
}