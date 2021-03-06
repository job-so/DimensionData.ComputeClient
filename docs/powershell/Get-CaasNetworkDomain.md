﻿Get-CaasNetworkDomain
===================

## SYNOPSIS

Get-CaasNetworkDomain [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

Get-CaasNetworkDomain [-NetworkDomainId <guid>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

Get-CaasNetworkDomain [-NetworkDomainName <string>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                                                                                                                                                                                                                                                         

----------                                                                                                                                                                                                                                                                                                                                         

{@{name=Get-CaasNetworkDomain; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=Get-CaasNetworkDomain; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=Get-CaasNetworkDomain; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
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
 
### -NetworkDomainId &lt;guid&gt;
NetworkDomain id
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           FilterById
Aliases                      None
Dynamic?                     false
```
 
### -NetworkDomainName &lt;string&gt;
NetworkDomain name
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           FilterByName
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
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.NetworkDomainType


## NOTES


## EXAMPLES
