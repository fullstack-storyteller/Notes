# Azure Virtual Network

IP address helps to identify any resource in the internet.
When we spin up a VM in Azure, it needs to be part of a Virtual Network (VNet)

Azure Virtual Network consists of IP address range. It can be default what's supplied by Azure or even you can supply it yourself.

In a VNet,You can spinup subnet, which is a logical separation of resources within the VNet. Each subnet have an address range which will be the subset of the address range of the VNet. You can spinup VMs in these subnets.
Example:

- IP address: 10.0.0.0/16, address space \[ 10.0.0.0 - 10.0.255.255 (65536 addresses)\]
- Subnet1: (default subnet)10.0.0.0/24, address space \[ 10.0.0.0 - 10.0.0.255 (251 +5 azure reserved addresses)\]
- Subnet2: 10.0.1.0/24, address space \[ 10.0.1.0 - 10.0.1.255 (251 +5 azure reserved addresses) \]

**Private IP address** is the IP address from the address range of the subnets which the VMs or resources can used within the VNet to communicate with each other. This is not accessible outside the VNet.

**Public IP address** is the IP address which is assigned to a resource within a VNet, and this IP address is accessible from the open internet.

**Note:** _*It should be noted that we should design our Application in such a way that only those resources are exposed to internet via a subnet which are actually needed to be exposed. If we have two VMs one for web server another for database, then it makes sense to have the Database VM inside a subnet which is different than the subnet where web server VM is located. And we can ensure that the database VM doesn't have a public IP. the Webserver VM can communicate with DB VM via the private IP address within the VNet.*_

**Note:** _*Ensure that the VMs and other resources are created within the same azure region as the VNet to be able to access the VNet.*_
