using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities
    // Expected Result: Dequeue returns items in order of priority, with the highest priority first
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("LowPriority", 1);
        priorityQueue.Enqueue("MediumPriority", 5);
        priorityQueue.Enqueue("HighPriority", 10);
        string result = priorityQueue.Dequeue();
        Assert.AreEqual("HighPriority", result);

    }

    [TestMethod]
    // Scenario: Add three items with the same priority
    // Expected Result: Dequeue returns items in FIFO order
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstItem", 5);
        priorityQueue.Enqueue("SecondItem", 5);
        priorityQueue.Enqueue("ThirdItem", 5);
        string result1 = priorityQueue.Dequeue();
        Assert.AreEqual("FirstItem", result1);
    }

    [TestMethod]
    // Scenario: There are no items in the queue and Dequeue is called
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: None
    
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}