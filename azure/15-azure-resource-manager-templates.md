# Azure Resource Manager (ARM) Templates

- Using ARM templates, you can easily deploy your underlying infrastructure using infrastructure as code
- This can then help to automate repetitive deployments
- Lets say your company needs a test environment of 3 VMs, an Azure web app and an Azure web app and Azure sql database instance
- lets say this environment is used every week. And then after a week it needs to be rebuilt from scratch
- Doing this via the portal or via scripts can be a tedious task
- Using ARM templates, which is nothing but a JSON file helps to overcome obstacles when implementing such scenarios.

## The ARM template consists of the following

- Parameters: This helps to make the template more dynamic in nature. Here you can provide values during the deployment of the template.
- Variables: These are values that can be reused in the template.
- User-defined functions: You create your own customized functions
- Resources: This is where you specify the resources that are going to be deployed via this template.
- Output: These are values that get returned from the deployed resources.
