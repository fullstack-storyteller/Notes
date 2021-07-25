# Using Tools other than the Azure portal

- Powershell
- Azure Command line interface (Azure CLI)
- Azure Cloudshell (Powershell/bash inside Azure portal)

## Using Powershell (Execution Engine)

- Open powershell as Administrator
- Make sure that the execution policy in powerhell is set as `RemoteSigned`, if not run command `Set-ExecutionPolicy RemoteSigned`

  - ![execution policy](./images/59.PNG)
  - This will allow us to install remotely signed packages

- The we run the command `Install-Module -Name Az -AllowClobber -Scope CurrentUser` to install all of the azure modules for the current user
- Run command `Import-Module Az -Verbose`
- Once modules are imported, run `Connect-AzAccount` to login into microsoft Azure
- Now we can run Azure commands: Run `Get-AzResourceGroup -Location centralus` to get resources from Central US region

## Azure CLI

It is a dedicate command line interface that we use to work with azure. While powershell can with the variety of resources as well as underlying windows system, but Azure CLI is meant specific to work with Azure based resources.

Install the Azure CLI from microsoft website. The you can launch the Azure CLI either from command line interface or from the powershell.

- In command prompt, issue command `az login` and give credentials.

- Once logged in, you can issue this command to return the resource groups from the a specific region: `az group list --query "[?location=='eastus']"`
