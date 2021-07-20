# Why Azure VM Scale Sets

For an application if resource demand needs to scale, i.e. if the CPU is almost 90 % and we keep increasing the cpu cores, there is limited to what we can increase up / scale up. in such scenario we may have to scale out, i.e. create more VMs similar to the existing one on demand to distribute the load.
We should be doing this automatically as the demand increases, and that's where scale sets come in.
