
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| environment | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| timeout | `number` | Timeout for API calls.<br>*Default*: `30000` |
| httpClientOptions | [`Partial<HttpClientOptions>`](../doc/http-client-options.md) | Stable configurable http client options. |
| unstableHttpClientOptions | `any` | Unstable configurable http client options. |
| logging | [`PartialLoggingOptions`](../doc/partial-logging-options.md) | Logging Configuration to enable logging |
| thingspaceOauthCredentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The credential object for thingspaceOauth |
| vzM2MTokenCredentials | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) | The credential object for vzM2MToken |
| thingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The credential object for thingspaceOauth1 |
| sessionTokenCredentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The credential object for sessionToken |

The API client can be initialized as follows:

```ts
const client = new Client({
  thingspaceOauthCredentials: {
    oauthClientId: 'OAuthClientId',
    oauthClientSecret: 'OAuthClientSecret',
    oauthScopes: [
      OauthScopeThingspaceOauth.Discoveryread,
      OauthScopeThingspaceOauth.Serviceprofileread
    ]
  },
  vzM2MTokenCredentials: {
    'VZ-M2M-Token': 'VZ-M2M-Token'
  },
  thingspaceOauth1Credentials: {
    oauthClientId: 'OAuthClientId',
    oauthClientSecret: 'OAuthClientSecret'
  },
  sessionTokenCredentials: {
    'SessionToken': 'SessionToken'
  },
  timeout: 30000,
  environment: Environment.Production,
  logging: {
    logLevel: LogLevel.Info,
    logRequest: {
      logBody: true
    },
    logResponse: {
      logHeaders: true
    }
  },
});
```

## Verizon Client

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

## Apis

| Name | Description |
|  --- | --- |
| m5GEdgePlatforms | Gets M5GEdgePlatformsApi |
| serviceEndpoints | Gets ServiceEndpointsApi |
| serviceProfiles | Gets ServiceProfilesApi |
| deviceManagement | Gets DeviceManagementApi |
| accounts | Gets AccountsApi |
| deviceGroups | Gets DeviceGroupsApi |
| sms | Gets SmsApi |
| sessionManagement | Gets SessionManagementApi |
| connectivityCallbacks | Gets ConnectivityCallbacksApi |
| accountRequests | Gets AccountRequestsApi |
| servicePlans | Gets ServicePlansApi |
| deviceDiagnostics | Gets DeviceDiagnosticsApi |
| deviceMonitoring | Gets DeviceMonitoringApi |
| deviceProfileManagement | Gets DeviceProfileManagementApi |
| euiccDeviceProfileManagement | Gets EuiccDeviceProfileManagementApi |
| devicesLocations | Gets DevicesLocationsApi |
| exclusions | Gets ExclusionsApi |
| devicesLocationSubscriptions | Gets DevicesLocationSubscriptionsApi |
| deviceLocationCallbacks | Gets DeviceLocationCallbacksApi |
| usageTriggerManagement | Gets UsageTriggerManagementApi |
| billing | Gets BillingApi |
| softwareManagementSubscriptionsV1 | Gets SoftwareManagementSubscriptionsV1Api |
| softwareManagementLicensesV1 | Gets SoftwareManagementLicensesV1Api |
| firmwareV1 | Gets FirmwareV1Api |
| softwareManagementCallbacksV1 | Gets SoftwareManagementCallbacksV1Api |
| softwareManagementReportsV1 | Gets SoftwareManagementReportsV1Api |
| softwareManagementSubscriptionsV2 | Gets SoftwareManagementSubscriptionsV2Api |
| softwareManagementLicensesV2 | Gets SoftwareManagementLicensesV2Api |
| campaignsV2 | Gets CampaignsV2Api |
| softwareManagementCallbacksV2 | Gets SoftwareManagementCallbacksV2Api |
| softwareManagementReportsV2 | Gets SoftwareManagementReportsV2Api |
| clientLogging | Gets ClientLoggingApi |
| serverLogging | Gets ServerLoggingApi |
| configurationFiles | Gets ConfigurationFilesApi |
| softwareManagementSubscriptionsV3 | Gets SoftwareManagementSubscriptionsV3Api |
| softwareManagementLicensesV3 | Gets SoftwareManagementLicensesV3Api |
| campaignsV3 | Gets CampaignsV3Api |
| softwareManagementReportsV3 | Gets SoftwareManagementReportsV3Api |
| firmwareV3 | Gets FirmwareV3Api |
| accountDevices | Gets AccountDevicesApi |
| softwareManagementCallbacksV3 | Gets SoftwareManagementCallbacksV3Api |
| simSecureForIoTLicenses | Gets SimSecureForIoTLicensesApi |
| accountSubscriptions | Gets AccountSubscriptionsApi |
| performanceMetrics | Gets PerformanceMetricsApi |
| diagnosticsSubscriptions | Gets DiagnosticsSubscriptionsApi |
| diagnosticsObservations | Gets DiagnosticsObservationsApi |
| diagnosticsHistory | Gets DiagnosticsHistoryApi |
| diagnosticsSettings | Gets DiagnosticsSettingsApi |
| diagnosticsCallbacks | Gets DiagnosticsCallbacksApi |
| diagnosticsFactoryReset | Gets DiagnosticsFactoryResetApi |
| targets | Gets TargetsApi |
| cloudConnectorSubscriptions | Gets CloudConnectorSubscriptionsApi |
| cloudConnectorDevices | Gets CloudConnectorDevicesApi |
| deviceServiceManagement | Gets DeviceServiceManagementApi |
| deviceReports | Gets DeviceReportsApi |
| hyperPreciseLocationCallbacks | Gets HyperPreciseLocationCallbacksApi |
| anomalySettings | Gets AnomalySettingsApi |
| anomalyTriggers | Gets AnomalyTriggersApi |
| anomalyTriggersV2 | Gets AnomalyTriggersV2Api |
| wirelessNetworkPerformance | Gets WirelessNetworkPerformanceApi |
| managingEsimProfiles | Gets ManagingEsimProfilesApi |
| deviceSmsMessaging | Gets DeviceSmsMessagingApi |
| deviceActions | Gets DeviceActionsApi |
| thingSpaceQualityOfServiceApiActions | Gets ThingSpaceQualityOfServiceApiActionsApi |
| pwn | Gets PwnApi |
| promotionPeriodInformation | Gets PromotionPeriodInformationApi |
| retrieveTheTriggers | Gets RetrieveTheTriggersApi |
| updateTriggers | Gets UpdateTriggersApi |
| simActions | Gets SimActionsApi |
| globalReporting | Gets GlobalReportingApi |
| retrieveRatePlanList | Gets RetrieveRatePlanListApi |
| createPricePlanTriggers | Gets CreatePricePlanTriggersApi |
| updatePricePlanTriggers | Gets UpdatePricePlanTriggersApi |
| m5GBiDeviceActions | Gets M5GBiDeviceActionsApi |
| sensorInsightsSensors | Gets SensorInsightsSensorsApi |
| sensorInsightsDevices | Gets SensorInsightsDevicesApi |
| sensorInsightsGateways | Gets SensorInsightsGatewaysApi |
| sensorInsightsSmartAlerts | Gets SensorInsightsSmartAlertsApi |
| sensorInsightsRules | Gets SensorInsightsRulesApi |
| sensorInsightsHealthScore | Gets SensorInsightsHealthScoreApi |
| sensorInsightsNotificationGroups | Gets SensorInsightsNotificationGroupsApi |
| sensorInsightsUsers | Gets SensorInsightsUsersApi |
| sensorInsightsDeviceProfile | Gets SensorInsightsDeviceProfileApi |
| sensorInsightsSmartAlertMetrics | Gets SensorInsightsSmartAlertMetricsApi |
| appConfigService | Gets AppConfigServiceApi |
| registration | Gets RegistrationApi |
| mapDataManager | Gets MapDataManagerApi |
| oauthAuthorization | Gets OauthAuthorizationApi |

