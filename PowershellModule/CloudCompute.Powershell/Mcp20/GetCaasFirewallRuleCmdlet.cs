﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Powershell.Mcp20
{
    using System.Management.Automation;
    using Api.Client;
    using Api.Contracts.Network20;
    using Api.Contracts.Requests.Network20;

    [Cmdlet(VerbsCommon.Get, "CaasFirewallRule")]
    [OutputType(typeof(FirewallRuleType))]
    public class GetCaasFirewallRuleCmdlet : PsCmdletCaasPagedWithConnectionBase
    {
        /// <summary>
		///     Gets or sets the firewall rule name.
		/// </summary>
		[Parameter(Mandatory = false, ParameterSetName = "Filtered", HelpMessage = "The firewall rule name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the network domain.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "Filtered", ValueFromPipeline = true, HelpMessage = "The network domain")]
        public NetworkDomainType NetworkDomain { get; set; }

        /// <summary>
        ///     Gets or sets firewall rule id.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "Filtered", HelpMessage = "The firewall rule id")]
        public Guid FirewallRuleId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            try
            {
                this.WritePagedObject(Connection.ApiClient.Networking.FirewallRule.GetFirewallRulesPaginated(
                    (ParameterSetName.Equals("Filtered")
                        ? new FirewallRuleListOptions
                        {
                            Id = FirewallRuleId != Guid.Empty ? FirewallRuleId : (Guid?) null,
                            Name = Name,
                            NetworkDomainId = Guid.Parse(NetworkDomain.id)
                        }
                        : null), PageableRequest).Result);
            }
            catch (AggregateException ae)
            {
                ae.Handle(
                    e =>
                    {
                        if (e is ComputeApiException)
                        {
                            WriteError(
                                new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, Connection));
                        }
                        else
                        {
                            ThrowTerminatingError(
                                new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, Connection));
                        }

                        return true;
                    });
            }            
        }
    }
}
