﻿Get-CaasDefaultHealthMonitors
===================

## SYNOPSIS

Get-CaasDefaultHealthMonitors -NetworkDomain <NetworkDomainType> [-Name <string>] [-MonitorId <guid>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                               

----------                                                                                                               

{@{name=Get-CaasDefaultHealthMonitors; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
```

## DESCRIPTION


## PARAMETERS
### -Connection &lt;ComputeServiceConnection&gt;
The CaaS Connection created by New-CaasConnection
```
Position?                    Named
Accept pipeline input?       true (ByPropertyName)
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -MonitorId &lt;guid&gt;
The health monitor id
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           Filtered
Aliases                      None
Dynamic?                     false
```
 
### -Name &lt;string&gt;
The health monitor name
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           Filtered
Aliases                      None
Dynamic?                     false
```
 
### -NetworkDomain &lt;NetworkDomainType&gt;
The network domain
```
Position?                    Named
Accept pipeline input?       true (ByValue)
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -OrderBy &lt;string&gt;
The Order By of the results, only supported for MCP2
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -PageNumber &lt;int&gt;
The Page Number of the result page, only supported for MCP2
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -PageSize &lt;int&gt;
The Page Size of the result page, only supported for MCP2
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```

## INPUTS
DD.CBU.Compute.Api.Contracts.Network20.NetworkDomainType
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.DefaultHealthMonitorType


## NOTES


## EXAMPLES
