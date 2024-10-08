// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Techniques of the assessment. </summary>
    public readonly partial struct SecurityAssessmentTechnique : IEquatable<SecurityAssessmentTechnique>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentTechnique"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAssessmentTechnique(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AbuseElevationControlMechanismValue = "Abuse Elevation Control Mechanism";
        private const string AccessTokenManipulationValue = "Access Token Manipulation";
        private const string AccountDiscoveryValue = "Account Discovery";
        private const string AccountManipulationValue = "Account Manipulation";
        private const string ActiveScanningValue = "Active Scanning";
        private const string ApplicationLayerProtocolValue = "Application Layer Protocol";
        private const string AudioCaptureValue = "Audio Capture";
        private const string BootOrLogonAutostartExecutionValue = "Boot or Logon Autostart Execution";
        private const string BootOrLogonInitializationScriptsValue = "Boot or Logon Initialization Scripts";
        private const string BruteForceValue = "Brute Force";
        private const string CloudInfrastructureDiscoveryValue = "Cloud Infrastructure Discovery";
        private const string CloudServiceDashboardValue = "Cloud Service Dashboard";
        private const string CloudServiceDiscoveryValue = "Cloud Service Discovery";
        private const string CommandAndScriptingInterpreterValue = "Command and Scripting Interpreter";
        private const string CompromiseClientSoftwareBinaryValue = "Compromise Client Software Binary";
        private const string CompromiseInfrastructureValue = "Compromise Infrastructure";
        private const string ContainerAndResourceDiscoveryValue = "Container and Resource Discovery";
        private const string CreateAccountValue = "Create Account";
        private const string CreateOrModifySystemProcessValue = "Create or Modify System Process";
        private const string CredentialsFromPasswordStoresValue = "Credentials from Password Stores";
        private const string DataDestructionValue = "Data Destruction";
        private const string DataEncryptedForImpactValue = "Data Encrypted for Impact";
        private const string DataFromCloudStorageObjectValue = "Data from Cloud Storage Object";
        private const string DataFromConfigurationRepositoryValue = "Data from Configuration Repository";
        private const string DataFromInformationRepositoriesValue = "Data from Information Repositories";
        private const string DataFromLocalSystemValue = "Data from Local System";
        private const string DataManipulationValue = "Data Manipulation";
        private const string DataStagedValue = "Data Staged";
        private const string DefacementValue = "Defacement";
        private const string DeobfuscateDecodeFilesOrInformationValue = "Deobfuscate/Decode Files or Information";
        private const string DiskWipeValue = "Disk Wipe";
        private const string DomainTrustDiscoveryValue = "Domain Trust Discovery";
        private const string DriveByCompromiseValue = "Drive-by Compromise";
        private const string DynamicResolutionValue = "Dynamic Resolution";
        private const string EndpointDenialOfServiceValue = "Endpoint Denial of Service";
        private const string EventTriggeredExecutionValue = "Event Triggered Execution";
        private const string ExfiltrationOverAlternativeProtocolValue = "Exfiltration Over Alternative Protocol";
        private const string ExploitPublicFacingApplicationValue = "Exploit Public-Facing Application";
        private const string ExploitationForClientExecutionValue = "Exploitation for Client Execution";
        private const string ExploitationForCredentialAccessValue = "Exploitation for Credential Access";
        private const string ExploitationForDefenseEvasionValue = "Exploitation for Defense Evasion";
        private const string ExploitationForPrivilegeEscalationValue = "Exploitation for Privilege Escalation";
        private const string ExploitationOfRemoteServicesValue = "Exploitation of Remote Services";
        private const string ExternalRemoteServicesValue = "External Remote Services";
        private const string FallbackChannelsValue = "Fallback Channels";
        private const string FileAndDirectoryDiscoveryValue = "File and Directory Discovery";
        private const string GatherVictimNetworkInformationValue = "Gather Victim Network Information";
        private const string HideArtifactsValue = "Hide Artifacts";
        private const string HijackExecutionFlowValue = "Hijack Execution Flow";
        private const string ImpairDefensesValue = "Impair Defenses";
        private const string ImplantContainerImageValue = "Implant Container Image";
        private const string IndicatorRemovalOnHostValue = "Indicator Removal on Host";
        private const string IndirectCommandExecutionValue = "Indirect Command Execution";
        private const string IngressToolTransferValue = "Ingress Tool Transfer";
        private const string InputCaptureValue = "Input Capture";
        private const string InterProcessCommunicationValue = "Inter-Process Communication";
        private const string LateralToolTransferValue = "Lateral Tool Transfer";
        private const string ManInTheMiddleValue = "Man-in-the-Middle";
        private const string MasqueradingValue = "Masquerading";
        private const string ModifyAuthenticationProcessValue = "Modify Authentication Process";
        private const string ModifyRegistryValue = "Modify Registry";
        private const string NetworkDenialOfServiceValue = "Network Denial of Service";
        private const string NetworkServiceScanningValue = "Network Service Scanning";
        private const string NetworkSniffingValue = "Network Sniffing";
        private const string NonApplicationLayerProtocolValue = "Non-Application Layer Protocol";
        private const string NonStandardPortValue = "Non-Standard Port";
        private const string ObtainCapabilitiesValue = "Obtain Capabilities";
        private const string ObfuscatedFilesOrInformationValue = "Obfuscated Files or Information";
        private const string OfficeApplicationStartupValue = "Office Application Startup";
        private const string OSCredentialDumpingValue = "OS Credential Dumping";
        private const string PermissionGroupsDiscoveryValue = "Permission Groups Discovery";
        private const string PhishingValue = "Phishing";
        private const string PreOSBootValue = "Pre-OS Boot";
        private const string ProcessDiscoveryValue = "Process Discovery";
        private const string ProcessInjectionValue = "Process Injection";
        private const string ProtocolTunnelingValue = "Protocol Tunneling";
        private const string ProxyValue = "Proxy";
        private const string QueryRegistryValue = "Query Registry";
        private const string RemoteAccessSoftwareValue = "Remote Access Software";
        private const string RemoteServiceSessionHijackingValue = "Remote Service Session Hijacking";
        private const string RemoteServicesValue = "Remote Services";
        private const string RemoteSystemDiscoveryValue = "Remote System Discovery";
        private const string ResourceHijackingValue = "Resource Hijacking";
        private const string ScheduledTaskJobValue = "Scheduled Task/Job";
        private const string ScreenCaptureValue = "Screen Capture";
        private const string SearchVictimOwnedWebsitesValue = "Search Victim-Owned Websites";
        private const string ServerSoftwareComponentValue = "Server Software Component";
        private const string ServiceStopValue = "Service Stop";
        private const string SignedBinaryProxyExecutionValue = "Signed Binary Proxy Execution";
        private const string SoftwareDeploymentToolsValue = "Software Deployment Tools";
        private const string SQLStoredProceduresValue = "SQL Stored Procedures";
        private const string StealOrForgeKerberosTicketsValue = "Steal or Forge Kerberos Tickets";
        private const string SubvertTrustControlsValue = "Subvert Trust Controls";
        private const string SupplyChainCompromiseValue = "Supply Chain Compromise";
        private const string SystemInformationDiscoveryValue = "System Information Discovery";
        private const string TaintSharedContentValue = "Taint Shared Content";
        private const string TrafficSignalingValue = "Traffic Signaling";
        private const string TransferDataToCloudAccountValue = "Transfer Data to Cloud Account";
        private const string TrustedRelationshipValue = "Trusted Relationship";
        private const string UnsecuredCredentialsValue = "Unsecured Credentials";
        private const string UserExecutionValue = "User Execution";
        private const string ValidAccountsValue = "Valid Accounts";
        private const string WindowsManagementInstrumentationValue = "Windows Management Instrumentation";
        private const string FileAndDirectoryPermissionsModificationValue = "File and Directory Permissions Modification";

        /// <summary> Abuse Elevation Control Mechanism. </summary>
        public static SecurityAssessmentTechnique AbuseElevationControlMechanism { get; } = new SecurityAssessmentTechnique(AbuseElevationControlMechanismValue);
        /// <summary> Access Token Manipulation. </summary>
        public static SecurityAssessmentTechnique AccessTokenManipulation { get; } = new SecurityAssessmentTechnique(AccessTokenManipulationValue);
        /// <summary> Account Discovery. </summary>
        public static SecurityAssessmentTechnique AccountDiscovery { get; } = new SecurityAssessmentTechnique(AccountDiscoveryValue);
        /// <summary> Account Manipulation. </summary>
        public static SecurityAssessmentTechnique AccountManipulation { get; } = new SecurityAssessmentTechnique(AccountManipulationValue);
        /// <summary> Active Scanning. </summary>
        public static SecurityAssessmentTechnique ActiveScanning { get; } = new SecurityAssessmentTechnique(ActiveScanningValue);
        /// <summary> Application Layer Protocol. </summary>
        public static SecurityAssessmentTechnique ApplicationLayerProtocol { get; } = new SecurityAssessmentTechnique(ApplicationLayerProtocolValue);
        /// <summary> Audio Capture. </summary>
        public static SecurityAssessmentTechnique AudioCapture { get; } = new SecurityAssessmentTechnique(AudioCaptureValue);
        /// <summary> Boot or Logon Autostart Execution. </summary>
        public static SecurityAssessmentTechnique BootOrLogonAutostartExecution { get; } = new SecurityAssessmentTechnique(BootOrLogonAutostartExecutionValue);
        /// <summary> Boot or Logon Initialization Scripts. </summary>
        public static SecurityAssessmentTechnique BootOrLogonInitializationScripts { get; } = new SecurityAssessmentTechnique(BootOrLogonInitializationScriptsValue);
        /// <summary> Brute Force. </summary>
        public static SecurityAssessmentTechnique BruteForce { get; } = new SecurityAssessmentTechnique(BruteForceValue);
        /// <summary> Cloud Infrastructure Discovery. </summary>
        public static SecurityAssessmentTechnique CloudInfrastructureDiscovery { get; } = new SecurityAssessmentTechnique(CloudInfrastructureDiscoveryValue);
        /// <summary> Cloud Service Dashboard. </summary>
        public static SecurityAssessmentTechnique CloudServiceDashboard { get; } = new SecurityAssessmentTechnique(CloudServiceDashboardValue);
        /// <summary> Cloud Service Discovery. </summary>
        public static SecurityAssessmentTechnique CloudServiceDiscovery { get; } = new SecurityAssessmentTechnique(CloudServiceDiscoveryValue);
        /// <summary> Command and Scripting Interpreter. </summary>
        public static SecurityAssessmentTechnique CommandAndScriptingInterpreter { get; } = new SecurityAssessmentTechnique(CommandAndScriptingInterpreterValue);
        /// <summary> Compromise Client Software Binary. </summary>
        public static SecurityAssessmentTechnique CompromiseClientSoftwareBinary { get; } = new SecurityAssessmentTechnique(CompromiseClientSoftwareBinaryValue);
        /// <summary> Compromise Infrastructure. </summary>
        public static SecurityAssessmentTechnique CompromiseInfrastructure { get; } = new SecurityAssessmentTechnique(CompromiseInfrastructureValue);
        /// <summary> Container and Resource Discovery. </summary>
        public static SecurityAssessmentTechnique ContainerAndResourceDiscovery { get; } = new SecurityAssessmentTechnique(ContainerAndResourceDiscoveryValue);
        /// <summary> Create Account. </summary>
        public static SecurityAssessmentTechnique CreateAccount { get; } = new SecurityAssessmentTechnique(CreateAccountValue);
        /// <summary> Create or Modify System Process. </summary>
        public static SecurityAssessmentTechnique CreateOrModifySystemProcess { get; } = new SecurityAssessmentTechnique(CreateOrModifySystemProcessValue);
        /// <summary> Credentials from Password Stores. </summary>
        public static SecurityAssessmentTechnique CredentialsFromPasswordStores { get; } = new SecurityAssessmentTechnique(CredentialsFromPasswordStoresValue);
        /// <summary> Data Destruction. </summary>
        public static SecurityAssessmentTechnique DataDestruction { get; } = new SecurityAssessmentTechnique(DataDestructionValue);
        /// <summary> Data Encrypted for Impact. </summary>
        public static SecurityAssessmentTechnique DataEncryptedForImpact { get; } = new SecurityAssessmentTechnique(DataEncryptedForImpactValue);
        /// <summary> Data from Cloud Storage Object. </summary>
        public static SecurityAssessmentTechnique DataFromCloudStorageObject { get; } = new SecurityAssessmentTechnique(DataFromCloudStorageObjectValue);
        /// <summary> Data from Configuration Repository. </summary>
        public static SecurityAssessmentTechnique DataFromConfigurationRepository { get; } = new SecurityAssessmentTechnique(DataFromConfigurationRepositoryValue);
        /// <summary> Data from Information Repositories. </summary>
        public static SecurityAssessmentTechnique DataFromInformationRepositories { get; } = new SecurityAssessmentTechnique(DataFromInformationRepositoriesValue);
        /// <summary> Data from Local System. </summary>
        public static SecurityAssessmentTechnique DataFromLocalSystem { get; } = new SecurityAssessmentTechnique(DataFromLocalSystemValue);
        /// <summary> Data Manipulation. </summary>
        public static SecurityAssessmentTechnique DataManipulation { get; } = new SecurityAssessmentTechnique(DataManipulationValue);
        /// <summary> Data Staged. </summary>
        public static SecurityAssessmentTechnique DataStaged { get; } = new SecurityAssessmentTechnique(DataStagedValue);
        /// <summary> Defacement. </summary>
        public static SecurityAssessmentTechnique Defacement { get; } = new SecurityAssessmentTechnique(DefacementValue);
        /// <summary> Deobfuscate/Decode Files or Information. </summary>
        public static SecurityAssessmentTechnique DeobfuscateDecodeFilesOrInformation { get; } = new SecurityAssessmentTechnique(DeobfuscateDecodeFilesOrInformationValue);
        /// <summary> Disk Wipe. </summary>
        public static SecurityAssessmentTechnique DiskWipe { get; } = new SecurityAssessmentTechnique(DiskWipeValue);
        /// <summary> Domain Trust Discovery. </summary>
        public static SecurityAssessmentTechnique DomainTrustDiscovery { get; } = new SecurityAssessmentTechnique(DomainTrustDiscoveryValue);
        /// <summary> Drive-by Compromise. </summary>
        public static SecurityAssessmentTechnique DriveByCompromise { get; } = new SecurityAssessmentTechnique(DriveByCompromiseValue);
        /// <summary> Dynamic Resolution. </summary>
        public static SecurityAssessmentTechnique DynamicResolution { get; } = new SecurityAssessmentTechnique(DynamicResolutionValue);
        /// <summary> Endpoint Denial of Service. </summary>
        public static SecurityAssessmentTechnique EndpointDenialOfService { get; } = new SecurityAssessmentTechnique(EndpointDenialOfServiceValue);
        /// <summary> Event Triggered Execution. </summary>
        public static SecurityAssessmentTechnique EventTriggeredExecution { get; } = new SecurityAssessmentTechnique(EventTriggeredExecutionValue);
        /// <summary> Exfiltration Over Alternative Protocol. </summary>
        public static SecurityAssessmentTechnique ExfiltrationOverAlternativeProtocol { get; } = new SecurityAssessmentTechnique(ExfiltrationOverAlternativeProtocolValue);
        /// <summary> Exploit Public-Facing Application. </summary>
        public static SecurityAssessmentTechnique ExploitPublicFacingApplication { get; } = new SecurityAssessmentTechnique(ExploitPublicFacingApplicationValue);
        /// <summary> Exploitation for Client Execution. </summary>
        public static SecurityAssessmentTechnique ExploitationForClientExecution { get; } = new SecurityAssessmentTechnique(ExploitationForClientExecutionValue);
        /// <summary> Exploitation for Credential Access. </summary>
        public static SecurityAssessmentTechnique ExploitationForCredentialAccess { get; } = new SecurityAssessmentTechnique(ExploitationForCredentialAccessValue);
        /// <summary> Exploitation for Defense Evasion. </summary>
        public static SecurityAssessmentTechnique ExploitationForDefenseEvasion { get; } = new SecurityAssessmentTechnique(ExploitationForDefenseEvasionValue);
        /// <summary> Exploitation for Privilege Escalation. </summary>
        public static SecurityAssessmentTechnique ExploitationForPrivilegeEscalation { get; } = new SecurityAssessmentTechnique(ExploitationForPrivilegeEscalationValue);
        /// <summary> Exploitation of Remote Services. </summary>
        public static SecurityAssessmentTechnique ExploitationOfRemoteServices { get; } = new SecurityAssessmentTechnique(ExploitationOfRemoteServicesValue);
        /// <summary> External Remote Services. </summary>
        public static SecurityAssessmentTechnique ExternalRemoteServices { get; } = new SecurityAssessmentTechnique(ExternalRemoteServicesValue);
        /// <summary> Fallback Channels. </summary>
        public static SecurityAssessmentTechnique FallbackChannels { get; } = new SecurityAssessmentTechnique(FallbackChannelsValue);
        /// <summary> File and Directory Discovery. </summary>
        public static SecurityAssessmentTechnique FileAndDirectoryDiscovery { get; } = new SecurityAssessmentTechnique(FileAndDirectoryDiscoveryValue);
        /// <summary> Gather Victim Network Information. </summary>
        public static SecurityAssessmentTechnique GatherVictimNetworkInformation { get; } = new SecurityAssessmentTechnique(GatherVictimNetworkInformationValue);
        /// <summary> Hide Artifacts. </summary>
        public static SecurityAssessmentTechnique HideArtifacts { get; } = new SecurityAssessmentTechnique(HideArtifactsValue);
        /// <summary> Hijack Execution Flow. </summary>
        public static SecurityAssessmentTechnique HijackExecutionFlow { get; } = new SecurityAssessmentTechnique(HijackExecutionFlowValue);
        /// <summary> Impair Defenses. </summary>
        public static SecurityAssessmentTechnique ImpairDefenses { get; } = new SecurityAssessmentTechnique(ImpairDefensesValue);
        /// <summary> Implant Container Image. </summary>
        public static SecurityAssessmentTechnique ImplantContainerImage { get; } = new SecurityAssessmentTechnique(ImplantContainerImageValue);
        /// <summary> Indicator Removal on Host. </summary>
        public static SecurityAssessmentTechnique IndicatorRemovalOnHost { get; } = new SecurityAssessmentTechnique(IndicatorRemovalOnHostValue);
        /// <summary> Indirect Command Execution. </summary>
        public static SecurityAssessmentTechnique IndirectCommandExecution { get; } = new SecurityAssessmentTechnique(IndirectCommandExecutionValue);
        /// <summary> Ingress Tool Transfer. </summary>
        public static SecurityAssessmentTechnique IngressToolTransfer { get; } = new SecurityAssessmentTechnique(IngressToolTransferValue);
        /// <summary> Input Capture. </summary>
        public static SecurityAssessmentTechnique InputCapture { get; } = new SecurityAssessmentTechnique(InputCaptureValue);
        /// <summary> Inter-Process Communication. </summary>
        public static SecurityAssessmentTechnique InterProcessCommunication { get; } = new SecurityAssessmentTechnique(InterProcessCommunicationValue);
        /// <summary> Lateral Tool Transfer. </summary>
        public static SecurityAssessmentTechnique LateralToolTransfer { get; } = new SecurityAssessmentTechnique(LateralToolTransferValue);
        /// <summary> Man-in-the-Middle. </summary>
        public static SecurityAssessmentTechnique ManInTheMiddle { get; } = new SecurityAssessmentTechnique(ManInTheMiddleValue);
        /// <summary> Masquerading. </summary>
        public static SecurityAssessmentTechnique Masquerading { get; } = new SecurityAssessmentTechnique(MasqueradingValue);
        /// <summary> Modify Authentication Process. </summary>
        public static SecurityAssessmentTechnique ModifyAuthenticationProcess { get; } = new SecurityAssessmentTechnique(ModifyAuthenticationProcessValue);
        /// <summary> Modify Registry. </summary>
        public static SecurityAssessmentTechnique ModifyRegistry { get; } = new SecurityAssessmentTechnique(ModifyRegistryValue);
        /// <summary> Network Denial of Service. </summary>
        public static SecurityAssessmentTechnique NetworkDenialOfService { get; } = new SecurityAssessmentTechnique(NetworkDenialOfServiceValue);
        /// <summary> Network Service Scanning. </summary>
        public static SecurityAssessmentTechnique NetworkServiceScanning { get; } = new SecurityAssessmentTechnique(NetworkServiceScanningValue);
        /// <summary> Network Sniffing. </summary>
        public static SecurityAssessmentTechnique NetworkSniffing { get; } = new SecurityAssessmentTechnique(NetworkSniffingValue);
        /// <summary> Non-Application Layer Protocol. </summary>
        public static SecurityAssessmentTechnique NonApplicationLayerProtocol { get; } = new SecurityAssessmentTechnique(NonApplicationLayerProtocolValue);
        /// <summary> Non-Standard Port. </summary>
        public static SecurityAssessmentTechnique NonStandardPort { get; } = new SecurityAssessmentTechnique(NonStandardPortValue);
        /// <summary> Obtain Capabilities. </summary>
        public static SecurityAssessmentTechnique ObtainCapabilities { get; } = new SecurityAssessmentTechnique(ObtainCapabilitiesValue);
        /// <summary> Obfuscated Files or Information. </summary>
        public static SecurityAssessmentTechnique ObfuscatedFilesOrInformation { get; } = new SecurityAssessmentTechnique(ObfuscatedFilesOrInformationValue);
        /// <summary> Office Application Startup. </summary>
        public static SecurityAssessmentTechnique OfficeApplicationStartup { get; } = new SecurityAssessmentTechnique(OfficeApplicationStartupValue);
        /// <summary> OS Credential Dumping. </summary>
        public static SecurityAssessmentTechnique OSCredentialDumping { get; } = new SecurityAssessmentTechnique(OSCredentialDumpingValue);
        /// <summary> Permission Groups Discovery. </summary>
        public static SecurityAssessmentTechnique PermissionGroupsDiscovery { get; } = new SecurityAssessmentTechnique(PermissionGroupsDiscoveryValue);
        /// <summary> Phishing. </summary>
        public static SecurityAssessmentTechnique Phishing { get; } = new SecurityAssessmentTechnique(PhishingValue);
        /// <summary> Pre-OS Boot. </summary>
        public static SecurityAssessmentTechnique PreOSBoot { get; } = new SecurityAssessmentTechnique(PreOSBootValue);
        /// <summary> Process Discovery. </summary>
        public static SecurityAssessmentTechnique ProcessDiscovery { get; } = new SecurityAssessmentTechnique(ProcessDiscoveryValue);
        /// <summary> Process Injection. </summary>
        public static SecurityAssessmentTechnique ProcessInjection { get; } = new SecurityAssessmentTechnique(ProcessInjectionValue);
        /// <summary> Protocol Tunneling. </summary>
        public static SecurityAssessmentTechnique ProtocolTunneling { get; } = new SecurityAssessmentTechnique(ProtocolTunnelingValue);
        /// <summary> Proxy. </summary>
        public static SecurityAssessmentTechnique Proxy { get; } = new SecurityAssessmentTechnique(ProxyValue);
        /// <summary> Query Registry. </summary>
        public static SecurityAssessmentTechnique QueryRegistry { get; } = new SecurityAssessmentTechnique(QueryRegistryValue);
        /// <summary> Remote Access Software. </summary>
        public static SecurityAssessmentTechnique RemoteAccessSoftware { get; } = new SecurityAssessmentTechnique(RemoteAccessSoftwareValue);
        /// <summary> Remote Service Session Hijacking. </summary>
        public static SecurityAssessmentTechnique RemoteServiceSessionHijacking { get; } = new SecurityAssessmentTechnique(RemoteServiceSessionHijackingValue);
        /// <summary> Remote Services. </summary>
        public static SecurityAssessmentTechnique RemoteServices { get; } = new SecurityAssessmentTechnique(RemoteServicesValue);
        /// <summary> Remote System Discovery. </summary>
        public static SecurityAssessmentTechnique RemoteSystemDiscovery { get; } = new SecurityAssessmentTechnique(RemoteSystemDiscoveryValue);
        /// <summary> Resource Hijacking. </summary>
        public static SecurityAssessmentTechnique ResourceHijacking { get; } = new SecurityAssessmentTechnique(ResourceHijackingValue);
        /// <summary> Scheduled Task/Job. </summary>
        public static SecurityAssessmentTechnique ScheduledTaskJob { get; } = new SecurityAssessmentTechnique(ScheduledTaskJobValue);
        /// <summary> Screen Capture. </summary>
        public static SecurityAssessmentTechnique ScreenCapture { get; } = new SecurityAssessmentTechnique(ScreenCaptureValue);
        /// <summary> Search Victim-Owned Websites. </summary>
        public static SecurityAssessmentTechnique SearchVictimOwnedWebsites { get; } = new SecurityAssessmentTechnique(SearchVictimOwnedWebsitesValue);
        /// <summary> Server Software Component. </summary>
        public static SecurityAssessmentTechnique ServerSoftwareComponent { get; } = new SecurityAssessmentTechnique(ServerSoftwareComponentValue);
        /// <summary> Service Stop. </summary>
        public static SecurityAssessmentTechnique ServiceStop { get; } = new SecurityAssessmentTechnique(ServiceStopValue);
        /// <summary> Signed Binary Proxy Execution. </summary>
        public static SecurityAssessmentTechnique SignedBinaryProxyExecution { get; } = new SecurityAssessmentTechnique(SignedBinaryProxyExecutionValue);
        /// <summary> Software Deployment Tools. </summary>
        public static SecurityAssessmentTechnique SoftwareDeploymentTools { get; } = new SecurityAssessmentTechnique(SoftwareDeploymentToolsValue);
        /// <summary> SQL Stored Procedures. </summary>
        public static SecurityAssessmentTechnique SQLStoredProcedures { get; } = new SecurityAssessmentTechnique(SQLStoredProceduresValue);
        /// <summary> Steal or Forge Kerberos Tickets. </summary>
        public static SecurityAssessmentTechnique StealOrForgeKerberosTickets { get; } = new SecurityAssessmentTechnique(StealOrForgeKerberosTicketsValue);
        /// <summary> Subvert Trust Controls. </summary>
        public static SecurityAssessmentTechnique SubvertTrustControls { get; } = new SecurityAssessmentTechnique(SubvertTrustControlsValue);
        /// <summary> Supply Chain Compromise. </summary>
        public static SecurityAssessmentTechnique SupplyChainCompromise { get; } = new SecurityAssessmentTechnique(SupplyChainCompromiseValue);
        /// <summary> System Information Discovery. </summary>
        public static SecurityAssessmentTechnique SystemInformationDiscovery { get; } = new SecurityAssessmentTechnique(SystemInformationDiscoveryValue);
        /// <summary> Taint Shared Content. </summary>
        public static SecurityAssessmentTechnique TaintSharedContent { get; } = new SecurityAssessmentTechnique(TaintSharedContentValue);
        /// <summary> Traffic Signaling. </summary>
        public static SecurityAssessmentTechnique TrafficSignaling { get; } = new SecurityAssessmentTechnique(TrafficSignalingValue);
        /// <summary> Transfer Data to Cloud Account. </summary>
        public static SecurityAssessmentTechnique TransferDataToCloudAccount { get; } = new SecurityAssessmentTechnique(TransferDataToCloudAccountValue);
        /// <summary> Trusted Relationship. </summary>
        public static SecurityAssessmentTechnique TrustedRelationship { get; } = new SecurityAssessmentTechnique(TrustedRelationshipValue);
        /// <summary> Unsecured Credentials. </summary>
        public static SecurityAssessmentTechnique UnsecuredCredentials { get; } = new SecurityAssessmentTechnique(UnsecuredCredentialsValue);
        /// <summary> User Execution. </summary>
        public static SecurityAssessmentTechnique UserExecution { get; } = new SecurityAssessmentTechnique(UserExecutionValue);
        /// <summary> Valid Accounts. </summary>
        public static SecurityAssessmentTechnique ValidAccounts { get; } = new SecurityAssessmentTechnique(ValidAccountsValue);
        /// <summary> Windows Management Instrumentation. </summary>
        public static SecurityAssessmentTechnique WindowsManagementInstrumentation { get; } = new SecurityAssessmentTechnique(WindowsManagementInstrumentationValue);
        /// <summary> File and Directory Permissions Modification. </summary>
        public static SecurityAssessmentTechnique FileAndDirectoryPermissionsModification { get; } = new SecurityAssessmentTechnique(FileAndDirectoryPermissionsModificationValue);
        /// <summary> Determines if two <see cref="SecurityAssessmentTechnique"/> values are the same. </summary>
        public static bool operator ==(SecurityAssessmentTechnique left, SecurityAssessmentTechnique right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAssessmentTechnique"/> values are not the same. </summary>
        public static bool operator !=(SecurityAssessmentTechnique left, SecurityAssessmentTechnique right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityAssessmentTechnique"/>. </summary>
        public static implicit operator SecurityAssessmentTechnique(string value) => new SecurityAssessmentTechnique(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAssessmentTechnique other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAssessmentTechnique other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
