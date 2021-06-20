# Azure Virtual Machine Service

Before public cloud, a business had to have a physical server on premises and they that physical server used to have Virtual Machines hosted in those physical server using Hyper-V or VM-Ware tools. The business was responsible for the underlying maintenance and storage of the physical server.

In public cloud like Azure, the business doesn't have to worry about the physical server, they just need to take care of the virtual machines (VM). The underlying physical structure is completely managed by the Cloud Vendor.

### The Virtual Machine Service is known as Infrastructure as a Service (IaaS)

## Benefits of Azure Virtual Machine Service

- No need to worry about managing the underlying hardware
- No need to buy the physical server hence, less upfront investment
- Pay only for the running cost of the virtual server
- Terminate the virtual server at any time.
- You can host different type of workloads
- You can deploy both windows and Linus based servers

## Deploying a VM

Note: When we deploy a VM, there are a few things which get deployed with it.

- The virtual Network, i.e. the VM needs to reside inside a virtual network
- The VM itself
- The disks for Holding OS Data as well as we can add a disk for holding the user Data
- The Network Interface card \[contains public and private IP addresses\]
- And Most importantly, Network Security group(NSG). It acts like a firewall

Note: To create any account you will need a subscriptiona and a resource group.

## Tings to note while creating a Azure VM resource

- Size: we can select from a variety of size (read computing power) of VMs. the estimated computing cost on a per month basis will be shown while creating a VM
- You will be prompted to enter a username and password, remember it for future usage. Your's is username is `manish` and `UZy@996sJR`
- By default, if you create a VMs the incoming traffic will be blocked (you will need to add a rule to NSG to allow traffic), but if you are creating a Windows OS virtual machine, you will see a rule will get setup for you by default to allow trafic on port 3389 via RDP.
