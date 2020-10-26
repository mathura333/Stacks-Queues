using Microsoft.VisualStudio.TestTools.UnitTesting;
using StacksQueuesProblem;
using System;
using System.Collections;

namespace StacksQueuesMSTest
{
    [TestClass]
    public class StacksUnitTests
    {
        [TestMethod]
        public void Pop_Method_Should_Throw_StackException_When_Stack_Is_Empty()
        {
            try
            {
                StacksQueuesProblem.Stack testingObj = new StacksQueuesProblem.Stack();
                testingObj.Pop();
            }
            catch(Exception e)
            {
                Assert.AreEqual(e.Message, "No Value in Stack");
            }
        }
        [TestMethod]
        public void Display_Method_Should_Throw_StackException_When_Stack_Is_Empty()
        {
            try
            {
                StacksQueuesProblem.Stack testingObj = new StacksQueuesProblem.Stack();
                testingObj.Display();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "No Value in Stack");
            }
        }
        [TestMethod]
        public void Peek_Method_Should_Throw_StackException_When_Stack_Is_Empty()
        {
            try
            {
                StacksQueuesProblem.Stack testingObj = new StacksQueuesProblem.Stack();
                testingObj.Peek();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "No Value in Stack");
            }
        }
    }
}
