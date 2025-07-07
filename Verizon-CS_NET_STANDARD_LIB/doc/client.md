
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](../doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ThingspaceOauthCredentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| VzM2MTokenCredentials | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| ThingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| SessionTokenCredentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauthCredentials(
        new ThingspaceOauthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthScopes(
            new List<OauthScopeThingspaceOauth>
            {
                OauthScopeThingspaceOauth.Discoveryread,
                OauthScopeThingspaceOauth.Serviceprofileread,
            })
        .Build())
    .VzM2MTokenCredentials(
        new VzM2MTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .ThingspaceOauth1Credentials(
        new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .SessionTokenCredentials(
        new SessionTokenModel.Builder(
            "SessionToken"
        )
        .Build())
    .Environment(Verizon.Standard.Environment.Production)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

## VerizonClient Class

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| M5GEdgePlatformsApi | Gets M5GEdgePlatformsApi. |
| ServiceEndpointsApi | Gets ServiceEndpointsApi. |
| ServiceProfilesApi | Gets ServiceProfilesApi. |
| DeviceManagementApi | Gets DeviceManagementApi. |
| AccountsApi | Gets AccountsApi. |
| DeviceGroupsApi | Gets DeviceGroupsApi. |
| SmsApi | Gets SmsApi. |
| SessionManagementApi | Gets SessionManagementApi. |
| ConnectivityCallbacksApi | Gets ConnectivityCallbacksApi. |
| AccountRequestsApi | Gets AccountRequestsApi. |
| ServicePlansApi | Gets ServicePlansApi. |
| DeviceDiagnosticsApi | Gets DeviceDiagnosticsApi. |
| DeviceMonitoringApi | Gets DeviceMonitoringApi. |
| DeviceProfileManagementApi | Gets DeviceProfileManagementApi. |
| EuiccDeviceProfileManagementApi | Gets EuiccDeviceProfileManagementApi. |
| DevicesLocationsApi | Gets DevicesLocationsApi. |
| ExclusionsApi | Gets ExclusionsApi. |
| DevicesLocationSubscriptionsApi | Gets DevicesLocationSubscriptionsApi. |
| DeviceLocationCallbacksApi | Gets DeviceLocationCallbacksApi. |
| UsageTriggerManagementApi | Gets UsageTriggerManagementApi. |
| BillingApi | Gets BillingApi. |
| SoftwareManagementSubscriptionsV1Api | Gets SoftwareManagementSubscriptionsV1Api. |
| SoftwareManagementLicensesV1Api | Gets SoftwareManagementLicensesV1Api. |
| FirmwareV1Api | Gets FirmwareV1Api. |
| SoftwareManagementCallbacksV1Api | Gets SoftwareManagementCallbacksV1Api. |
| SoftwareManagementReportsV1Api | Gets SoftwareManagementReportsV1Api. |
| SoftwareManagementSubscriptionsV2Api | Gets SoftwareManagementSubscriptionsV2Api. |
| SoftwareManagementLicensesV2Api | Gets SoftwareManagementLicensesV2Api. |
| CampaignsV2Api | Gets CampaignsV2Api. |
| SoftwareManagementCallbacksV2Api | Gets SoftwareManagementCallbacksV2Api. |
| SoftwareManagementReportsV2Api | Gets SoftwareManagementReportsV2Api. |
| ClientLoggingApi | Gets ClientLoggingApi. |
| ServerLoggingApi | Gets ServerLoggingApi. |
| ConfigurationFilesApi | Gets ConfigurationFilesApi. |
| SoftwareManagementSubscriptionsV3Api | Gets SoftwareManagementSubscriptionsV3Api. |
| SoftwareManagementLicensesV3Api | Gets SoftwareManagementLicensesV3Api. |
| CampaignsV3Api | Gets CampaignsV3Api. |
| SoftwareManagementReportsV3Api | Gets SoftwareManagementReportsV3Api. |
| FirmwareV3Api | Gets FirmwareV3Api. |
| AccountDevicesApi | Gets AccountDevicesApi. |
| SoftwareManagementCallbacksV3Api | Gets SoftwareManagementCallbacksV3Api. |
| SimSecureForIoTLicensesApi | Gets SimSecureForIoTLicensesApi. |
| AccountSubscriptionsApi | Gets AccountSubscriptionsApi. |
| PerformanceMetricsApi | Gets PerformanceMetricsApi. |
| DiagnosticsSubscriptionsApi | Gets DiagnosticsSubscriptionsApi. |
| DiagnosticsObservationsApi | Gets DiagnosticsObservationsApi. |
| DiagnosticsHistoryApi | Gets DiagnosticsHistoryApi. |
| DiagnosticsSettingsApi | Gets DiagnosticsSettingsApi. |
| DiagnosticsCallbacksApi | Gets DiagnosticsCallbacksApi. |
| DiagnosticsFactoryResetApi | Gets DiagnosticsFactoryResetApi. |
| TargetsApi | Gets TargetsApi. |
| CloudConnectorSubscriptionsApi | Gets CloudConnectorSubscriptionsApi. |
| CloudConnectorDevicesApi | Gets CloudConnectorDevicesApi. |
| DeviceServiceManagementApi | Gets DeviceServiceManagementApi. |
| DeviceReportsApi | Gets DeviceReportsApi. |
| HyperPreciseLocationCallbacksApi | Gets HyperPreciseLocationCallbacksApi. |
| AnomalySettingsApi | Gets AnomalySettingsApi. |
| AnomalyTriggersApi | Gets AnomalyTriggersApi. |
| AnomalyTriggersV2Api | Gets AnomalyTriggersV2Api. |
| WirelessNetworkPerformanceApi | Gets WirelessNetworkPerformanceApi. |
| ManagingEsimProfilesApi | Gets ManagingEsimProfilesApi. |
| DeviceSmsMessagingApi | Gets DeviceSmsMessagingApi. |
| DeviceActionsApi | Gets DeviceActionsApi. |
| ThingSpaceQualityOfServiceApiActionsApi | Gets ThingSpaceQualityOfServiceApiActionsApi. |
| PwnApi | Gets PwnApi. |
| PromotionPeriodInformationApi | Gets PromotionPeriodInformationApi. |
| RetrieveTheTriggersApi | Gets RetrieveTheTriggersApi. |
| UpdateTriggersApi | Gets UpdateTriggersApi. |
| SimActionsApi | Gets SimActionsApi. |
| GlobalReportingApi | Gets GlobalReportingApi. |
| RetrieveRatePlanListApi | Gets RetrieveRatePlanListApi. |
| CreatePricePlanTriggersApi | Gets CreatePricePlanTriggersApi. |
| UpdatePricePlanTriggersApi | Gets UpdatePricePlanTriggersApi. |
| M5GBiDeviceActionsApi | Gets M5GBiDeviceActionsApi. |
| SensorInsightsSensorsApi | Gets SensorInsightsSensorsApi. |
| SensorInsightsDevicesApi | Gets SensorInsightsDevicesApi. |
| SensorInsightsGatewaysApi | Gets SensorInsightsGatewaysApi. |
| SensorInsightsSmartAlertsApi | Gets SensorInsightsSmartAlertsApi. |
| SensorInsightsRulesApi | Gets SensorInsightsRulesApi. |
| SensorInsightsHealthScoreApi | Gets SensorInsightsHealthScoreApi. |
| SensorInsightsNotificationGroupsApi | Gets SensorInsightsNotificationGroupsApi. |
| SensorInsightsUsersApi | Gets SensorInsightsUsersApi. |
| SensorInsightsDeviceProfileApi | Gets SensorInsightsDeviceProfileApi. |
| SensorInsightsSmartAlertMetricsApi | Gets SensorInsightsSmartAlertMetricsApi. |
| AppConfigServiceApi | Gets AppConfigServiceApi. |
| RegistrationApi | Gets RegistrationApi. |
| MapDataManagerApi | Gets MapDataManagerApi. |
| OauthAuthorizationApi | Gets OauthAuthorizationApi. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| ThingspaceOauthCredentials | Gets the credentials to use with ThingspaceOauth. | [`IThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) |
| VzM2MTokenCredentials | Gets the credentials to use with VzM2MToken. | [`IVzM2MTokenCredentials`](auth/custom-header-signature.md) |
| ThingspaceOauth1Credentials | Gets the credentials to use with ThingspaceOauth1. | [`IThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) |
| SessionTokenCredentials | Gets the credentials to use with SessionToken. | [`ISessionTokenCredentials`](auth/custom-header-signature-1.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.EdgeDiscovery)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the VerizonClient using the values provided for the builder. | `Builder` |

## VerizonClient Builder Class

Class to build instances of VerizonClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ThingspaceOauthCredentials(Action<ThingspaceOauthModel.Builder> action)` | Sets credentials for ThingspaceOauth. | `Builder` |
| `VzM2MTokenCredentials(Action<VzM2MTokenModel.Builder> action)` | Sets credentials for VzM2MToken. | `Builder` |
| `ThingspaceOauth1Credentials(Action<ThingspaceOauth1Model.Builder> action)` | Sets credentials for ThingspaceOauth1. | `Builder` |
| `SessionTokenCredentials(Action<SessionTokenModel.Builder> action)` | Sets credentials for SessionToken. | `Builder` |

