namespace TransactionSystem
{
    public class TransactionDeposit : Transaction
    {
        private ITransactionEntity _entity;

        public ItransactionItem _item;

        public TransactionDeposit(ITransactionEntity entity, ItransactionItem item)
        {
            _entity = entity;
            _item = item;
        }

        public override void Execute()
        {
            PerformTransactionExecution(true, () =>
            {
                this._entity.Deposit(this._item.Id, this._item.Amount);
            });
        }

        public override void RollBackTransaction()
        {
            //PerformTransactionRollback(_toAccount.Balance >= _amount, () =>
            //{
            //    _toAccount.Balance -= _amount;
            //    _fromAccount.Balance += _amount;
            //});
        }
    }
}
