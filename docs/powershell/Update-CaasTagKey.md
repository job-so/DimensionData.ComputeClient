﻿Update-CaasTagKey
===================

## SYNOPSIS

Update-CaasTagKey -Id <string> [-Name <string>] [-Description <string>] [-ValueRequired <bool>] [-DisplayOnReport <bool>] [-Connection <ComputeServiceConnection>] [<CommonParameters>]


## SYNTAX
```powershell
syntaxItem                                                                                                   

----------                                                                                                   

{@{name=Update-CaasTagKey; CommonParameters=True; WorkflowCommonParameters=False; parameter=System.Object[]}}
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
 
### -Description &lt;string&gt;
The description of tag key
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -DisplayOnReport &lt;bool&gt;
Whether the Tag Key will be displayed on reports
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Id &lt;string&gt;
The id of tag key
```
Position?                    Named
Accept pipeline input?       true (ByValue, ByPropertyName)
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -Name &lt;string&gt;
The name of tag key
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```
 
### -ValueRequired &lt;bool&gt;
Whether value can be considered optional when the Tag Key is applied to a Cloud asset
```
Position?                    Named
Accept pipeline input?       false
Parameter set name           (All)
Aliases                      None
Dynamic?                     false
```

## INPUTS
System.String
DD.CBU.Compute.Powershell.ComputeServiceConnection


## OUTPUTS
DD.CBU.Compute.Api.Contracts.Network20.ResponseType


## NOTES


## EXAMPLES
