
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| environment | `Environment` | The API environment. <br> **Default: `Environment.PRODUCTION`** |
| httpConfiguration | [`HttpConfiguration`](../doc/http-configuration.md) | Configurable http client options like timeout and retries. |
| loggerConfiguration | [`LoggerConfiguration`](../doc/logger-configuration.md) | Represents the logger configurations for API calls |
| thingspaceOauthCredentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| vzM2MTokenCredentials | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| thingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| sessionTokenCredentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```go
client := verizon.NewClient(
    verizon.CreateConfiguration(
        verizon.WithHttpConfiguration(
            verizon.CreateHttpConfiguration(
                verizon.WithTimeout(30),
            ),
        ),
        verizon.WithEnvironment(verizon.PRODUCTION),
        verizon.WithThingspaceOauthCredentials(
            verizon.NewThingspaceOauthCredentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ).
            WithOauthScopes([]models.OauthScopeThingspaceOauth{
        models.OauthScopeThingspaceOauth_Discoveryread,
        models.OauthScopeThingspaceOauth_Serviceprofileread,
    }),
        ),
        verizon.WithVzM2MTokenCredentials(
            verizon.NewVzM2MTokenCredentials("VZ-M2M-Token"),
        ),
        verizon.WithThingspaceOauth1Credentials(
            verizon.NewThingspaceOauth1Credentials(
                "OAuthClientId",
                "OAuthClientSecret",
            ),
        ),
        verizon.WithSessionTokenCredentials(
            verizon.NewSessionTokenCredentials("SessionToken"),
        ),
        verizon.WithLoggerConfiguration(
            verizon.WithLevel("info"),
            verizon.WithRequestConfiguration(
                verizon.WithRequestBody(true),
            ),
            verizon.WithResponseConfiguration(
                verizon.WithResponseHeaders(true),
            ),
        ),
    ),
)
```

## Verizon Client

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

## Apis

| Name | Description |
|  --- | --- |
| M5GEdgePlatformsApi() | Gets M5GEdgePlatformsApi |
| ServiceEndpointsApi() | Gets ServiceEndpointsApi |
| ServiceProfilesApi() | Gets ServiceProfilesApi |
| DeviceManagementApi() | Gets DeviceManagementApi |
| AccountsApi() | Gets AccountsApi |
| DeviceGroupsApi() | Gets DeviceGroupsApi |
| SmsApi() | Gets SmsApi |
| SessionManagementApi() | Gets SessionManagementApi |
| ConnectivityCallbacksApi() | Gets ConnectivityCallbacksApi |
| AccountRequestsApi() | Gets AccountRequestsApi |
| ServicePlansApi() | Gets ServicePlansApi |
| DeviceDiagnosticsApi() | Gets DeviceDiagnosticsApi |
| DeviceMonitoringApi() | Gets DeviceMonitoringApi |
| DeviceProfileManagementApi() | Gets DeviceProfileManagementApi |
| EuiccDeviceProfileManagementApi() | Gets EuiccDeviceProfileManagementApi |
| DevicesLocationsApi() | Gets DevicesLocationsApi |
| ExclusionsApi() | Gets ExclusionsApi |
| DevicesLocationSubscriptionsApi() | Gets DevicesLocationSubscriptionsApi |
| DeviceLocationCallbacksApi() | Gets DeviceLocationCallbacksApi |
| UsageTriggerManagementApi() | Gets UsageTriggerManagementApi |
| BillingApi() | Gets BillingApi |
| SoftwareManagementSubscriptionsV1Api() | Gets SoftwareManagementSubscriptionsV1Api |
| SoftwareManagementLicensesV1Api() | Gets SoftwareManagementLicensesV1Api |
| FirmwareV1Api() | Gets FirmwareV1Api |
| SoftwareManagementCallbacksV1Api() | Gets SoftwareManagementCallbacksV1Api |
| SoftwareManagementReportsV1Api() | Gets SoftwareManagementReportsV1Api |
| SoftwareManagementSubscriptionsV2Api() | Gets SoftwareManagementSubscriptionsV2Api |
| SoftwareManagementLicensesV2Api() | Gets SoftwareManagementLicensesV2Api |
| CampaignsV2Api() | Gets CampaignsV2Api |
| SoftwareManagementCallbacksV2Api() | Gets SoftwareManagementCallbacksV2Api |
| SoftwareManagementReportsV2Api() | Gets SoftwareManagementReportsV2Api |
| ClientLoggingApi() | Gets ClientLoggingApi |
| ServerLoggingApi() | Gets ServerLoggingApi |
| ConfigurationFilesApi() | Gets ConfigurationFilesApi |
| SoftwareManagementSubscriptionsV3Api() | Gets SoftwareManagementSubscriptionsV3Api |
| SoftwareManagementLicensesV3Api() | Gets SoftwareManagementLicensesV3Api |
| CampaignsV3Api() | Gets CampaignsV3Api |
| SoftwareManagementReportsV3Api() | Gets SoftwareManagementReportsV3Api |
| FirmwareV3Api() | Gets FirmwareV3Api |
| AccountDevicesApi() | Gets AccountDevicesApi |
| SoftwareManagementCallbacksV3Api() | Gets SoftwareManagementCallbacksV3Api |
| SimSecureForIoTLicensesApi() | Gets SimSecureForIoTLicensesApi |
| AccountSubscriptionsApi() | Gets AccountSubscriptionsApi |
| PerformanceMetricsApi() | Gets PerformanceMetricsApi |
| DiagnosticsSubscriptionsApi() | Gets DiagnosticsSubscriptionsApi |
| DiagnosticsObservationsApi() | Gets DiagnosticsObservationsApi |
| DiagnosticsHistoryApi() | Gets DiagnosticsHistoryApi |
| DiagnosticsSettingsApi() | Gets DiagnosticsSettingsApi |
| DiagnosticsCallbacksApi() | Gets DiagnosticsCallbacksApi |
| DiagnosticsFactoryResetApi() | Gets DiagnosticsFactoryResetApi |
| TargetsApi() | Gets TargetsApi |
| CloudConnectorSubscriptionsApi() | Gets CloudConnectorSubscriptionsApi |
| CloudConnectorDevicesApi() | Gets CloudConnectorDevicesApi |
| DeviceServiceManagementApi() | Gets DeviceServiceManagementApi |
| DeviceReportsApi() | Gets DeviceReportsApi |
| HyperPreciseLocationCallbacksApi() | Gets HyperPreciseLocationCallbacksApi |
| AnomalySettingsApi() | Gets AnomalySettingsApi |
| AnomalyTriggersApi() | Gets AnomalyTriggersApi |
| AnomalyTriggersV2Api() | Gets AnomalyTriggersV2Api |
| WirelessNetworkPerformanceApi() | Gets WirelessNetworkPerformanceApi |
| ManagingEsimProfilesApi() | Gets ManagingEsimProfilesApi |
| DeviceSmsMessagingApi() | Gets DeviceSmsMessagingApi |
| DeviceActionsApi() | Gets DeviceActionsApi |
| ThingSpaceQualityOfServiceApiActionsApi() | Gets ThingSpaceQualityOfServiceApiActionsApi |
| PwnApi() | Gets PwnApi |
| PromotionPeriodInformationApi() | Gets PromotionPeriodInformationApi |
| RetrieveTheTriggersApi() | Gets RetrieveTheTriggersApi |
| UpdateTriggersApi() | Gets UpdateTriggersApi |
| SimActionsApi() | Gets SimActionsApi |
| GlobalReportingApi() | Gets GlobalReportingApi |
| RetrieveRatePlanListApi() | Gets RetrieveRatePlanListApi |
| CreatePricePlanTriggersApi() | Gets CreatePricePlanTriggersApi |
| UpdatePricePlanTriggersApi() | Gets UpdatePricePlanTriggersApi |
| M5GBiDeviceActionsApi() | Gets M5GBiDeviceActionsApi |
| SensorInsightsSensorsApi() | Gets SensorInsightsSensorsApi |
| SensorInsightsDevicesApi() | Gets SensorInsightsDevicesApi |
| SensorInsightsGatewaysApi() | Gets SensorInsightsGatewaysApi |
| SensorInsightsSmartAlertsApi() | Gets SensorInsightsSmartAlertsApi |
| SensorInsightsRulesApi() | Gets SensorInsightsRulesApi |
| SensorInsightsHealthScoreApi() | Gets SensorInsightsHealthScoreApi |
| SensorInsightsNotificationGroupsApi() | Gets SensorInsightsNotificationGroupsApi |
| SensorInsightsUsersApi() | Gets SensorInsightsUsersApi |
| SensorInsightsDeviceProfileApi() | Gets SensorInsightsDeviceProfileApi |
| SensorInsightsSmartAlertMetricsApi() | Gets SensorInsightsSmartAlertMetricsApi |
| AppConfigServiceApi() | Gets AppConfigServiceApi |
| RegistrationApi() | Gets RegistrationApi |
| MapDataManagerApi() | Gets MapDataManagerApi |
| OauthAuthorizationApi() | Gets OauthAuthorizationApi |

