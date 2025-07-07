// <copyright file="VerizonClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using APIMatic.Core.Utilities.Logger.Configuration;
using Verizon.Standard.Apis;
using Verizon.Standard.Authentication;
using Verizon.Standard.Http.Client;
using Verizon.Standard.Logging;
using Verizon.Standard.Utilities;

namespace Verizon.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Api and holds the
    /// configuration of the SDK.
    /// </summary>
    public sealed class VerizonClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://5gedge.verizon.com/api/mec/eds" },
                    { Server.ImpServer, "https://imp.thingspace.verizon.com" },
                    { Server.Thingspace, "https://thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://thingspace.verizon.com/api/ts/v1" },
                    { Server.M2M, "https://thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://5gedge.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://5gedge.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
            {
                Environment.MockServerForLimitedAvailabilitySeeQuickStart, new Dictionary<Enum, string>
                {
                    { Server.EdgeDiscovery, "https://mock.thingspace.verizon.com/api/mec/eds" },
                    { Server.ImpServer, "https://mock.thingspace.verizon.com" },
                    { Server.Thingspace, "https://mock.thingspace.verizon.com/api" },
                    { Server.OauthServer, "https://mock.thingspace.verizon.com/api/ts/v1" },
                    { Server.M2M, "https://mock.thingspace.verizon.com/api/m2m" },
                    { Server.DeviceLocation, "https://mock.thingspace.verizon.com/api/loc/v1" },
                    { Server.SubscriptionServer, "https://mock.thingspace.verizon.com/api/subsc/v1" },
                    { Server.SoftwareManagementV1, "https://mock.thingspace.verizon.com/api/fota/v1" },
                    { Server.SoftwareManagementV2, "https://mock.thingspace.verizon.com/api/fota/v2" },
                    { Server.SoftwareManagementV3, "https://mock.thingspace.verizon.com/api/fota/v3" },
                    { Server.Performance, "https://mock.thingspace.verizon.com/api/mec" },
                    { Server.DeviceDiagnostics, "https://mock.thingspace.verizon.com/api/diagnostics/v1" },
                    { Server.CloudConnector, "https://mock.thingspace.verizon.com/api/cc/v1" },
                    { Server.HyperPreciseLocation, "https://mock.thingspace.verizon.com/api/hyper-precise/v1" },
                    { Server.Services, "https://mock.thingspace.verizon.com/api/mec/services" },
                    { Server.QualityOfService, "https://mock.thingspace.verizon.com/api/m2m/v1/devices" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private SdkLoggingConfiguration sdkLoggingConfiguration;
        private const string userAgent = "DotNet-SDK/1.3.0 [OS: {os-info}, Engine: {engine}/{engine-version}]";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<M5GEdgePlatformsApi> m5GEdgePlatforms;
        private readonly Lazy<ServiceEndpointsApi> serviceEndpoints;
        private readonly Lazy<ServiceProfilesApi> serviceProfiles;
        private readonly Lazy<DeviceManagementApi> deviceManagement;
        private readonly Lazy<AccountsApi> accounts;
        private readonly Lazy<DeviceGroupsApi> deviceGroups;
        private readonly Lazy<SmsApi> sms;
        private readonly Lazy<SessionManagementApi> sessionManagement;
        private readonly Lazy<ConnectivityCallbacksApi> connectivityCallbacks;
        private readonly Lazy<AccountRequestsApi> accountRequests;
        private readonly Lazy<ServicePlansApi> servicePlans;
        private readonly Lazy<DeviceDiagnosticsApi> deviceDiagnostics;
        private readonly Lazy<DeviceMonitoringApi> deviceMonitoring;
        private readonly Lazy<DeviceProfileManagementApi> deviceProfileManagement;
        private readonly Lazy<EuiccDeviceProfileManagementApi> euiccDeviceProfileManagement;
        private readonly Lazy<DevicesLocationsApi> devicesLocations;
        private readonly Lazy<ExclusionsApi> exclusions;
        private readonly Lazy<DevicesLocationSubscriptionsApi> devicesLocationSubscriptions;
        private readonly Lazy<DeviceLocationCallbacksApi> deviceLocationCallbacks;
        private readonly Lazy<UsageTriggerManagementApi> usageTriggerManagement;
        private readonly Lazy<BillingApi> billing;
        private readonly Lazy<SoftwareManagementSubscriptionsV1Api> softwareManagementSubscriptionsV1;
        private readonly Lazy<SoftwareManagementLicensesV1Api> softwareManagementLicensesV1;
        private readonly Lazy<FirmwareV1Api> firmwareV1;
        private readonly Lazy<SoftwareManagementCallbacksV1Api> softwareManagementCallbacksV1;
        private readonly Lazy<SoftwareManagementReportsV1Api> softwareManagementReportsV1;
        private readonly Lazy<SoftwareManagementSubscriptionsV2Api> softwareManagementSubscriptionsV2;
        private readonly Lazy<SoftwareManagementLicensesV2Api> softwareManagementLicensesV2;
        private readonly Lazy<CampaignsV2Api> campaignsV2;
        private readonly Lazy<SoftwareManagementCallbacksV2Api> softwareManagementCallbacksV2;
        private readonly Lazy<SoftwareManagementReportsV2Api> softwareManagementReportsV2;
        private readonly Lazy<ClientLoggingApi> clientLogging;
        private readonly Lazy<ServerLoggingApi> serverLogging;
        private readonly Lazy<ConfigurationFilesApi> configurationFiles;
        private readonly Lazy<SoftwareManagementSubscriptionsV3Api> softwareManagementSubscriptionsV3;
        private readonly Lazy<SoftwareManagementLicensesV3Api> softwareManagementLicensesV3;
        private readonly Lazy<CampaignsV3Api> campaignsV3;
        private readonly Lazy<SoftwareManagementReportsV3Api> softwareManagementReportsV3;
        private readonly Lazy<FirmwareV3Api> firmwareV3;
        private readonly Lazy<AccountDevicesApi> accountDevices;
        private readonly Lazy<SoftwareManagementCallbacksV3Api> softwareManagementCallbacksV3;
        private readonly Lazy<SimSecureForIoTLicensesApi> simSecureForIoTLicenses;
        private readonly Lazy<AccountSubscriptionsApi> accountSubscriptions;
        private readonly Lazy<PerformanceMetricsApi> performanceMetrics;
        private readonly Lazy<DiagnosticsSubscriptionsApi> diagnosticsSubscriptions;
        private readonly Lazy<DiagnosticsObservationsApi> diagnosticsObservations;
        private readonly Lazy<DiagnosticsHistoryApi> diagnosticsHistory;
        private readonly Lazy<DiagnosticsSettingsApi> diagnosticsSettings;
        private readonly Lazy<DiagnosticsCallbacksApi> diagnosticsCallbacks;
        private readonly Lazy<DiagnosticsFactoryResetApi> diagnosticsFactoryReset;
        private readonly Lazy<TargetsApi> targets;
        private readonly Lazy<CloudConnectorSubscriptionsApi> cloudConnectorSubscriptions;
        private readonly Lazy<CloudConnectorDevicesApi> cloudConnectorDevices;
        private readonly Lazy<DeviceServiceManagementApi> deviceServiceManagement;
        private readonly Lazy<DeviceReportsApi> deviceReports;
        private readonly Lazy<HyperPreciseLocationCallbacksApi> hyperPreciseLocationCallbacks;
        private readonly Lazy<AnomalySettingsApi> anomalySettings;
        private readonly Lazy<AnomalyTriggersApi> anomalyTriggers;
        private readonly Lazy<AnomalyTriggersV2Api> anomalyTriggersV2;
        private readonly Lazy<WirelessNetworkPerformanceApi> wirelessNetworkPerformance;
        private readonly Lazy<ManagingEsimProfilesApi> managingEsimProfiles;
        private readonly Lazy<DeviceSmsMessagingApi> deviceSmsMessaging;
        private readonly Lazy<DeviceActionsApi> deviceActions;
        private readonly Lazy<ThingSpaceQualityOfServiceApiActionsApi> thingSpaceQualityOfServiceApiActions;
        private readonly Lazy<PwnApi> pwn;
        private readonly Lazy<PromotionPeriodInformationApi> promotionPeriodInformation;
        private readonly Lazy<RetrieveTheTriggersApi> retrieveTheTriggers;
        private readonly Lazy<UpdateTriggersApi> updateTriggers;
        private readonly Lazy<SimActionsApi> simActions;
        private readonly Lazy<GlobalReportingApi> globalReporting;
        private readonly Lazy<RetrieveRatePlanListApi> retrieveRatePlanList;
        private readonly Lazy<CreatePricePlanTriggersApi> createPricePlanTriggers;
        private readonly Lazy<UpdatePricePlanTriggersApi> updatePricePlanTriggers;
        private readonly Lazy<M5GBiDeviceActionsApi> m5GBiDeviceActions;
        private readonly Lazy<SensorInsightsSensorsApi> sensorInsightsSensors;
        private readonly Lazy<SensorInsightsDevicesApi> sensorInsightsDevices;
        private readonly Lazy<SensorInsightsGatewaysApi> sensorInsightsGateways;
        private readonly Lazy<SensorInsightsSmartAlertsApi> sensorInsightsSmartAlerts;
        private readonly Lazy<SensorInsightsRulesApi> sensorInsightsRules;
        private readonly Lazy<SensorInsightsHealthScoreApi> sensorInsightsHealthScore;
        private readonly Lazy<SensorInsightsNotificationGroupsApi> sensorInsightsNotificationGroups;
        private readonly Lazy<SensorInsightsUsersApi> sensorInsightsUsers;
        private readonly Lazy<SensorInsightsDeviceProfileApi> sensorInsightsDeviceProfile;
        private readonly Lazy<SensorInsightsSmartAlertMetricsApi> sensorInsightsSmartAlertMetrics;
        private readonly Lazy<AppConfigServiceApi> appConfigService;
        private readonly Lazy<RegistrationApi> registration;
        private readonly Lazy<MapDataManagerApi> mapDataManager;
        private readonly Lazy<OauthAuthorizationApi> oauthAuthorization;

        private VerizonClient(
            Environment environment,
            ThingspaceOauthModel thingspaceOauthModel,
            VzM2MTokenModel vzM2MTokenModel,
            ThingspaceOauth1Model thingspaceOauth1Model,
            SessionTokenModel sessionTokenModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration,
            SdkLoggingConfiguration sdkLoggingConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            this.sdkLoggingConfiguration = sdkLoggingConfiguration;
            ThingspaceOauthModel = thingspaceOauthModel;
            var thingspaceOauthManager = new ThingspaceOauthManager(thingspaceOauthModel,
                () => OauthAuthorizationApi);
            VzM2MTokenModel = vzM2MTokenModel;
            var vzM2MTokenManager = new VzM2MTokenManager(vzM2MTokenModel);
            ThingspaceOauth1Model = thingspaceOauth1Model;
            var thingspaceOauth1Manager = new ThingspaceOauth1Manager(thingspaceOauth1Model,
                () => OauthAuthorizationApi);
            SessionTokenModel = sessionTokenModel;
            var sessionTokenManager = new SessionTokenManager(sessionTokenModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"thingspace_oauth", thingspaceOauthManager},
                    {"VZ-M2M-Token", vzM2MTokenManager},
                    {"thingspace_oauth1", thingspaceOauth1Manager},
                    {"SessionToken", sessionTokenManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.EdgeDiscovery)
                .LoggingConfig(sdkLoggingConfiguration)
                .UserAgent(userAgent)
                .Build();

            ThingspaceOauthCredentials = thingspaceOauthManager;
            VzM2MTokenCredentials = vzM2MTokenManager;
            ThingspaceOauth1Credentials = thingspaceOauth1Manager;
            SessionTokenCredentials = sessionTokenManager;

            this.m5GEdgePlatforms = new Lazy<M5GEdgePlatformsApi>(
                () => new M5GEdgePlatformsApi(globalConfiguration));
            this.serviceEndpoints = new Lazy<ServiceEndpointsApi>(
                () => new ServiceEndpointsApi(globalConfiguration));
            this.serviceProfiles = new Lazy<ServiceProfilesApi>(
                () => new ServiceProfilesApi(globalConfiguration));
            this.deviceManagement = new Lazy<DeviceManagementApi>(
                () => new DeviceManagementApi(globalConfiguration));
            this.accounts = new Lazy<AccountsApi>(
                () => new AccountsApi(globalConfiguration));
            this.deviceGroups = new Lazy<DeviceGroupsApi>(
                () => new DeviceGroupsApi(globalConfiguration));
            this.sms = new Lazy<SmsApi>(
                () => new SmsApi(globalConfiguration));
            this.sessionManagement = new Lazy<SessionManagementApi>(
                () => new SessionManagementApi(globalConfiguration));
            this.connectivityCallbacks = new Lazy<ConnectivityCallbacksApi>(
                () => new ConnectivityCallbacksApi(globalConfiguration));
            this.accountRequests = new Lazy<AccountRequestsApi>(
                () => new AccountRequestsApi(globalConfiguration));
            this.servicePlans = new Lazy<ServicePlansApi>(
                () => new ServicePlansApi(globalConfiguration));
            this.deviceDiagnostics = new Lazy<DeviceDiagnosticsApi>(
                () => new DeviceDiagnosticsApi(globalConfiguration));
            this.deviceMonitoring = new Lazy<DeviceMonitoringApi>(
                () => new DeviceMonitoringApi(globalConfiguration));
            this.deviceProfileManagement = new Lazy<DeviceProfileManagementApi>(
                () => new DeviceProfileManagementApi(globalConfiguration));
            this.euiccDeviceProfileManagement = new Lazy<EuiccDeviceProfileManagementApi>(
                () => new EuiccDeviceProfileManagementApi(globalConfiguration));
            this.devicesLocations = new Lazy<DevicesLocationsApi>(
                () => new DevicesLocationsApi(globalConfiguration));
            this.exclusions = new Lazy<ExclusionsApi>(
                () => new ExclusionsApi(globalConfiguration));
            this.devicesLocationSubscriptions = new Lazy<DevicesLocationSubscriptionsApi>(
                () => new DevicesLocationSubscriptionsApi(globalConfiguration));
            this.deviceLocationCallbacks = new Lazy<DeviceLocationCallbacksApi>(
                () => new DeviceLocationCallbacksApi(globalConfiguration));
            this.usageTriggerManagement = new Lazy<UsageTriggerManagementApi>(
                () => new UsageTriggerManagementApi(globalConfiguration));
            this.billing = new Lazy<BillingApi>(
                () => new BillingApi(globalConfiguration));
            this.softwareManagementSubscriptionsV1 = new Lazy<SoftwareManagementSubscriptionsV1Api>(
                () => new SoftwareManagementSubscriptionsV1Api(globalConfiguration));
            this.softwareManagementLicensesV1 = new Lazy<SoftwareManagementLicensesV1Api>(
                () => new SoftwareManagementLicensesV1Api(globalConfiguration));
            this.firmwareV1 = new Lazy<FirmwareV1Api>(
                () => new FirmwareV1Api(globalConfiguration));
            this.softwareManagementCallbacksV1 = new Lazy<SoftwareManagementCallbacksV1Api>(
                () => new SoftwareManagementCallbacksV1Api(globalConfiguration));
            this.softwareManagementReportsV1 = new Lazy<SoftwareManagementReportsV1Api>(
                () => new SoftwareManagementReportsV1Api(globalConfiguration));
            this.softwareManagementSubscriptionsV2 = new Lazy<SoftwareManagementSubscriptionsV2Api>(
                () => new SoftwareManagementSubscriptionsV2Api(globalConfiguration));
            this.softwareManagementLicensesV2 = new Lazy<SoftwareManagementLicensesV2Api>(
                () => new SoftwareManagementLicensesV2Api(globalConfiguration));
            this.campaignsV2 = new Lazy<CampaignsV2Api>(
                () => new CampaignsV2Api(globalConfiguration));
            this.softwareManagementCallbacksV2 = new Lazy<SoftwareManagementCallbacksV2Api>(
                () => new SoftwareManagementCallbacksV2Api(globalConfiguration));
            this.softwareManagementReportsV2 = new Lazy<SoftwareManagementReportsV2Api>(
                () => new SoftwareManagementReportsV2Api(globalConfiguration));
            this.clientLogging = new Lazy<ClientLoggingApi>(
                () => new ClientLoggingApi(globalConfiguration));
            this.serverLogging = new Lazy<ServerLoggingApi>(
                () => new ServerLoggingApi(globalConfiguration));
            this.configurationFiles = new Lazy<ConfigurationFilesApi>(
                () => new ConfigurationFilesApi(globalConfiguration));
            this.softwareManagementSubscriptionsV3 = new Lazy<SoftwareManagementSubscriptionsV3Api>(
                () => new SoftwareManagementSubscriptionsV3Api(globalConfiguration));
            this.softwareManagementLicensesV3 = new Lazy<SoftwareManagementLicensesV3Api>(
                () => new SoftwareManagementLicensesV3Api(globalConfiguration));
            this.campaignsV3 = new Lazy<CampaignsV3Api>(
                () => new CampaignsV3Api(globalConfiguration));
            this.softwareManagementReportsV3 = new Lazy<SoftwareManagementReportsV3Api>(
                () => new SoftwareManagementReportsV3Api(globalConfiguration));
            this.firmwareV3 = new Lazy<FirmwareV3Api>(
                () => new FirmwareV3Api(globalConfiguration));
            this.accountDevices = new Lazy<AccountDevicesApi>(
                () => new AccountDevicesApi(globalConfiguration));
            this.softwareManagementCallbacksV3 = new Lazy<SoftwareManagementCallbacksV3Api>(
                () => new SoftwareManagementCallbacksV3Api(globalConfiguration));
            this.simSecureForIoTLicenses = new Lazy<SimSecureForIoTLicensesApi>(
                () => new SimSecureForIoTLicensesApi(globalConfiguration));
            this.accountSubscriptions = new Lazy<AccountSubscriptionsApi>(
                () => new AccountSubscriptionsApi(globalConfiguration));
            this.performanceMetrics = new Lazy<PerformanceMetricsApi>(
                () => new PerformanceMetricsApi(globalConfiguration));
            this.diagnosticsSubscriptions = new Lazy<DiagnosticsSubscriptionsApi>(
                () => new DiagnosticsSubscriptionsApi(globalConfiguration));
            this.diagnosticsObservations = new Lazy<DiagnosticsObservationsApi>(
                () => new DiagnosticsObservationsApi(globalConfiguration));
            this.diagnosticsHistory = new Lazy<DiagnosticsHistoryApi>(
                () => new DiagnosticsHistoryApi(globalConfiguration));
            this.diagnosticsSettings = new Lazy<DiagnosticsSettingsApi>(
                () => new DiagnosticsSettingsApi(globalConfiguration));
            this.diagnosticsCallbacks = new Lazy<DiagnosticsCallbacksApi>(
                () => new DiagnosticsCallbacksApi(globalConfiguration));
            this.diagnosticsFactoryReset = new Lazy<DiagnosticsFactoryResetApi>(
                () => new DiagnosticsFactoryResetApi(globalConfiguration));
            this.targets = new Lazy<TargetsApi>(
                () => new TargetsApi(globalConfiguration));
            this.cloudConnectorSubscriptions = new Lazy<CloudConnectorSubscriptionsApi>(
                () => new CloudConnectorSubscriptionsApi(globalConfiguration));
            this.cloudConnectorDevices = new Lazy<CloudConnectorDevicesApi>(
                () => new CloudConnectorDevicesApi(globalConfiguration));
            this.deviceServiceManagement = new Lazy<DeviceServiceManagementApi>(
                () => new DeviceServiceManagementApi(globalConfiguration));
            this.deviceReports = new Lazy<DeviceReportsApi>(
                () => new DeviceReportsApi(globalConfiguration));
            this.hyperPreciseLocationCallbacks = new Lazy<HyperPreciseLocationCallbacksApi>(
                () => new HyperPreciseLocationCallbacksApi(globalConfiguration));
            this.anomalySettings = new Lazy<AnomalySettingsApi>(
                () => new AnomalySettingsApi(globalConfiguration));
            this.anomalyTriggers = new Lazy<AnomalyTriggersApi>(
                () => new AnomalyTriggersApi(globalConfiguration));
            this.anomalyTriggersV2 = new Lazy<AnomalyTriggersV2Api>(
                () => new AnomalyTriggersV2Api(globalConfiguration));
            this.wirelessNetworkPerformance = new Lazy<WirelessNetworkPerformanceApi>(
                () => new WirelessNetworkPerformanceApi(globalConfiguration));
            this.managingEsimProfiles = new Lazy<ManagingEsimProfilesApi>(
                () => new ManagingEsimProfilesApi(globalConfiguration));
            this.deviceSmsMessaging = new Lazy<DeviceSmsMessagingApi>(
                () => new DeviceSmsMessagingApi(globalConfiguration));
            this.deviceActions = new Lazy<DeviceActionsApi>(
                () => new DeviceActionsApi(globalConfiguration));
            this.thingSpaceQualityOfServiceApiActions = new Lazy<ThingSpaceQualityOfServiceApiActionsApi>(
                () => new ThingSpaceQualityOfServiceApiActionsApi(globalConfiguration));
            this.pwn = new Lazy<PwnApi>(
                () => new PwnApi(globalConfiguration));
            this.promotionPeriodInformation = new Lazy<PromotionPeriodInformationApi>(
                () => new PromotionPeriodInformationApi(globalConfiguration));
            this.retrieveTheTriggers = new Lazy<RetrieveTheTriggersApi>(
                () => new RetrieveTheTriggersApi(globalConfiguration));
            this.updateTriggers = new Lazy<UpdateTriggersApi>(
                () => new UpdateTriggersApi(globalConfiguration));
            this.simActions = new Lazy<SimActionsApi>(
                () => new SimActionsApi(globalConfiguration));
            this.globalReporting = new Lazy<GlobalReportingApi>(
                () => new GlobalReportingApi(globalConfiguration));
            this.retrieveRatePlanList = new Lazy<RetrieveRatePlanListApi>(
                () => new RetrieveRatePlanListApi(globalConfiguration));
            this.createPricePlanTriggers = new Lazy<CreatePricePlanTriggersApi>(
                () => new CreatePricePlanTriggersApi(globalConfiguration));
            this.updatePricePlanTriggers = new Lazy<UpdatePricePlanTriggersApi>(
                () => new UpdatePricePlanTriggersApi(globalConfiguration));
            this.m5GBiDeviceActions = new Lazy<M5GBiDeviceActionsApi>(
                () => new M5GBiDeviceActionsApi(globalConfiguration));
            this.sensorInsightsSensors = new Lazy<SensorInsightsSensorsApi>(
                () => new SensorInsightsSensorsApi(globalConfiguration));
            this.sensorInsightsDevices = new Lazy<SensorInsightsDevicesApi>(
                () => new SensorInsightsDevicesApi(globalConfiguration));
            this.sensorInsightsGateways = new Lazy<SensorInsightsGatewaysApi>(
                () => new SensorInsightsGatewaysApi(globalConfiguration));
            this.sensorInsightsSmartAlerts = new Lazy<SensorInsightsSmartAlertsApi>(
                () => new SensorInsightsSmartAlertsApi(globalConfiguration));
            this.sensorInsightsRules = new Lazy<SensorInsightsRulesApi>(
                () => new SensorInsightsRulesApi(globalConfiguration));
            this.sensorInsightsHealthScore = new Lazy<SensorInsightsHealthScoreApi>(
                () => new SensorInsightsHealthScoreApi(globalConfiguration));
            this.sensorInsightsNotificationGroups = new Lazy<SensorInsightsNotificationGroupsApi>(
                () => new SensorInsightsNotificationGroupsApi(globalConfiguration));
            this.sensorInsightsUsers = new Lazy<SensorInsightsUsersApi>(
                () => new SensorInsightsUsersApi(globalConfiguration));
            this.sensorInsightsDeviceProfile = new Lazy<SensorInsightsDeviceProfileApi>(
                () => new SensorInsightsDeviceProfileApi(globalConfiguration));
            this.sensorInsightsSmartAlertMetrics = new Lazy<SensorInsightsSmartAlertMetricsApi>(
                () => new SensorInsightsSmartAlertMetricsApi(globalConfiguration));
            this.appConfigService = new Lazy<AppConfigServiceApi>(
                () => new AppConfigServiceApi(globalConfiguration));
            this.registration = new Lazy<RegistrationApi>(
                () => new RegistrationApi(globalConfiguration));
            this.mapDataManager = new Lazy<MapDataManagerApi>(
                () => new MapDataManagerApi(globalConfiguration));
            this.oauthAuthorization = new Lazy<OauthAuthorizationApi>(
                () => new OauthAuthorizationApi(globalConfiguration));
        }

        /// <summary>
        /// Gets M5GEdgePlatformsApi.
        /// </summary>
        public M5GEdgePlatformsApi M5GEdgePlatformsApi => this.m5GEdgePlatforms.Value;

        /// <summary>
        /// Gets ServiceEndpointsApi.
        /// </summary>
        public ServiceEndpointsApi ServiceEndpointsApi => this.serviceEndpoints.Value;

        /// <summary>
        /// Gets ServiceProfilesApi.
        /// </summary>
        public ServiceProfilesApi ServiceProfilesApi => this.serviceProfiles.Value;

        /// <summary>
        /// Gets DeviceManagementApi.
        /// </summary>
        public DeviceManagementApi DeviceManagementApi => this.deviceManagement.Value;

        /// <summary>
        /// Gets AccountsApi.
        /// </summary>
        public AccountsApi AccountsApi => this.accounts.Value;

        /// <summary>
        /// Gets DeviceGroupsApi.
        /// </summary>
        public DeviceGroupsApi DeviceGroupsApi => this.deviceGroups.Value;

        /// <summary>
        /// Gets SmsApi.
        /// </summary>
        public SmsApi SmsApi => this.sms.Value;

        /// <summary>
        /// Gets SessionManagementApi.
        /// </summary>
        public SessionManagementApi SessionManagementApi => this.sessionManagement.Value;

        /// <summary>
        /// Gets ConnectivityCallbacksApi.
        /// </summary>
        public ConnectivityCallbacksApi ConnectivityCallbacksApi => this.connectivityCallbacks.Value;

        /// <summary>
        /// Gets AccountRequestsApi.
        /// </summary>
        public AccountRequestsApi AccountRequestsApi => this.accountRequests.Value;

        /// <summary>
        /// Gets ServicePlansApi.
        /// </summary>
        public ServicePlansApi ServicePlansApi => this.servicePlans.Value;

        /// <summary>
        /// Gets DeviceDiagnosticsApi.
        /// </summary>
        public DeviceDiagnosticsApi DeviceDiagnosticsApi => this.deviceDiagnostics.Value;

        /// <summary>
        /// Gets DeviceMonitoringApi.
        /// </summary>
        public DeviceMonitoringApi DeviceMonitoringApi => this.deviceMonitoring.Value;

        /// <summary>
        /// Gets DeviceProfileManagementApi.
        /// </summary>
        public DeviceProfileManagementApi DeviceProfileManagementApi => this.deviceProfileManagement.Value;

        /// <summary>
        /// Gets EuiccDeviceProfileManagementApi.
        /// </summary>
        public EuiccDeviceProfileManagementApi EuiccDeviceProfileManagementApi => this.euiccDeviceProfileManagement.Value;

        /// <summary>
        /// Gets DevicesLocationsApi.
        /// </summary>
        public DevicesLocationsApi DevicesLocationsApi => this.devicesLocations.Value;

        /// <summary>
        /// Gets ExclusionsApi.
        /// </summary>
        public ExclusionsApi ExclusionsApi => this.exclusions.Value;

        /// <summary>
        /// Gets DevicesLocationSubscriptionsApi.
        /// </summary>
        public DevicesLocationSubscriptionsApi DevicesLocationSubscriptionsApi => this.devicesLocationSubscriptions.Value;

        /// <summary>
        /// Gets DeviceLocationCallbacksApi.
        /// </summary>
        public DeviceLocationCallbacksApi DeviceLocationCallbacksApi => this.deviceLocationCallbacks.Value;

        /// <summary>
        /// Gets UsageTriggerManagementApi.
        /// </summary>
        public UsageTriggerManagementApi UsageTriggerManagementApi => this.usageTriggerManagement.Value;

        /// <summary>
        /// Gets BillingApi.
        /// </summary>
        public BillingApi BillingApi => this.billing.Value;

        /// <summary>
        /// Gets SoftwareManagementSubscriptionsV1Api.
        /// </summary>
        public SoftwareManagementSubscriptionsV1Api SoftwareManagementSubscriptionsV1Api => this.softwareManagementSubscriptionsV1.Value;

        /// <summary>
        /// Gets SoftwareManagementLicensesV1Api.
        /// </summary>
        public SoftwareManagementLicensesV1Api SoftwareManagementLicensesV1Api => this.softwareManagementLicensesV1.Value;

        /// <summary>
        /// Gets FirmwareV1Api.
        /// </summary>
        public FirmwareV1Api FirmwareV1Api => this.firmwareV1.Value;

        /// <summary>
        /// Gets SoftwareManagementCallbacksV1Api.
        /// </summary>
        public SoftwareManagementCallbacksV1Api SoftwareManagementCallbacksV1Api => this.softwareManagementCallbacksV1.Value;

        /// <summary>
        /// Gets SoftwareManagementReportsV1Api.
        /// </summary>
        public SoftwareManagementReportsV1Api SoftwareManagementReportsV1Api => this.softwareManagementReportsV1.Value;

        /// <summary>
        /// Gets SoftwareManagementSubscriptionsV2Api.
        /// </summary>
        public SoftwareManagementSubscriptionsV2Api SoftwareManagementSubscriptionsV2Api => this.softwareManagementSubscriptionsV2.Value;

        /// <summary>
        /// Gets SoftwareManagementLicensesV2Api.
        /// </summary>
        public SoftwareManagementLicensesV2Api SoftwareManagementLicensesV2Api => this.softwareManagementLicensesV2.Value;

        /// <summary>
        /// Gets CampaignsV2Api.
        /// </summary>
        public CampaignsV2Api CampaignsV2Api => this.campaignsV2.Value;

        /// <summary>
        /// Gets SoftwareManagementCallbacksV2Api.
        /// </summary>
        public SoftwareManagementCallbacksV2Api SoftwareManagementCallbacksV2Api => this.softwareManagementCallbacksV2.Value;

        /// <summary>
        /// Gets SoftwareManagementReportsV2Api.
        /// </summary>
        public SoftwareManagementReportsV2Api SoftwareManagementReportsV2Api => this.softwareManagementReportsV2.Value;

        /// <summary>
        /// Gets ClientLoggingApi.
        /// </summary>
        public ClientLoggingApi ClientLoggingApi => this.clientLogging.Value;

        /// <summary>
        /// Gets ServerLoggingApi.
        /// </summary>
        public ServerLoggingApi ServerLoggingApi => this.serverLogging.Value;

        /// <summary>
        /// Gets ConfigurationFilesApi.
        /// </summary>
        public ConfigurationFilesApi ConfigurationFilesApi => this.configurationFiles.Value;

        /// <summary>
        /// Gets SoftwareManagementSubscriptionsV3Api.
        /// </summary>
        public SoftwareManagementSubscriptionsV3Api SoftwareManagementSubscriptionsV3Api => this.softwareManagementSubscriptionsV3.Value;

        /// <summary>
        /// Gets SoftwareManagementLicensesV3Api.
        /// </summary>
        public SoftwareManagementLicensesV3Api SoftwareManagementLicensesV3Api => this.softwareManagementLicensesV3.Value;

        /// <summary>
        /// Gets CampaignsV3Api.
        /// </summary>
        public CampaignsV3Api CampaignsV3Api => this.campaignsV3.Value;

        /// <summary>
        /// Gets SoftwareManagementReportsV3Api.
        /// </summary>
        public SoftwareManagementReportsV3Api SoftwareManagementReportsV3Api => this.softwareManagementReportsV3.Value;

        /// <summary>
        /// Gets FirmwareV3Api.
        /// </summary>
        public FirmwareV3Api FirmwareV3Api => this.firmwareV3.Value;

        /// <summary>
        /// Gets AccountDevicesApi.
        /// </summary>
        public AccountDevicesApi AccountDevicesApi => this.accountDevices.Value;

        /// <summary>
        /// Gets SoftwareManagementCallbacksV3Api.
        /// </summary>
        public SoftwareManagementCallbacksV3Api SoftwareManagementCallbacksV3Api => this.softwareManagementCallbacksV3.Value;

        /// <summary>
        /// Gets SimSecureForIoTLicensesApi.
        /// </summary>
        public SimSecureForIoTLicensesApi SimSecureForIoTLicensesApi => this.simSecureForIoTLicenses.Value;

        /// <summary>
        /// Gets AccountSubscriptionsApi.
        /// </summary>
        public AccountSubscriptionsApi AccountSubscriptionsApi => this.accountSubscriptions.Value;

        /// <summary>
        /// Gets PerformanceMetricsApi.
        /// </summary>
        public PerformanceMetricsApi PerformanceMetricsApi => this.performanceMetrics.Value;

        /// <summary>
        /// Gets DiagnosticsSubscriptionsApi.
        /// </summary>
        public DiagnosticsSubscriptionsApi DiagnosticsSubscriptionsApi => this.diagnosticsSubscriptions.Value;

        /// <summary>
        /// Gets DiagnosticsObservationsApi.
        /// </summary>
        public DiagnosticsObservationsApi DiagnosticsObservationsApi => this.diagnosticsObservations.Value;

        /// <summary>
        /// Gets DiagnosticsHistoryApi.
        /// </summary>
        public DiagnosticsHistoryApi DiagnosticsHistoryApi => this.diagnosticsHistory.Value;

        /// <summary>
        /// Gets DiagnosticsSettingsApi.
        /// </summary>
        public DiagnosticsSettingsApi DiagnosticsSettingsApi => this.diagnosticsSettings.Value;

        /// <summary>
        /// Gets DiagnosticsCallbacksApi.
        /// </summary>
        public DiagnosticsCallbacksApi DiagnosticsCallbacksApi => this.diagnosticsCallbacks.Value;

        /// <summary>
        /// Gets DiagnosticsFactoryResetApi.
        /// </summary>
        public DiagnosticsFactoryResetApi DiagnosticsFactoryResetApi => this.diagnosticsFactoryReset.Value;

        /// <summary>
        /// Gets TargetsApi.
        /// </summary>
        public TargetsApi TargetsApi => this.targets.Value;

        /// <summary>
        /// Gets CloudConnectorSubscriptionsApi.
        /// </summary>
        public CloudConnectorSubscriptionsApi CloudConnectorSubscriptionsApi => this.cloudConnectorSubscriptions.Value;

        /// <summary>
        /// Gets CloudConnectorDevicesApi.
        /// </summary>
        public CloudConnectorDevicesApi CloudConnectorDevicesApi => this.cloudConnectorDevices.Value;

        /// <summary>
        /// Gets DeviceServiceManagementApi.
        /// </summary>
        public DeviceServiceManagementApi DeviceServiceManagementApi => this.deviceServiceManagement.Value;

        /// <summary>
        /// Gets DeviceReportsApi.
        /// </summary>
        public DeviceReportsApi DeviceReportsApi => this.deviceReports.Value;

        /// <summary>
        /// Gets HyperPreciseLocationCallbacksApi.
        /// </summary>
        public HyperPreciseLocationCallbacksApi HyperPreciseLocationCallbacksApi => this.hyperPreciseLocationCallbacks.Value;

        /// <summary>
        /// Gets AnomalySettingsApi.
        /// </summary>
        public AnomalySettingsApi AnomalySettingsApi => this.anomalySettings.Value;

        /// <summary>
        /// Gets AnomalyTriggersApi.
        /// </summary>
        public AnomalyTriggersApi AnomalyTriggersApi => this.anomalyTriggers.Value;

        /// <summary>
        /// Gets AnomalyTriggersV2Api.
        /// </summary>
        public AnomalyTriggersV2Api AnomalyTriggersV2Api => this.anomalyTriggersV2.Value;

        /// <summary>
        /// Gets WirelessNetworkPerformanceApi.
        /// </summary>
        public WirelessNetworkPerformanceApi WirelessNetworkPerformanceApi => this.wirelessNetworkPerformance.Value;

        /// <summary>
        /// Gets ManagingEsimProfilesApi.
        /// </summary>
        public ManagingEsimProfilesApi ManagingEsimProfilesApi => this.managingEsimProfiles.Value;

        /// <summary>
        /// Gets DeviceSmsMessagingApi.
        /// </summary>
        public DeviceSmsMessagingApi DeviceSmsMessagingApi => this.deviceSmsMessaging.Value;

        /// <summary>
        /// Gets DeviceActionsApi.
        /// </summary>
        public DeviceActionsApi DeviceActionsApi => this.deviceActions.Value;

        /// <summary>
        /// Gets ThingSpaceQualityOfServiceApiActionsApi.
        /// </summary>
        public ThingSpaceQualityOfServiceApiActionsApi ThingSpaceQualityOfServiceApiActionsApi => this.thingSpaceQualityOfServiceApiActions.Value;

        /// <summary>
        /// Gets PwnApi.
        /// </summary>
        public PwnApi PwnApi => this.pwn.Value;

        /// <summary>
        /// Gets PromotionPeriodInformationApi.
        /// </summary>
        public PromotionPeriodInformationApi PromotionPeriodInformationApi => this.promotionPeriodInformation.Value;

        /// <summary>
        /// Gets RetrieveTheTriggersApi.
        /// </summary>
        public RetrieveTheTriggersApi RetrieveTheTriggersApi => this.retrieveTheTriggers.Value;

        /// <summary>
        /// Gets UpdateTriggersApi.
        /// </summary>
        public UpdateTriggersApi UpdateTriggersApi => this.updateTriggers.Value;

        /// <summary>
        /// Gets SimActionsApi.
        /// </summary>
        public SimActionsApi SimActionsApi => this.simActions.Value;

        /// <summary>
        /// Gets GlobalReportingApi.
        /// </summary>
        public GlobalReportingApi GlobalReportingApi => this.globalReporting.Value;

        /// <summary>
        /// Gets RetrieveRatePlanListApi.
        /// </summary>
        public RetrieveRatePlanListApi RetrieveRatePlanListApi => this.retrieveRatePlanList.Value;

        /// <summary>
        /// Gets CreatePricePlanTriggersApi.
        /// </summary>
        public CreatePricePlanTriggersApi CreatePricePlanTriggersApi => this.createPricePlanTriggers.Value;

        /// <summary>
        /// Gets UpdatePricePlanTriggersApi.
        /// </summary>
        public UpdatePricePlanTriggersApi UpdatePricePlanTriggersApi => this.updatePricePlanTriggers.Value;

        /// <summary>
        /// Gets M5GBiDeviceActionsApi.
        /// </summary>
        public M5GBiDeviceActionsApi M5GBiDeviceActionsApi => this.m5GBiDeviceActions.Value;

        /// <summary>
        /// Gets SensorInsightsSensorsApi.
        /// </summary>
        public SensorInsightsSensorsApi SensorInsightsSensorsApi => this.sensorInsightsSensors.Value;

        /// <summary>
        /// Gets SensorInsightsDevicesApi.
        /// </summary>
        public SensorInsightsDevicesApi SensorInsightsDevicesApi => this.sensorInsightsDevices.Value;

        /// <summary>
        /// Gets SensorInsightsGatewaysApi.
        /// </summary>
        public SensorInsightsGatewaysApi SensorInsightsGatewaysApi => this.sensorInsightsGateways.Value;

        /// <summary>
        /// Gets SensorInsightsSmartAlertsApi.
        /// </summary>
        public SensorInsightsSmartAlertsApi SensorInsightsSmartAlertsApi => this.sensorInsightsSmartAlerts.Value;

        /// <summary>
        /// Gets SensorInsightsRulesApi.
        /// </summary>
        public SensorInsightsRulesApi SensorInsightsRulesApi => this.sensorInsightsRules.Value;

        /// <summary>
        /// Gets SensorInsightsHealthScoreApi.
        /// </summary>
        public SensorInsightsHealthScoreApi SensorInsightsHealthScoreApi => this.sensorInsightsHealthScore.Value;

        /// <summary>
        /// Gets SensorInsightsNotificationGroupsApi.
        /// </summary>
        public SensorInsightsNotificationGroupsApi SensorInsightsNotificationGroupsApi => this.sensorInsightsNotificationGroups.Value;

        /// <summary>
        /// Gets SensorInsightsUsersApi.
        /// </summary>
        public SensorInsightsUsersApi SensorInsightsUsersApi => this.sensorInsightsUsers.Value;

        /// <summary>
        /// Gets SensorInsightsDeviceProfileApi.
        /// </summary>
        public SensorInsightsDeviceProfileApi SensorInsightsDeviceProfileApi => this.sensorInsightsDeviceProfile.Value;

        /// <summary>
        /// Gets SensorInsightsSmartAlertMetricsApi.
        /// </summary>
        public SensorInsightsSmartAlertMetricsApi SensorInsightsSmartAlertMetricsApi => this.sensorInsightsSmartAlertMetrics.Value;

        /// <summary>
        /// Gets AppConfigServiceApi.
        /// </summary>
        public AppConfigServiceApi AppConfigServiceApi => this.appConfigService.Value;

        /// <summary>
        /// Gets RegistrationApi.
        /// </summary>
        public RegistrationApi RegistrationApi => this.registration.Value;

        /// <summary>
        /// Gets MapDataManagerApi.
        /// </summary>
        public MapDataManagerApi MapDataManagerApi => this.mapDataManager.Value;

        /// <summary>
        /// Gets OauthAuthorizationApi.
        /// </summary>
        public OauthAuthorizationApi OauthAuthorizationApi => this.oauthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth.
        /// </summary>
        public IThingspaceOauthCredentials ThingspaceOauthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth.
        /// </summary>
        public ThingspaceOauthModel ThingspaceOauthModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with VzM2MToken.
        /// </summary>
        public IVzM2MTokenCredentials VzM2MTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with VzM2MToken.
        /// </summary>
        public VzM2MTokenModel VzM2MTokenModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth1.
        /// </summary>
        public IThingspaceOauth1Credentials ThingspaceOauth1Credentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth1.
        /// </summary>
        public ThingspaceOauth1Model ThingspaceOauth1Model { get; private set; }

        /// <summary>
        /// Gets the credentials to use with SessionToken.
        /// </summary>
        public ISessionTokenCredentials SessionTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with SessionToken.
        /// </summary>
        public SessionTokenModel SessionTokenModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:EDGE DISCOVERY.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.EdgeDiscovery)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the VerizonClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .LoggingConfig(sdkLoggingConfiguration)
                .HttpClientConfig(config => config.Build());

            if (ThingspaceOauthModel != null)
            {
                builder.ThingspaceOauthCredentials(ThingspaceOauthModel.ToBuilder().Build());
            }

            if (VzM2MTokenModel != null)
            {
                builder.VzM2MTokenCredentials(VzM2MTokenModel.ToBuilder().Build());
            }

            if (ThingspaceOauth1Model != null)
            {
                builder.ThingspaceOauth1Credentials(ThingspaceOauth1Model.ToBuilder().Build());
            }

            if (SessionTokenModel != null)
            {
                builder.SessionTokenCredentials(SessionTokenModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> VerizonClient.</returns>
        internal static VerizonClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_ENVIRONMENT");
            string oauthClientId = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_ID");
            string oauthClientSecret = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_SECRET");
            string vzM2MToken = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_VZ_M2M_TOKEN");
            string oauthClientId2 = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_ID_2");
            string oauthClientSecret2 = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_OAUTH_CLIENT_SECRET_2");
            string sessionToken = System.Environment.GetEnvironmentVariable("VERIZON_STANDARD_SESSION_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oauthClientId != null && oauthClientSecret != null)
            {
                builder.ThingspaceOauthCredentials(new ThingspaceOauthModel
                .Builder(oauthClientId, oauthClientSecret)
                .Build());
            }

            if (vzM2MToken != null)
            {
                builder.VzM2MTokenCredentials(new VzM2MTokenModel
                .Builder(vzM2MToken)
                .Build());
            }

            if (oauthClientId2 != null && oauthClientSecret2 != null)
            {
                builder.ThingspaceOauth1Credentials(new ThingspaceOauth1Model
                .Builder(oauthClientId2, oauthClientSecret2)
                .Build());
            }

            if (sessionToken != null)
            {
                builder.SessionTokenCredentials(new SessionTokenModel
                .Builder(sessionToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = Verizon.Standard.Environment.Production;
            private ThingspaceOauthModel thingspaceOauthModel = new ThingspaceOauthModel();
            private VzM2MTokenModel vzM2MTokenModel = new VzM2MTokenModel();
            private ThingspaceOauth1Model thingspaceOauth1Model = new ThingspaceOauth1Model();
            private SessionTokenModel sessionTokenModel = new SessionTokenModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;
            private SdkLoggingConfiguration sdkLoggingConfiguration;

            /// <summary>
            /// Sets credentials for ThingspaceOauth.
            /// </summary>
            /// <param name="thingspaceOauthModel">ThingspaceOauthModel.</param>
            /// <returns>Builder.</returns>
            public Builder ThingspaceOauthCredentials(ThingspaceOauthModel thingspaceOauthModel)
            {
                if (thingspaceOauthModel is null)
                {
                    throw new ArgumentNullException(nameof(thingspaceOauthModel));
                }

                this.thingspaceOauthModel = thingspaceOauthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for VzM2MToken.
            /// </summary>
            /// <param name="vzM2MTokenModel">VzM2MTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder VzM2MTokenCredentials(VzM2MTokenModel vzM2MTokenModel)
            {
                if (vzM2MTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(vzM2MTokenModel));
                }

                this.vzM2MTokenModel = vzM2MTokenModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for ThingspaceOauth1.
            /// </summary>
            /// <param name="thingspaceOauth1Model">ThingspaceOauth1Model.</param>
            /// <returns>Builder.</returns>
            public Builder ThingspaceOauth1Credentials(ThingspaceOauth1Model thingspaceOauth1Model)
            {
                if (thingspaceOauth1Model is null)
                {
                    throw new ArgumentNullException(nameof(thingspaceOauth1Model));
                }

                this.thingspaceOauth1Model = thingspaceOauth1Model;
                return this;
            }

            /// <summary>
            /// Sets credentials for SessionToken.
            /// </summary>
            /// <param name="sessionTokenModel">SessionTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder SessionTokenCredentials(SessionTokenModel sessionTokenModel)
            {
                if (sessionTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(sessionTokenModel));
                }

                this.sessionTokenModel = sessionTokenModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the default logging configuration, using the Console logger.
            /// </summary>
            /// <returns>Builder.</returns>
            public Builder LoggingConfig()
            {
                this.sdkLoggingConfiguration = SdkLoggingConfiguration.Console();
                return this;
            }

            /// <summary>
            /// Sets the logging configuration using the provided <paramref name="action"/>.
            /// </summary>
            /// <param name="action">The action to perform on the logging configuration builder.</param>
            /// <returns>Builder.</returns>
            /// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
            public Builder LoggingConfig(Action<LogBuilder> action)
            {
                if (action is null) throw new ArgumentNullException(nameof(action));
                var logBuilder =
                    LogBuilder.CreateFromConfig(sdkLoggingConfiguration ?? SdkLoggingConfiguration.Console());
                action(logBuilder);
                this.sdkLoggingConfiguration = logBuilder.Build();
                return this;
            }

            internal Builder LoggingConfig(SdkLoggingConfiguration configuration)
            {
                sdkLoggingConfiguration = configuration;
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the VerizonClient using the values provided for the builder.
            /// </summary>
            /// <returns>VerizonClient.</returns>
            public VerizonClient Build()
            {
                if (thingspaceOauthModel.OauthClientId == null || thingspaceOauthModel.OauthClientSecret == null)
                {
                    thingspaceOauthModel = null;
                }
                if (vzM2MTokenModel.VzM2MToken == null)
                {
                    vzM2MTokenModel = null;
                }
                if (thingspaceOauth1Model.OauthClientId == null || thingspaceOauth1Model.OauthClientSecret == null)
                {
                    thingspaceOauth1Model = null;
                }
                if (sessionTokenModel.SessionToken == null)
                {
                    sessionTokenModel = null;
                }
                return new VerizonClient(
                    environment,
                    thingspaceOauthModel,
                    vzM2MTokenModel,
                    thingspaceOauth1Model,
                    sessionTokenModel,
                    httpCallback,
                    httpClientConfig.Build(),
                    sdkLoggingConfiguration);
            }
        }
    }
}
