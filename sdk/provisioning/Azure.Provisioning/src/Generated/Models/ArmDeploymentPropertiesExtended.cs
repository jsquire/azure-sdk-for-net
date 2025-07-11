// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Deployment properties with additional details.
/// </summary>
public partial class ArmDeploymentPropertiesExtended : ProvisionableConstruct
{
    /// <summary>
    /// Denotes the state of provisioning.
    /// </summary>
    public BicepValue<ResourcesProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ResourcesProvisioningState>? _provisioningState;

    /// <summary>
    /// The correlation ID of the deployment.
    /// </summary>
    public BicepValue<string> CorrelationId 
    {
        get { Initialize(); return _correlationId!; }
    }
    private BicepValue<string>? _correlationId;

    /// <summary>
    /// The timestamp of the template deployment.
    /// </summary>
    public BicepValue<DateTimeOffset> Timestamp 
    {
        get { Initialize(); return _timestamp!; }
    }
    private BicepValue<DateTimeOffset>? _timestamp;

    /// <summary>
    /// The duration of the template deployment.
    /// </summary>
    public BicepValue<TimeSpan> Duration 
    {
        get { Initialize(); return _duration!; }
    }
    private BicepValue<TimeSpan>? _duration;

    /// <summary>
    /// Key/value pairs that represent deployment output.
    /// To assign an object to this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Outputs 
    {
        get { Initialize(); return _outputs!; }
    }
    private BicepValue<BinaryData>? _outputs;

    /// <summary>
    /// The list of resource providers needed for the deployment.
    /// </summary>
    public BicepList<ResourceProviderData> Providers 
    {
        get { Initialize(); return _providers!; }
    }
    private BicepList<ResourceProviderData>? _providers;

    /// <summary>
    /// The list of deployment dependencies.
    /// </summary>
    public BicepList<ArmDependency> Dependencies 
    {
        get { Initialize(); return _dependencies!; }
    }
    private BicepList<ArmDependency>? _dependencies;

    /// <summary>
    /// The URI referencing the template.
    /// </summary>
    public ArmDeploymentTemplateLink TemplateLink 
    {
        get { Initialize(); return _templateLink!; }
    }
    private ArmDeploymentTemplateLink? _templateLink;

    /// <summary>
    /// Deployment parameters.                          To assign an object to
    /// this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Parameters 
    {
        get { Initialize(); return _parameters!; }
    }
    private BicepValue<BinaryData>? _parameters;

    /// <summary>
    /// The URI referencing the parameters.
    /// </summary>
    public ArmDeploymentParametersLink ParametersLink 
    {
        get { Initialize(); return _parametersLink!; }
    }
    private ArmDeploymentParametersLink? _parametersLink;

    /// <summary>
    /// The extensions used in this deployment.
    /// </summary>
    public BicepList<ArmDeploymentExtensionDefinition> Extensions 
    {
        get { Initialize(); return _extensions!; }
    }
    private BicepList<ArmDeploymentExtensionDefinition>? _extensions;

    /// <summary>
    /// The deployment mode. Possible values are Incremental and Complete.
    /// </summary>
    public BicepValue<ArmDeploymentMode> Mode 
    {
        get { Initialize(); return _mode!; }
    }
    private BicepValue<ArmDeploymentMode>? _mode;

    /// <summary>
    /// The deployment on error behavior.
    /// </summary>
    public ErrorDeploymentExtended ErrorDeployment 
    {
        get { Initialize(); return _errorDeployment!; }
    }
    private ErrorDeploymentExtended? _errorDeployment;

    /// <summary>
    /// The hash produced for the template.
    /// </summary>
    public BicepValue<string> TemplateHash 
    {
        get { Initialize(); return _templateHash!; }
    }
    private BicepValue<string>? _templateHash;

    /// <summary>
    /// Array of provisioned resources.
    /// </summary>
    public BicepList<ArmResourceReference> OutputResourceDetails 
    {
        get { Initialize(); return _outputResourceDetails!; }
    }
    private BicepList<ArmResourceReference>? _outputResourceDetails;

    /// <summary>
    /// Array of validated resources.
    /// </summary>
    public BicepList<ArmResourceReference> ValidatedResourceDetails 
    {
        get { Initialize(); return _validatedResourceDetails!; }
    }
    private BicepList<ArmResourceReference>? _validatedResourceDetails;

    /// <summary>
    /// The deployment error.
    /// </summary>
    public BicepValue<ResponseError> Error 
    {
        get { Initialize(); return _error!; }
    }
    private BicepValue<ResponseError>? _error;

    /// <summary>
    /// Contains diagnostic information collected during validation process.
    /// </summary>
    public BicepList<DeploymentDiagnosticsDefinition> Diagnostics 
    {
        get { Initialize(); return _diagnostics!; }
    }
    private BicepList<DeploymentDiagnosticsDefinition>? _diagnostics;

    /// <summary>
    /// The validation level of the deployment.
    /// </summary>
    public BicepValue<ValidationLevel> ValidationLevel 
    {
        get { Initialize(); return _validationLevel!; }
    }
    private BicepValue<ValidationLevel>? _validationLevel;

    /// <summary>
    /// Creates a new ArmDeploymentPropertiesExtended.
    /// </summary>
    public ArmDeploymentPropertiesExtended()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ArmDeploymentPropertiesExtended.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _outputResources = DefineListProperty<SubResource>("OutputResources", ["outputResources"], isOutput: true);
        _validatedResources = DefineListProperty<SubResource>("ValidatedResources", ["validatedResources"], isOutput: true);
        _provisioningState = DefineProperty<ResourcesProvisioningState>("ProvisioningState", ["provisioningState"], isOutput: true);
        _correlationId = DefineProperty<string>("CorrelationId", ["correlationId"], isOutput: true);
        _timestamp = DefineProperty<DateTimeOffset>("Timestamp", ["timestamp"], isOutput: true);
        _duration = DefineProperty<TimeSpan>("Duration", ["duration"], isOutput: true, format: "P");
        _outputs = DefineProperty<BinaryData>("Outputs", ["outputs"], isOutput: true);
        _providers = DefineListProperty<ResourceProviderData>("Providers", ["providers"], isOutput: true);
        _dependencies = DefineListProperty<ArmDependency>("Dependencies", ["dependencies"], isOutput: true);
        _templateLink = DefineModelProperty<ArmDeploymentTemplateLink>("TemplateLink", ["templateLink"], isOutput: true);
        _parameters = DefineProperty<BinaryData>("Parameters", ["parameters"], isOutput: true);
        _parametersLink = DefineModelProperty<ArmDeploymentParametersLink>("ParametersLink", ["parametersLink"], isOutput: true);
        _extensions = DefineListProperty<ArmDeploymentExtensionDefinition>("Extensions", ["extensions"], isOutput: true);
        _mode = DefineProperty<ArmDeploymentMode>("Mode", ["mode"], isOutput: true);
        _errorDeployment = DefineModelProperty<ErrorDeploymentExtended>("ErrorDeployment", ["onErrorDeployment"], isOutput: true);
        _templateHash = DefineProperty<string>("TemplateHash", ["templateHash"], isOutput: true);
        _outputResourceDetails = DefineListProperty<ArmResourceReference>("OutputResourceDetails", ["outputResources"], isOutput: true);
        _validatedResourceDetails = DefineListProperty<ArmResourceReference>("ValidatedResourceDetails", ["validatedResources"], isOutput: true);
        _error = DefineProperty<ResponseError>("Error", ["error"], isOutput: true);
        _diagnostics = DefineListProperty<DeploymentDiagnosticsDefinition>("Diagnostics", ["diagnostics"], isOutput: true);
        _validationLevel = DefineProperty<ValidationLevel>("ValidationLevel", ["validationLevel"], isOutput: true);
    }
}
