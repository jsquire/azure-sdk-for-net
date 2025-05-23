// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// Description of NetWorkRuleSet - IpRules resource.
/// </summary>
public partial class ServiceBusNetworkRuleSetIPRules : ProvisionableConstruct
{
    /// <summary>
    /// IP Mask.
    /// </summary>
    public BicepValue<string> IPMask 
    {
        get { Initialize(); return _iPMask!; }
        set { Initialize(); _iPMask!.Assign(value); }
    }
    private BicepValue<string>? _iPMask;

    /// <summary>
    /// The IP Filter Action.
    /// </summary>
    public BicepValue<ServiceBusNetworkRuleIPAction> Action 
    {
        get { Initialize(); return _action!; }
        set { Initialize(); _action!.Assign(value); }
    }
    private BicepValue<ServiceBusNetworkRuleIPAction>? _action;

    /// <summary>
    /// Creates a new ServiceBusNetworkRuleSetIPRules.
    /// </summary>
    public ServiceBusNetworkRuleSetIPRules()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ServiceBusNetworkRuleSetIPRules.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _iPMask = DefineProperty<string>("IPMask", ["ipMask"]);
        _action = DefineProperty<ServiceBusNetworkRuleIPAction>("Action", ["action"]);
    }
}
