﻿Update-CaasPortList
===================

## SYNOPSIS

Update-CaasPortList -Id <guid> [-Description <string>] [-Port <PortListPort[]>] [-ChildPortListId <string[]>] [-ChildPortList <PortListType[]>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

Update-CaasPortList -PortList <PortListType> [-Description <string>] [-Port <PortListPort[]>] [-ChildPortListId <string[]>] [-ChildPortList <PortListType[]>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                                                                                                                                    

----------                                                                                                                                                                                                                    

{@{name=Update-CaasPortList; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=Update-CaasPortList; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
```

## DESCRIPTION


## PARAMETERS
### -ChildPortList &lt;PortListType[]&gt;
Define one or more individual Port Lists on the same Network Domain
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -ChildPortListId &lt;string[]&gt;
Define one or more individual Port Lists on the same Network Domain
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Connection &lt;ComputeServiceConnection&gt;
The CaaS Connection created by New-CaasConnection
```
Position?                    Named
Accept pipeline input?       true (ByPropertyName)
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Description &lt;string&gt;
The Port List description
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Id &lt;guid&gt;
The Port list id
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_PortListId
Aliases                      None
Dynamic?                     false
```
 
### -Port &lt;PortListPort[]&gt;
Define one or more individual Ports or ranges of Ports. Use New CaasPortRangeType command to create type
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -PortList &lt;PortListType&gt;
The Port list id
```
Position?                    Named
Accept pipeline input?       true (ByValue)
Parameter set name           With_PortList
Aliases                      None
Dynamic?                     false
```

## INPUTS
DD.CBU.Compute.Api.Contracts.Network20.PortListType
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.ResponseType


## NOTES


## EXAMPLES
