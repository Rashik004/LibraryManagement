// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItransactionItem.cs" company="Cefalo">
//   
// </copyright>
// <summary>
//   Defines the ItransactionItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TransactionSystem
{
    using System;

    /// <summary>
    /// The transactionItem interface.
    /// </summary>
    public interface ItransactionItem
    {
        string Id { get; set; }
        Decimal Amount { get; set; }
    }
}
