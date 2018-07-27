// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITransactionEntity.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ITransactionEntity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TransactionSystem
{
    /// <summary>
    /// The TransactionEntity interface.
    /// </summary>
    public interface ITransactionEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// The withdraw.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Withdraw(string id, decimal value);

        /// <summary>
        /// The deposit.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Deposit(string id, decimal value);
    }
}
