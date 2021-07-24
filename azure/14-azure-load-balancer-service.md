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
