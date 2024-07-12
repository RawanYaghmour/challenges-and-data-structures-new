using Data_Structures;

namespace LinkedList_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Add_AddsNodesToEndOfList()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            Assert.True(list.Includes(5));
            Assert.True(list.Includes(10));
            Assert.True(list.Includes(20));
        }

        [Fact]
        public void Remove_RemovesNodeFromEndOfList()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            list.Remove(20);
            Assert.False(list.Includes(20));
        }

        [Fact]
        public void PrintList_PrintsLinkedListContents()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            using (var consoleOutput = new ConsoleOutput())
            {
                list.PrintList();
                Assert.Equal("Head -> 5 -> 10 -> 20 -> 30 -> Null\r\n", consoleOutput.GetOutput());
            }
        }
    }

    // Helper class to capture console output
    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOutput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}