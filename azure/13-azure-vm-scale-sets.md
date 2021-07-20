# Why Azure VM Scale Sets

For an application if resource demand needs to scale, i.e. if the CPU is almost 90 % and we keep increasing the cpu cores, there is limited to what we can increase up / scale up. in such scenario we may have to scale out, i.e. create more VMs similar to the existing one on demand to distribute the load.
We should be doing this automatically as the demand increases, and that's where scale sets come in.

We define a scale set in Azure by defining the initial size of the scale set. you can also define various conditions like if cpu usage goes beyond 60%, automatically create a new VM.

**Note**: The Azure scale set will add a new VM when required, but it is you duty to define which type of VM and what workload it is supporting to ensure the new VM solves the issue by scaling out.
