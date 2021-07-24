# Why load balancer

We have solved the problem of scaling up adn down when resource are needed by the application, but we still need a way to redirect traffic to the new created nodes/VMs to ensure that the load is distributed evenly accross the VM resource pool.

## Few definitions

### Backend pool

This is the pool of VMs among which the load has to be distributed evenly.

### Frontend IP

This the public IP or url which the end users are hitting to access the application.

### Health Probe

This is used by the load balancer to understand whether the nodes / VMs are healthy or not. In this we define kind of a ping request or a heartbeat, i.e. please at regular intervals send a request to the virtual machine on a particular port number and if you get a response back within a required threshold limit, then you can deem that instance as healthy and send the user request to the Node/VM.

### Load balancing rules

Now we know that we have to direct the traffic to the backend pool, we still need to know which port (like port 80 or 443) of the VMs to send the traffic and using what scheduling protocol.

## Steps to create a load balancer

1. Create a backend pool i.e. VMs (make sure these VMs are havings IIS server, this will be helpful for futher steps)
2. Make VMs part of an availability set or a VM scale set and they should also be in the same virtual network
3. place a default.html file on both the server. This will used to test that requests are going to a particular server after hitting a public ip address for the load balancer
4. Create a load balancer with the above information.
5. Confgure a health probe to ensure that the requests are being sent to a healthy VM or node
6. Create Load balancing rule to distribute rule

**Note:**
Even if you have a public load balancer, you don't need to have to define public ip address for the VMs for the backend pool. The actual communication happens with the help of internal IP address.
We are only adding the public IPs to the VMs in this exercise because we want to install a IIS server by Remoting into that VMs

### To remove Network Interface

go the VM instance-> networking-> network interface -> ip configuration-> ip config-> disassociate the public IP
