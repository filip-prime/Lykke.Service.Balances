# Lykke.Service.Balances 

# Purpose

  - Keeping the read-model of balances of each wallet, and of the whole market.

# Contracts

Input (v1, Matching Engine events; RabbitMQ, protobuf):
  - CashInEvent, CashOutEvent, CashTransferEvent, ExecutionEvent.

Input (v2, "balances" context; RabbitMQ, protobuf):
  - Input (v2): BalanceUpdatedEvent.

Output (HTTP):
  - get wallet balances by wallet id;
  - get wallet balances by wallet id and asset id;
  - get total market balances;

# Scaling
Current implementation is: job (Lykke.Job.Balances) + service (Lykke.Service.Balances).
Resources: 

| Image | Resources | Default instances number | Max instances |
| ------ | ------ | ------ | ------ |
| Lykke.Job.Balances | C1-R1 | 1 | 1 |
| Lykke.Service.Balances | C0-R0 | 2 | 10 |

# Dependencies
  - Azure Table Storage (logs and data);
  - Redis (cache);
  - RabbitMQ (new ME events; Registration events; Cqrs);
