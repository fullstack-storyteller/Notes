# Azure Traffic Manager Service

This is a DNS based routing service. While Azure Load balancer routes traffic based on network using tcp protocol and ip addresses.
Ex: Microsoft.com is a DNS name. It is linked to an IP which is linked to a resource where our request is routed tp Microsoft.com

**_Hence, Azure traffic manager can be used to route requests between multiple dns end points_**

To work with Azure traffic manager, first create a traffic manager profile. You can have multiple DNS endpoint which connect on to the traffic manager profile.

**Very important Note:** Azure Load balancer can only route traffic within a particular region, but Azure traffic manager is not bound by region. **IT IS A GLOBAL RESOURCE**

You can also have multiple routing methods that are available to you.

1. Priority \[route traffic to higher priority region/dns end points first.\]
2. Weightage \[ distribute traffic between region/dns end points by weightage \]

Note: there are several other methods available. Check [this](https://docs.microsoft.com/en-us/azure/traffic-manager/traffic-manager-overview).

## How to work with Azure Traffic Manager

1. We create 2 azure web apps
2. We deploy these webapps in different regions and
3. Then we define a traffice manager profile with these two end point
4. Once we bring bring down the primary web app, we should see that the traffic is being sent to the secondary web app
5. Please make sure to deploy same apps with different index.html to ensure we can identify from which region the site is being served. Publish the web app to both the regions

**Note:** make sure that the azure app service plan attached to the web apps is either standard or higher to use traffice manager

After publishing to both the regions the deployed sites look as below:

![Deployed both](./images/47.png)
