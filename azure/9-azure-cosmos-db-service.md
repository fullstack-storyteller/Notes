# Azure Cosmos DB Service

## What is NoSQL database and Why it was needed

Relational databases have normalization, which prevents the duplication of data. In the beginning disk space used to be a very big constraints for commerical application, but now not so much.

One of the main reasons for normalization was to reduce the duplication of data.
But with the demand for flexibility of data, simpler database system where the data schema can vary for each row, and we are not worried about joins.

NoSQL database = Non-relational database

## Azure Cosmos DB

- This is a fully managed NoSQL database
- latency access to your data
- There are also different API's available with Azure Cosmos DB
- These different API's allow you to store data in different formats

  > SQL API: here the data can be stored in JSON based documents and can be queried using SQL like commands

  > Table API: Store data in simple tables

  > MongoDB API: MongoDB is a document based database. If you have an existing MongoDB database in place and if you want to migrate to Azure, you can consider consmos DB

  > Cassandra API: This is a column based database

  > Gremlin API: This is a graph-based database.
