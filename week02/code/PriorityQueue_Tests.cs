using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{

    [TestMethod]
    // Scenario: Add items with different priorities.
    // Expected Result: The item with the highest priority should be removed first.
    // Defect(s) Found: The code did not check the last item. It may miss the item with high priority.
    public void TestPriorityQueue_HighestPriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("Tim", 1);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("Sue", result);
    }


    [TestMethod]
    // Scenario: Add two items with the same priority.
    // Expected Result: If there are more than one item with the highest priority. The first item added will be removed first.
    // Defect(s) Found: The code used >=, the last item with the same priority was removed first and not the first one.
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Sue", 5);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("Bob", result);
    }



    [TestMethod]
    // Scenario: Remove two items from the queue.
    // Expected Result: The first item is removed and the second item is returned next.
    // Defect(s) Found: The removed item stayed in the queue because RemoveAt() was missing.
    public void TestPriorityQueue_RemoveItems()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: Remove an item from an empty queue.
    // Expected Result: The code should show an InvalidOperationException with the correct message.
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(
        () => priorityQueue.Dequeue());
    }

}