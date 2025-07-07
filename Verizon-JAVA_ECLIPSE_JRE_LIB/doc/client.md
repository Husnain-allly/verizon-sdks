
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| environment | `Environment` | The API environment. <br> **Default: `Environment.PRODUCTION`** |
| httpClientConfig | [`Consumer<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Set up Http Client Configuration instance. |
| loggingConfig | [`Consumer<ApiLoggingConfiguration.Builder>`](../doc/api-logging-configuration-builder.md) | Set up Logging Configuration instance. |
| thingspaceOauthCredentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| vzM2MTokenCredentials | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| thingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| sessionTokenCredentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```java
VerizonClient client = new VerizonClient.Builder()
    .loggingConfig(builder -> builder
            .level(Level.DEBUG)
            .requestConfig(logConfigBuilder -> logConfigBuilder.body(true))
            .responseConfig(logConfigBuilder -> logConfigBuilder.headers(true)))
    .httpClientConfig(configBuilder -> configBuilder
            .timeout(0))
    .thingspaceOauthCredentials(new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .oauthScopes(Arrays.asList(
                OauthScopeThingspaceOauth.DISCOVERYREAD,
                OauthScopeThingspaceOauth.SERVICEPROFILEREAD
            ))
        .build())
    .vzM2MTokenCredentials(new VzM2MTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .build())
    .thingspaceOauth1Credentials(new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .build())
    .sessionTokenCredentials(new SessionTokenModel.Builder(
            "SessionToken"
        )
        .build())
    .environment(Environment.PRODUCTION)
    .build();
```

## VerizonClient Class

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

### Apis

| Name | Description | Return Type |
|  --- | --- | --- |
| `getM5GEdgePlatformsApi()` | Provides access to M5GEdgePlatforms controller. | `M5GEdgePlatformsApi` |
| `getServiceEndpointsApi()` | Provides access to ServiceEndpoints controller. | `ServiceEndpointsApi` |
| `getServiceProfilesApi()` | Provides access to ServiceProfiles controller. | `ServiceProfilesApi` |
| `getDeviceManagementApi()` | Provides access to DeviceManagement controller. | `DeviceManagementApi` |
| `getAccountsApi()` | Provides access to Accounts controller. | `AccountsApi` |
| `getDeviceGroupsApi()` | Provides access to DeviceGroups controller. | `DeviceGroupsApi` |
| `getSmsApi()` | Provides access to Sms controller. | `SmsApi` |
| `getSessionManagementApi()` | Provides access to SessionManagement controller. | `SessionManagementApi` |
| `getConnectivityCallbacksApi()` | Provides access to ConnectivityCallbacks controller. | `ConnectivityCallbacksApi` |
| `getAccountRequestsApi()` | Provides access to AccountRequests controller. | `AccountRequestsApi` |
| `getServicePlansApi()` | Provides access to ServicePlans controller. | `ServicePlansApi` |
| `getDeviceDiagnosticsApi()` | Provides access to DeviceDiagnostics controller. | `DeviceDiagnosticsApi` |
| `getDeviceMonitoringApi()` | Provides access to DeviceMonitoring controller. | `DeviceMonitoringApi` |
| `getDeviceProfileManagementApi()` | Provides access to DeviceProfileManagement controller. | `DeviceProfileManagementApi` |
| `getEuiccDeviceProfileManagementApi()` | Provides access to EuiccDeviceProfileManagement controller. | `EuiccDeviceProfileManagementApi` |
| `getDevicesLocationsApi()` | Provides access to DevicesLocations controller. | `DevicesLocationsApi` |
| `getExclusionsApi()` | Provides access to Exclusions controller. | `ExclusionsApi` |
| `getDevicesLocationSubscriptionsApi()` | Provides access to DevicesLocationSubscriptions controller. | `DevicesLocationSubscriptionsApi` |
| `getDeviceLocationCallbacksApi()` | Provides access to DeviceLocationCallbacks controller. | `DeviceLocationCallbacksApi` |
| `getUsageTriggerManagementApi()` | Provides access to UsageTriggerManagement controller. | `UsageTriggerManagementApi` |
| `getBillingApi()` | Provides access to Billing controller. | `BillingApi` |
| `getSoftwareManagementSubscriptionsV1Api()` | Provides access to SoftwareManagementSubscriptionsV1 controller. | `SoftwareManagementSubscriptionsV1Api` |
| `getSoftwareManagementLicensesV1Api()` | Provides access to SoftwareManagementLicensesV1 controller. | `SoftwareManagementLicensesV1Api` |
| `getFirmwareV1Api()` | Provides access to FirmwareV1 controller. | `FirmwareV1Api` |
| `getSoftwareManagementCallbacksV1Api()` | Provides access to SoftwareManagementCallbacksV1 controller. | `SoftwareManagementCallbacksV1Api` |
| `getSoftwareManagementReportsV1Api()` | Provides access to SoftwareManagementReportsV1 controller. | `SoftwareManagementReportsV1Api` |
| `getSoftwareManagementSubscriptionsV2Api()` | Provides access to SoftwareManagementSubscriptionsV2 controller. | `SoftwareManagementSubscriptionsV2Api` |
| `getSoftwareManagementLicensesV2Api()` | Provides access to SoftwareManagementLicensesV2 controller. | `SoftwareManagementLicensesV2Api` |
| `getCampaignsV2Api()` | Provides access to CampaignsV2 controller. | `CampaignsV2Api` |
| `getSoftwareManagementCallbacksV2Api()` | Provides access to SoftwareManagementCallbacksV2 controller. | `SoftwareManagementCallbacksV2Api` |
| `getSoftwareManagementReportsV2Api()` | Provides access to SoftwareManagementReportsV2 controller. | `SoftwareManagementReportsV2Api` |
| `getClientLoggingApi()` | Provides access to ClientLogging controller. | `ClientLoggingApi` |
| `getServerLoggingApi()` | Provides access to ServerLogging controller. | `ServerLoggingApi` |
| `getConfigurationFilesApi()` | Provides access to ConfigurationFiles controller. | `ConfigurationFilesApi` |
| `getSoftwareManagementSubscriptionsV3Api()` | Provides access to SoftwareManagementSubscriptionsV3 controller. | `SoftwareManagementSubscriptionsV3Api` |
| `getSoftwareManagementLicensesV3Api()` | Provides access to SoftwareManagementLicensesV3 controller. | `SoftwareManagementLicensesV3Api` |
| `getCampaignsV3Api()` | Provides access to CampaignsV3 controller. | `CampaignsV3Api` |
| `getSoftwareManagementReportsV3Api()` | Provides access to SoftwareManagementReportsV3 controller. | `SoftwareManagementReportsV3Api` |
| `getFirmwareV3Api()` | Provides access to FirmwareV3 controller. | `FirmwareV3Api` |
| `getAccountDevicesApi()` | Provides access to AccountDevices controller. | `AccountDevicesApi` |
| `getSoftwareManagementCallbacksV3Api()` | Provides access to SoftwareManagementCallbacksV3 controller. | `SoftwareManagementCallbacksV3Api` |
| `getSimSecureforIoTLicensesApi()` | Provides access to SimSecureforIoTLicenses controller. | `SimSecureforIoTLicensesApi` |
| `getAccountSubscriptionsApi()` | Provides access to AccountSubscriptions controller. | `AccountSubscriptionsApi` |
| `getPerformanceMetricsApi()` | Provides access to PerformanceMetrics controller. | `PerformanceMetricsApi` |
| `getDiagnosticsSubscriptionsApi()` | Provides access to DiagnosticsSubscriptions controller. | `DiagnosticsSubscriptionsApi` |
| `getDiagnosticsObservationsApi()` | Provides access to DiagnosticsObservations controller. | `DiagnosticsObservationsApi` |
| `getDiagnosticsHistoryApi()` | Provides access to DiagnosticsHistory controller. | `DiagnosticsHistoryApi` |
| `getDiagnosticsSettingsApi()` | Provides access to DiagnosticsSettings controller. | `DiagnosticsSettingsApi` |
| `getDiagnosticsCallbacksApi()` | Provides access to DiagnosticsCallbacks controller. | `DiagnosticsCallbacksApi` |
| `getDiagnosticsFactoryResetApi()` | Provides access to DiagnosticsFactoryReset controller. | `DiagnosticsFactoryResetApi` |
| `getTargetsApi()` | Provides access to Targets controller. | `TargetsApi` |
| `getCloudConnectorSubscriptionsApi()` | Provides access to CloudConnectorSubscriptions controller. | `CloudConnectorSubscriptionsApi` |
| `getCloudConnectorDevicesApi()` | Provides access to CloudConnectorDevices controller. | `CloudConnectorDevicesApi` |
| `getDeviceServiceManagementApi()` | Provides access to DeviceServiceManagement controller. | `DeviceServiceManagementApi` |
| `getDeviceReportsApi()` | Provides access to DeviceReports controller. | `DeviceReportsApi` |
| `getHyperPreciseLocationCallbacksApi()` | Provides access to HyperPreciseLocationCallbacks controller. | `HyperPreciseLocationCallbacksApi` |
| `getAnomalySettingsApi()` | Provides access to AnomalySettings controller. | `AnomalySettingsApi` |
| `getAnomalyTriggersApi()` | Provides access to AnomalyTriggers controller. | `AnomalyTriggersApi` |
| `getAnomalyTriggersV2Api()` | Provides access to AnomalyTriggersV2 controller. | `AnomalyTriggersV2Api` |
| `getWirelessNetworkPerformanceApi()` | Provides access to WirelessNetworkPerformance controller. | `WirelessNetworkPerformanceApi` |
| `getManagingeSimProfilesApi()` | Provides access to ManagingeSimProfiles controller. | `ManagingeSimProfilesApi` |
| `getDeviceSmsMessagingApi()` | Provides access to DeviceSmsMessaging controller. | `DeviceSmsMessagingApi` |
| `getDeviceActionsApi()` | Provides access to DeviceActions controller. | `DeviceActionsApi` |
| `getThingSpaceQualityofServiceApiActionsApi()` | Provides access to ThingSpaceQualityofServiceApiActions controller. | `ThingSpaceQualityofServiceApiActionsApi` |
| `getPwnApi()` | Provides access to Pwn controller. | `PwnApi` |
| `getPromotionPeriodInformationApi()` | Provides access to PromotionPeriodInformation controller. | `PromotionPeriodInformationApi` |
| `getRetrievetheTriggersApi()` | Provides access to RetrievetheTriggers controller. | `RetrievetheTriggersApi` |
| `getUpdateTriggersApi()` | Provides access to UpdateTriggers controller. | `UpdateTriggersApi` |
| `getSimActionsApi()` | Provides access to SimActions controller. | `SimActionsApi` |
| `getGlobalReportingApi()` | Provides access to GlobalReporting controller. | `GlobalReportingApi` |
| `getRetrieveRatePlanListApi()` | Provides access to RetrieveRatePlanList controller. | `RetrieveRatePlanListApi` |
| `getCreatePricePlanTriggersApi()` | Provides access to CreatePricePlanTriggers controller. | `CreatePricePlanTriggersApi` |
| `getUpdatePricePlanTriggersApi()` | Provides access to UpdatePricePlanTriggers controller. | `UpdatePricePlanTriggersApi` |
| `getM5GBiDeviceActionsApi()` | Provides access to M5GBiDeviceActions controller. | `M5GBiDeviceActionsApi` |
| `getSensorInsightsSensorsApi()` | Provides access to SensorInsightsSensors controller. | `SensorInsightsSensorsApi` |
| `getSensorInsightsDevicesApi()` | Provides access to SensorInsightsDevices controller. | `SensorInsightsDevicesApi` |
| `getSensorInsightsGatewaysApi()` | Provides access to SensorInsightsGateways controller. | `SensorInsightsGatewaysApi` |
| `getSensorInsightsSmartAlertsApi()` | Provides access to SensorInsightsSmartAlerts controller. | `SensorInsightsSmartAlertsApi` |
| `getSensorInsightsRulesApi()` | Provides access to SensorInsightsRules controller. | `SensorInsightsRulesApi` |
| `getSensorInsightsHealthScoreApi()` | Provides access to SensorInsightsHealthScore controller. | `SensorInsightsHealthScoreApi` |
| `getSensorInsightsNotificationGroupsApi()` | Provides access to SensorInsightsNotificationGroups controller. | `SensorInsightsNotificationGroupsApi` |
| `getSensorInsightsUsersApi()` | Provides access to SensorInsightsUsers controller. | `SensorInsightsUsersApi` |
| `getSensorInsightsDeviceProfileApi()` | Provides access to SensorInsightsDeviceProfile controller. | `SensorInsightsDeviceProfileApi` |
| `getSensorInsightsSmartAlertMetricsApi()` | Provides access to SensorInsightsSmartAlertMetrics controller. | `SensorInsightsSmartAlertMetricsApi` |
| `getAppConfigServiceApi()` | Provides access to AppConfigService controller. | `AppConfigServiceApi` |
| `getRegistrationApi()` | Provides access to Registration controller. | `RegistrationApi` |
| `getMapDataManagerApi()` | Provides access to MapDataManager controller. | `MapDataManagerApi` |
| `getOauthAuthorizationApi()` | Provides access to OauthAuthorization controller. | `OauthAuthorizationApi` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `shutdown()` | Shutdown the underlying HttpClient instance. | `void` |
| `getEnvironment()` | Current API environment. | `Environment` |
| `getHttpClient()` | The HTTP Client instance to use for making HTTP requests. | `HttpClient` |
| `getHttpClientConfig()` | Http Client Configuration instance. | [`ReadonlyHttpClientConfiguration`](../doc/http-client-configuration.md) |
| `getLoggingConfig()` | Logging Configuration instance. | [`ReadonlyLoggingConfiguration`](../doc/api-logging-configuration.md) |
| `getThingspaceOauthCredentials()` | The credentials to use with ThingspaceOauth. | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) |
| `getVzM2MTokenCredentials()` | The credentials to use with VzM2MToken. | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) |
| `getThingspaceOauth1Credentials()` | The credentials to use with ThingspaceOauth1. | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) |
| `getSessionTokenCredentials()` | The credentials to use with SessionToken. | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) |
| `getBaseUri(Server server)` | Get base URI by current environment | `String` |
| `getBaseUri()` | Get base URI by current environment | `String` |

