﻿using System;
using System.Management.Automation;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.Network20;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Powershell.Mcp20
{
    using System.ComponentModel;
    using Api.Contracts.Network;

    /// <summary>
    ///     The set VIP Virutal Listener CmdLet
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "CaasVIPVirtualListener")]
    [OutputType(typeof(ResponseType))]
    public class SetCaasVIPVirtualListenerCmdlet : PSCmdletCaasWithConnectionBase
    {
        /// <summary>
        ///     Gets or sets the virtual listener.
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "The virtual listener")]
        public VirtualListenerType VirtualListener { get; set; }
        
        /// <summary>
		///     Gets or sets the virtual listener description.
		/// </summary>
		[Parameter(Mandatory = false, HelpMessage = "The virtual listener description")]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the status.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Status")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///     Gets or sets the connection limit.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The VIP virtual listener Connection Limit")]
        public int ConnectionLimit { get; set; }

        /// <summary>
        ///     Gets or sets the connection rate limit.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The VIP virtual listener Connection Rate Limit")]
        public int ConnectionRateLimit { get; set; }

        /// <summary>
        ///     Gets or sets the source port preservation.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Source Port Preservation")]
        public string SourcePortPreservation { get; set; }

        /// <summary>
        ///     Gets or sets the pool id.
        /// </summary>
   
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Pool Id")]
        public Guid? PoolId { get; set; }

        /// <summary>
        ///     Gets or sets the client clone pool id.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Client Clone Pool Id")]
        public Guid? ClientClonePoolId { get; set; }

        /// <summary>
        ///     Gets or sets the persistence profile id.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Persistence Profile Id")]
        public string PersistenceProfileId { get; set; }

        /// <summary>
        ///     Gets or sets the fallback persistence profile id.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Fallback Persistence Profile Id")]
        public string FallbackPersistenceProfileId { get; set; }

        /// <summary>
        ///     Gets or sets the optimization profile id.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener Optimization Profile Id")]
        public string OptimizationProfileId { get; set; }

        /// <summary>
        ///     Gets or sets the iRule id.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The VIP virtual listener iRule Ids")]
        public string[] iRuleId { get; set; }

        public SetCaasVIPVirtualListenerCmdlet()
        {
            PoolId = Guid.Empty;
            ClientClonePoolId = Guid.Empty;
        }

        /// <summary>
        ///     The process record method.
        /// </summary>
        protected override void ProcessRecord()
        {
            ResponseType response = null;
            base.ProcessRecord();
            try
            {
                var virtualListener = new editVirtualListener
                {
                    id = VirtualListener.id,
                    description = Description,
                    enabled = Enabled.GetValueOrDefault(),
                    enabledSpecified = Enabled.HasValue,
                    connectionLimit = ConnectionLimit,
                    connectionRateLimit = ConnectionRateLimit,
                    sourcePortPreservation = SourcePortPreservation,
                    poolId = PoolId.HasValue && PoolId.Value != Guid.Empty ? PoolId.Value.ToString() : null,
                    poolIdSpecified = !PoolId.HasValue || PoolId.Value != Guid.Empty,
                    clientClonePoolId = ClientClonePoolId.HasValue && ClientClonePoolId.Value != Guid.Empty ? ClientClonePoolId.Value.ToString() : null,
                    clientClonePoolIdSpecified = !ClientClonePoolId.HasValue || ClientClonePoolId.Value != Guid.Empty,
                    persistenceProfileId = PersistenceProfileId,
                    fallbackPersistenceProfileId = FallbackPersistenceProfileId,
                    optimizationProfile = OptimizationProfileId,
                    iruleId = iRuleId
                };

                response = Connection.ApiClient.Networking.VipVirtualListener.EditVirtualListener(virtualListener).Result;
            }
            catch (AggregateException ae)
            {
                ae.Handle(
                    e =>
                    {
                        if (e is ComputeApiException)
                        {
                            WriteError(new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, Connection));
                        }
                        else
                        {
                            // if (e is HttpRequestException)
                            ThrowTerminatingError(new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, Connection));
                        }

                        return true;
                    });
            }

            WriteObject(response);
        }
    }
}