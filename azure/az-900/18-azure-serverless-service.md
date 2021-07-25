# Azure Serverless Services

Best Example: Azure functions

Here the underlying physical server and underlying compute architecture is managed by the service itself.

The help to:

- improve faster development, as the developer doesn't have to wait for the VM to get provisioned
- lessen maintenance overhead, as we don't have to maintaint the underlying VM

## Services include

- Azure functions: underlying compute is managed by Azure
  - You can just upload and execute your code
- Serverless Kubernetes: You can orchestrate the deployment of your container-based applications
  - You don't need to worry about the underlying infrastructure

## Serverless Workflows and Integration

- Azure Logic Apps: Here you can develop workflows
  - These workflows can be designed by users who don't have much development knowledge.
  - Azure Logic apps have a lot of integration with Azure and other third-party applications.
- Azure Event Grid: Here you can listen to events emitted from the Azure services. you can also develop your own custom events.
  - You canthen process the events accordingly
- Azure Service Bus: This is a messaging system that is available on Azure
