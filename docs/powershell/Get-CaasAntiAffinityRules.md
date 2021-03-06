﻿Get-CaasAntiAffinityRules
===================

## SYNOPSIS

Get-CaasAntiAffinityRules -NetworkDomain <NetworkDomainType> [-RuleId <guid>] [-State <string>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

Get-CaasAntiAffinityRules -Network <NetworkWithLocationsNetwork> [-RuleId <guid>] [-State <string>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

Get-CaasAntiAffinityRules -Server <ServerType> [-RuleId <guid>] [-State <string>] [-PageNumber <int>] [-PageSize <int>] [-OrderBy <string>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                                                                                                                                                                                                                                                                     

----------                                                                                                                                                                                                                                                                                                                                                     

{@{name=Get-CaasAntiAffinityRules; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=Get-CaasAntiAffinityRules; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=Get-CaasAntiAffinityRules; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
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
 
### -Network &lt;NetworkWithLocationsNetwork&gt;
The network
```
Position?                    Named
Accept pipeline input?       true (ByValue)
Parameter set name           NetworkFilter
Aliases                      None
Dynamic?                     false
```
 
### -NetworkDomain &lt;NetworkDomainType&gt;
The network domain
```
Position?                    Named
Accept pipeline input?       true (ByValue)
Parameter set name           NetworkDomainFilter
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
 
### -RuleId &lt;guid&gt;
The anti-afiinity rule id
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Server &lt;ServerType&gt;
The Server
```
Position?                    Named
Accept pipeline input?       true (ByValue)
Parameter set name           ServerFilter
Aliases                      None
Dynamic?                     false
```
 
### -State &lt;string&gt;
The anti-afiinity rule state
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```

## INPUTS
DD.CBU.Compute.Api.Contracts.Network20.NetworkDomainType
DD.CBU.Compute.Api.Contracts.Network.NetworkWithLocationsNetwork
DD.CBU.Compute.Api.Contracts.Network20.ServerType
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.AntiAffinityRuleType


## NOTES


## EXAMPLES
