﻿New-CaasIpAndPortType
===================

## SYNOPSIS

New-CaasIpAndPortType -IpAddressList <IpAddressListType> [-BeginPort <uint16>] [-EndPort <uint16>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

New-CaasIpAndPortType -IpAddressList <IpAddressListType> -PortList <PortListType> [-Connection <ComputeServiceConnection>] [<CommonParameters>]

New-CaasIpAndPortType -IpAddress <string> -PortList <PortListType> [-PrefixSize <int>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]

New-CaasIpAndPortType -IpAddress <string> [-PrefixSize <int>] [-BeginPort <uint16>] [-EndPort <uint16>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                                                                                                                                                                                                                                                                                                                                                                          

----------                                                                                                                                                                                                                                                                                                                                                                                                                                                          

{@{name=New-CaasIpAndPortType; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=New-CaasIpAndPortType; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=New-CaasIpAndPortType; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}, @{name=New-CaasIpAndPortType; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
```

## DESCRIPTION


## PARAMETERS
### -BeginPort &lt;uint16&gt;
The Port
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_IpAddress_Port, With_IpAddressList_Port
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
 
### -EndPort &lt;uint16&gt;
The Port rang end
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_IpAddressList_Port, With_IpAddress_Port
Aliases                      None
Dynamic?                     false
```
 
### -IpAddress &lt;string&gt;
The IP Address
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_IpAddress_PortList, With_IpAddress_Port
Aliases                      None
Dynamic?                     false
```
 
### -IpAddressList &lt;IpAddressListType&gt;
The IP Address List
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_IpAddressList_Port, With_IpAddressList_PortList
Aliases                      None
Dynamic?                     false
```
 
### -PortList &lt;PortListType&gt;
The Port List
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_IpAddress_PortList, With_IpAddressList_PortList
Aliases                      None
Dynamic?                     false
```
 
### -PrefixSize &lt;int&gt;
The IP Address Prefix size
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           With_IpAddress_PortList, With_IpAddress_Port
Aliases                      None
Dynamic?                     false
```

## INPUTS
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.IpAndPortType


## NOTES


## EXAMPLES
