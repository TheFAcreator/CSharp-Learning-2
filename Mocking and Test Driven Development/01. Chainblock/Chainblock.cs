using Chainblock.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Chainblock
{
    public class Chainblock : IChainblock
    {
        private readonly ICollection<ITransaction> record;

        public Chainblock()
        {
            this.record = new Collection<ITransaction>();
        }

        public int Count => record.Count;

        public void Add(ITransaction tx)
        {
            if (!Contains(tx.Id))
                record.Add(tx);
        }

        public void RemoveTransactionById(int id)
        {
            if (!Contains(id))
            {
                throw new InvalidOperationException("Transaction with the given ID does not exist.");
            }

            var transaction = GetById(id);
            record.Remove(transaction);
        }

        public bool Contains(int id)
        {
            return record.Any(tx => tx.Id == id);
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (!Contains(id))
            {
                throw new ArgumentException("Transaction with the given ID does not exist.");
            }

            var transaction = GetById(id);
            transaction.Status = newStatus;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            return record.Where(tx => tx.Amount >= lo && tx.Amount <= hi);
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            return record.OrderByDescending(tx => tx.Amount).ThenBy(tx => tx.Id);
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            var filtered = GetByTransactionStatus(status);

            Dictionary<string, int> senders = new();
            foreach (var transaction in filtered)
            {
                if (!senders.ContainsKey(transaction.From))
                {
                    senders[transaction.From] = 0;
                }
                senders[transaction.From]++;
            }

            var result = new List<string>();
            foreach (var sender in senders.OrderByDescending(s => s.Value))
            {
                for (int i = 0; i < sender.Value; i++)
                {
                    result.Add(sender.Key);
                }
            }

            return result;
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            var filtered = GetByTransactionStatus(status);

            Dictionary<string, int> senders = new();
            foreach (var transaction in filtered)
            {
                if (!senders.ContainsKey(transaction.To))
                {
                    senders[transaction.To] = 0;
                }
                senders[transaction.To]++;
            }

            var result = new List<string>();
            foreach (var sender in senders.OrderByDescending(s => s.Value))
            {
                for (int i = 0; i < sender.Value; i++)
                {
                    result.Add(sender.Key);
                }
            }

            return result;
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            var result = record.Where(tx => tx.To == receiver && tx.Amount >= lo && tx.Amount < hi);

            if (!result.Any())
            {
                throw new InvalidOperationException("No transactions with the given receiver exist.");
            }
            return result.OrderByDescending(tx => tx.Amount).ThenBy(tx => tx.Id);
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            var result = record.Where(tx => tx.To == receiver);

            if (!result.Any())
            {
                throw new InvalidOperationException("No transactions with the given sender exist.");
            }
            return result.OrderByDescending(tx => tx.Amount).ThenBy(tx => tx.Id);
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            var result = record.Where(tx => tx.From == sender && tx.Amount >= amount);

            if (!result.Any())
            {
                throw new InvalidOperationException("No transactions with the given sender exist.");
            }
            return result.OrderByDescending(tx => tx.Amount);
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            var result = record.Where(tx => tx.From == sender);

            if (!result.Any())
            {
                throw new InvalidOperationException("No transactions with the given sender exist.");
            }
            return result.OrderByDescending(tx => tx.Amount);
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            return record
                .Where(tx => tx.Status == status && tx.Amount <= amount)
                .OrderByDescending(tx => tx.Amount);
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            var result = record.Where(tx => tx.Status == status);

            if (!result.Any())
            {
                throw new InvalidOperationException("No transactions with the given status exist.");
            }
            return result.OrderByDescending(tx => tx.Amount);
        }

        public ITransaction GetById(int id)
        {
            var transaction = record.FirstOrDefault(tx => tx.Id == id);

            if (transaction == null)
            {
                throw new InvalidOperationException("Transaction with the given ID does not exist.");
            }
            return transaction;
        }
    }
}
