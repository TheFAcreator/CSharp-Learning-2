using Chainblock.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;

namespace Chainblock.Tests
{
    public class Tests
    {
        private Chainblock chainblock;
        private Mock<ITransaction> mockTransaction;

        [SetUp]
        public void Setup()
        {
            chainblock = new Chainblock();

            mockTransaction = new Mock<ITransaction>();

            mockTransaction.Setup(t => t.Id).Returns(1);
            mockTransaction.Setup(t => t.From).Returns("Alice");
            mockTransaction.Setup(t => t.To).Returns("Bob");
            mockTransaction.Setup(t => t.Amount).Returns(100);
        }


        [Test]
        public void Count_ShouldReturnRecordCount()
        {
            // Act
            int count = chainblock.Count;
            // Assert
            Assert.AreEqual(0, count);
        }

        [Test]
        public void Add_ShouldAddTransaction()
        {
            // Act
            chainblock.Add(mockTransaction.Object);
            // Assert
            Assert.That(chainblock.Count == 1);
            Assert.That(chainblock.Contains(mockTransaction.Object.Id), Is.True);
        }

        [Test]
        public void Contains_ShouldReturnTrueIfIdExists()
        {
            // Arrange
            int id = 1;
            chainblock.Add(mockTransaction.Object);
            // Act
            bool contains = chainblock.Contains(id);
            // Assert
            Assert.That(contains, Is.True);
        }

        [Test]
        public void ChangeTransactionStatus_ShouldChangeStatus()
        {
            // Arrange
            mockTransaction.SetupProperty(t => t.Status, TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction.Object);

            var newStatus = TransactionStatus.Successfull;
            // Act
            chainblock.ChangeTransactionStatus(mockTransaction.Object.Id, newStatus);
            // Assert
            Assert.AreEqual(newStatus, mockTransaction.Object.Status);
        }

        [Test]
        public void ChangeTransactionStatus_ShouldThrowExceptionIfIdDoesNotExist()
        {
            // Arrange
            int nonExistentId = 999;
            var newStatus = TransactionStatus.Successfull;
            // Act & Assert
            Assert.Throws<ArgumentException>(() => chainblock.ChangeTransactionStatus(nonExistentId, newStatus));
        }

        [Test]
        public void RemoveTransactionById_ShouldRemoveTransaction()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);
            int id = mockTransaction.Object.Id;
            // Act
            chainblock.RemoveTransactionById(id);
            // Assert
            Assert.That(chainblock.Contains(id), Is.False);
        }

        [Test]
        public void RemoveTransactionById_ShouldThrowExceptionIfIdDoesNotExist()
        {
            // Arrange
            int nonExistentId = 999;
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.RemoveTransactionById(nonExistentId));
        }

        [Test]
        public void GetById_ShouldReturnTransaction()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);
            int id = mockTransaction.Object.Id;
            // Act
            var transaction = chainblock.GetById(id);
            // Assert
            Assert.IsNotNull(transaction);
            Assert.AreEqual(mockTransaction.Object, transaction);
        }

        [Test]
        public void GetById_ShouldThrowExceptionIfIdDoesNotExist()
        {
            // Arrange
            int nonExistentId = 999;
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetById(nonExistentId));
        }

        [Test]
        public void GetByTransactionStatus_ShouldReturnTransactionsWithGivenStatus()
        {
            // Arrange
            mockTransaction.Setup(t => t.Status).Returns(TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.Amount).Returns(101);
            mockTransaction2.Setup(t => t.Id).Returns(2);
            mockTransaction2.Setup(t => t.Status).Returns(TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction2.Object);
            // Act
            var transactions = chainblock.GetByTransactionStatus(TransactionStatus.Unauthorised).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction2.Object); // Ensure the first transaction is the one with higher amount
            Assert.AreEqual(transactions[1], mockTransaction.Object); // since ordering is by amount descending
        }

        [Test]
        public void GetByTransactionStatus_ShouldThrowExceptionIfNoTransactionsWithGivenStatus()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetByTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllSendersWithTransactionStatus_ShouldReturnSendersWithGivenStatus()
        {
            // Arrange
            mockTransaction.Setup(t => t.Status).Returns(TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction.Object);
            // Act
            var senders = chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Unauthorised);
            // Assert
            Assert.IsNotNull(senders);
            Assert.IsTrue(senders.Contains(mockTransaction.Object.From));
        }

        [Test]
        public void GetAllSendersWithTransactionStatus_ShouldThrowExceptionIfNoSendersWithGivenStatus()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllReceiversWithTransactionStatus_ShouldReturnReceiversWithGivenStatus()
        {
            // Arrange
            mockTransaction.Setup(t => t.Status).Returns(TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction.Object);
            // Act
            var senders = chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Unauthorised);
            // Assert
            Assert.IsNotNull(senders);
            Assert.IsTrue(senders.Contains(mockTransaction.Object.To));
        }

        [Test]
        public void GetAllReceiversWithTransactionStatus_ShouldThrowExceptionIfNoReceiversWithGivenStatus()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllOrderedByAmountDescendingThenById_ShouldReturnTransactionsOrderedByAmountDescendingThenById()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.Id).Returns(2);
            mockTransaction2.Setup(t => t.Amount).Returns(200);
            chainblock.Add(mockTransaction2.Object);

            var mockTransaction3 = new Mock<ITransaction>();
            mockTransaction3.Setup(t => t.Id).Returns(3);
            mockTransaction3.Setup(t => t.Amount).Returns(200);
            chainblock.Add(mockTransaction3.Object);
            // Act
            var transactions = chainblock.GetAllOrderedByAmountDescendingThenById().ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction2.Object); // Ensure the first transaction is the one with higher amount
            Assert.AreEqual(transactions[1], mockTransaction3.Object); // since ordering is by amount descending, then by id
            Assert.AreEqual(transactions[2], mockTransaction.Object);
        }

        [Test]
        public void GetBySenderOrderedByAmountDescending_ShouldReturnTransactionsBySenderOrderedByAmountDescending()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.From).Returns("Alice");
            mockTransaction2.Setup(t => t.Amount).Returns(200);
            mockTransaction2.Setup(t => t.Id).Returns(2);
            chainblock.Add(mockTransaction2.Object);
            // Act
            var transactions = chainblock.GetBySenderOrderedByAmountDescending("Alice").ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction2.Object); // Ensure the first transaction is the one with higher amount
            Assert.AreEqual(transactions[1], mockTransaction.Object); // since ordering is by amount descending
        }

        [Test]
        public void GetBySenderOrderedByAmountDescending_ShouldThrowExceptionIfNoTransactionsBySender()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetBySenderOrderedByAmountDescending("NonExistentSender"));
        }

        [Test]
        public void GetByReceiverOrderedByAmountThenById_ShouldReturnTransactionsByReceiverOrderedByAmountThenById()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.To).Returns("Bob");
            mockTransaction2.Setup(t => t.Amount).Returns(200);
            mockTransaction2.Setup(t => t.Id).Returns(2);
            chainblock.Add(mockTransaction2.Object);
            // Act
            var transactions = chainblock.GetByReceiverOrderedByAmountThenById("Bob").ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction2.Object); // Ensure the first transaction is the one with higher amount
            Assert.AreEqual(transactions[1], mockTransaction.Object); // since ordering is by amount descending (then by id)
        }

        [Test]
        public void GetByReceiverOrderedByAmountDescendingThenById_ShouldThrowExceptionIfNoTransactionsBySender()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetByReceiverOrderedByAmountThenById("NonExistentSender"));
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmount_ShouldReturnTransactionsByStatusAndMaximumAmount()
        {
            // Arrange
            mockTransaction.Setup(t => t.Status).Returns(TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.Amount).Returns(50);
            mockTransaction2.Setup(t => t.Id).Returns(2);
            mockTransaction2.Setup(t => t.Status).Returns(TransactionStatus.Unauthorised);
            chainblock.Add(mockTransaction2.Object);
            // Act
            var transactions = chainblock.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Unauthorised, 100).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction.Object); // Ensure the first transaction is the one with lower amount
            Assert.AreEqual(transactions[1], mockTransaction2.Object); // since ordering is by amount descending
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmount_ShouldReturnEmptyIfNoTransactionsWithStatusAndAmount()
        {
            // Act
            var transactions = chainblock.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Successfull, 100).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.IsEmpty(transactions); // Should return empty list if no transactions match the criteria
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescending_ShouldReturnTransactionsBySenderAndMinimumAmountDescending()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.From).Returns("Alice");
            mockTransaction2.Setup(t => t.Amount).Returns(200);
            mockTransaction2.Setup(t => t.Id).Returns(2);
            chainblock.Add(mockTransaction2.Object);
            // Act
            var transactions = chainblock.GetBySenderAndMinimumAmountDescending("Alice", 100).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction2.Object); // Ensure the first transaction is the one with higher amount
            Assert.AreEqual(transactions[1], mockTransaction.Object); // since ordering is by amount descending
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescending_ShouldThrowExceptionIfNoTransactionsBySender()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetBySenderAndMinimumAmountDescending("NonExistentSender", 100));
        }

        [Test]
        public void GetByReceiverAndAmountRange_ShouldReturnTransactionsByReceiverAndAmountRange()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);

            var mockTransaction2 = new Mock<ITransaction>();
            mockTransaction2.Setup(t => t.To).Returns("Bob");
            mockTransaction2.Setup(t => t.Amount).Returns(150);
            mockTransaction2.Setup(t => t.Id).Returns(2);
            chainblock.Add(mockTransaction2.Object);
            // Act
            var transactions = chainblock.GetByReceiverAndAmountRange("Bob", 100, 200).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction2.Object); // Ensure the first transaction is the one with higher amount
            Assert.AreEqual(transactions[1], mockTransaction.Object); // since ordering is by amount descending (then by id)
        }

        [Test]
        public void GetByReciverAndAmountRange_ShouldThrowExceptionIfNoTransactionsByReceiver()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => chainblock.GetByReceiverAndAmountRange("NonExistentReceiver", 100, 200));
        }

        [Test]
        public void GetAllInAmountRange_ShouldReturnTransactionsInAmountRange()
        {
            // Arrange
            chainblock.Add(mockTransaction.Object);
            // Act
            var transactions = chainblock.GetAllInAmountRange(100, 200).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.AreEqual(transactions[0], mockTransaction.Object);
        }

        [Test]
        public void GetAllInAmountRange_ShouldReturnEmptyIfNoTransactionsInRange()
        {
            // Act
            var transactions = chainblock.GetAllInAmountRange(200, 300).ToList();
            // Assert
            Assert.IsNotNull(transactions);
            Assert.IsEmpty(transactions); // Should return empty list if no transactions match the criteria
        }
    }
}