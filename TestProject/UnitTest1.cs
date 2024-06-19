namespace TestProject
{
    public class Tests
    {
   
        [Test]
        public void ReverseTest()
        {
            var testList = new List<string>()
            {
                "Hello", "world"
            };

            var result = Kata.Revers(testList);

            Assert.AreEqual(testList[0], result[1]);
            Assert.AreEqual(testList[1], result[0]);
        }
        [Test]
        public void SplitTest()
        {
            string testString = "Hello word I do not want be homeless";
            string testString2 = "Hello world";
            var result = Kata.Split(testString2, ' ');
            Assert.AreEqual("Hello", result[0]);
            Assert.AreEqual("world", result[1]);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
            Assert.AreEqual("", Kata.ReverseWords(""));
            
        }
    }
}