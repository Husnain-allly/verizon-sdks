
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| environment | `Environment` | The API environment. <br> **Default: `Environment.PRODUCTION`** |
| timeout | `int` | Timeout for API calls in seconds.<br>*Default*: `30` |
| enableRetries | `bool` | Whether to enable retries and backoff feature.<br>*Default*: `false` |
| numberOfRetries | `int` | The number of retries to make.<br>*Default*: `0` |
| retryInterval | `float` | The retry time interval between the endpoint calls.<br>*Default*: `1` |
| backOffFactor | `float` | Exponential backoff factor to increase interval between retries.<br>*Default*: `2` |
| maximumRetryWaitTime | `int` | The maximum wait time in seconds for overall retrying requests.<br>*Default*: `0` |
| retryOnTimeout | `bool` | Whether to retry on request timeout.<br>*Default*: `true` |
| httpStatusCodesToRetry | `array` | Http status codes to retry against.<br>*Default*: `408, 413, 429, 500, 502, 503, 504, 521, 522, 524` |
| httpMethodsToRetry | `array` | Http methods to retry against.<br>*Default*: `'GET', 'PUT'` |
| loggingConfiguration | [`LoggingConfigurationBuilder`](../doc/logging-configuration-builder.md) | Represents the logging configurations for API calls |
| proxyConfiguration | [`ProxyConfigurationBuilder`](../doc/proxy-configuration-builder.md) | Represents the proxy configurations for API calls |
| thingspaceOauthCredentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| vzM2MTokenCredentials | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| thingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| sessionTokenCredentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```php
use VerizonLib\Logging\LoggingConfigurationBuilder;
use VerizonLib\Logging\RequestLoggingConfigurationBuilder;
use VerizonLib\Logging\ResponseLoggingConfigurationBuilder;
use Psr\Log\LogLevel;
use VerizonLib\Environment;
use VerizonLib\Authentication\ThingspaceOauthCredentialsBuilder;
use VerizonLib\Models\OauthScopeThingspaceOauth;
use VerizonLib\Authentication\VzM2MTokenCredentialsBuilder;
use VerizonLib\Authentication\ThingspaceOauth1CredentialsBuilder;
use VerizonLib\Authentication\SessionTokenCredentialsBuilder;
use VerizonLib\VerizonClientBuilder;

$client = VerizonClientBuilder::init()
    ->thingspaceOauthCredentials(
        ThingspaceOauthCredentialsBuilder::init(
            'OAuthClientId',
            'OAuthClientSecret'
        )
            ->oauthScopes(
                [
                    OauthScopeThingspaceOauth::DISCOVERYREAD,
                    OauthScopeThingspaceOauth::SERVICEPROFILEREAD
                ]
            )
    )
    ->vzM2MTokenCredentials(
        VzM2MTokenCredentialsBuilder::init(
            'VZ-M2M-Token'
        )
    )
    ->thingspaceOauth1Credentials(
        ThingspaceOauth1CredentialsBuilder::init(
            'OAuthClientId',
            'OAuthClientSecret'
        )
    )
    ->sessionTokenCredentials(
        SessionTokenCredentialsBuilder::init(
            'SessionToken'
        )
    )
    ->environment(Environment::PRODUCTION)
    ->loggingConfiguration(
        LoggingConfigurationBuilder::init()
            ->level(LogLevel::INFO)
            ->requestConfiguration(RequestLoggingConfigurationBuilder::init()->body(true))
            ->responseConfiguration(ResponseLoggingConfigurationBuilder::init()->headers(true))
    )
    ->build();
```

## Verizon Client

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

## Apis

| Name | Description |
|  --- | --- |
| getM5GEdgePlatformsApi() | Gets M5GEdgePlatformsApi |
| getServiceEndpointsApi() | Gets ServiceEndpointsApi |
| getServiceProfilesApi() | Gets ServiceProfilesApi |
| getDeviceManagementApi() | Gets DeviceManagementApi |
| getAccountsApi() | Gets AccountsApi |
| getDeviceGroupsApi() | Gets DeviceGroupsApi |
| getSmsApi() | Gets SmsApi |
| getSessionManagementApi() | Gets SessionManagementApi |
| getConnectivityCallbacksApi() | Gets ConnectivityCallbacksApi |
| getAccountRequestsApi() | Gets AccountRequestsApi |
| getServicePlansApi() | Gets ServicePlansApi |
| getDeviceDiagnosticsApi() | Gets DeviceDiagnosticsApi |
| getDeviceMonitoringApi() | Gets DeviceMonitoringApi |
| getDeviceProfileManagementApi() | Gets DeviceProfileManagementApi |
| getEuiccDeviceProfileManagementApi() | Gets EuiccDeviceProfileManagementApi |
| getDevicesLocationsApi() | Gets DevicesLocationsApi |
| getExclusionsApi() | Gets ExclusionsApi |
| getDevicesLocationSubscriptionsApi() | Gets DevicesLocationSubscriptionsApi |
| getDeviceLocationCallbacksApi() | Gets DeviceLocationCallbacksApi |
| getUsageTriggerManagementApi() | Gets UsageTriggerManagementApi |
| getBillingApi() | Gets BillingApi |
| getSoftwareManagementSubscriptionsV1Api() | Gets SoftwareManagementSubscriptionsV1Api |
| getSoftwareManagementLicensesV1Api() | Gets SoftwareManagementLicensesV1Api |
| getFirmwareV1Api() | Gets FirmwareV1Api |
| getSoftwareManagementCallbacksV1Api() | Gets SoftwareManagementCallbacksV1Api |
| getSoftwareManagementReportsV1Api() | Gets SoftwareManagementReportsV1Api |
| getSoftwareManagementSubscriptionsV2Api() | Gets SoftwareManagementSubscriptionsV2Api |
| getSoftwareManagementLicensesV2Api() | Gets SoftwareManagementLicensesV2Api |
| getCampaignsV2Api() | Gets CampaignsV2Api |
| getSoftwareManagementCallbacksV2Api() | Gets SoftwareManagementCallbacksV2Api |
| getSoftwareManagementReportsV2Api() | Gets SoftwareManagementReportsV2Api |
| getClientLoggingApi() | Gets ClientLoggingApi |
| getServerLoggingApi() | Gets ServerLoggingApi |
| getConfigurationFilesApi() | Gets ConfigurationFilesApi |
| getSoftwareManagementSubscriptionsV3Api() | Gets SoftwareManagementSubscriptionsV3Api |
| getSoftwareManagementLicensesV3Api() | Gets SoftwareManagementLicensesV3Api |
| getCampaignsV3Api() | Gets CampaignsV3Api |
| getSoftwareManagementReportsV3Api() | Gets SoftwareManagementReportsV3Api |
| getFirmwareV3Api() | Gets FirmwareV3Api |
| getAccountDevicesApi() | Gets AccountDevicesApi |
| getSoftwareManagementCallbacksV3Api() | Gets SoftwareManagementCallbacksV3Api |
| getSimSecureForIoTLicensesApi() | Gets SimSecureForIoTLicensesApi |
| getAccountSubscriptionsApi() | Gets AccountSubscriptionsApi |
| getPerformanceMetricsApi() | Gets PerformanceMetricsApi |
| getDiagnosticsSubscriptionsApi() | Gets DiagnosticsSubscriptionsApi |
| getDiagnosticsObservationsApi() | Gets DiagnosticsObservationsApi |
| getDiagnosticsHistoryApi() | Gets DiagnosticsHistoryApi |
| getDiagnosticsSettingsApi() | Gets DiagnosticsSettingsApi |
| getDiagnosticsCallbacksApi() | Gets DiagnosticsCallbacksApi |
| getDiagnosticsFactoryResetApi() | Gets DiagnosticsFactoryResetApi |
| getTargetsApi() | Gets TargetsApi |
| getCloudConnectorSubscriptionsApi() | Gets CloudConnectorSubscriptionsApi |
| getCloudConnectorDevicesApi() | Gets CloudConnectorDevicesApi |
| getDeviceServiceManagementApi() | Gets DeviceServiceManagementApi |
| getDeviceReportsApi() | Gets DeviceReportsApi |
| getHyperPreciseLocationCallbacksApi() | Gets HyperPreciseLocationCallbacksApi |
| getAnomalySettingsApi() | Gets AnomalySettingsApi |
| getAnomalyTriggersApi() | Gets AnomalyTriggersApi |
| getAnomalyTriggersV2Api() | Gets AnomalyTriggersV2Api |
| getWirelessNetworkPerformanceApi() | Gets WirelessNetworkPerformanceApi |
| getManagingEsimProfilesApi() | Gets ManagingEsimProfilesApi |
| getDeviceSmsMessagingApi() | Gets DeviceSmsMessagingApi |
| getDeviceActionsApi() | Gets DeviceActionsApi |
| getThingSpaceQualityOfServiceApiActionsApi() | Gets ThingSpaceQualityOfServiceApiActionsApi |
| getPwnApi() | Gets PwnApi |
| getPromotionPeriodInformationApi() | Gets PromotionPeriodInformationApi |
| getRetrieveTheTriggersApi() | Gets RetrieveTheTriggersApi |
| getUpdateTriggersApi() | Gets UpdateTriggersApi |
| getSimActionsApi() | Gets SimActionsApi |
| getGlobalReportingApi() | Gets GlobalReportingApi |
| getRetrieveRatePlanListApi() | Gets RetrieveRatePlanListApi |
| getCreatePricePlanTriggersApi() | Gets CreatePricePlanTriggersApi |
| getUpdatePricePlanTriggersApi() | Gets UpdatePricePlanTriggersApi |
| getM5GBiDeviceActionsApi() | Gets M5GBiDeviceActionsApi |
| getSensorInsightsSensorsApi() | Gets SensorInsightsSensorsApi |
| getSensorInsightsDevicesApi() | Gets SensorInsightsDevicesApi |
| getSensorInsightsGatewaysApi() | Gets SensorInsightsGatewaysApi |
| getSensorInsightsSmartAlertsApi() | Gets SensorInsightsSmartAlertsApi |
| getSensorInsightsRulesApi() | Gets SensorInsightsRulesApi |
| getSensorInsightsHealthScoreApi() | Gets SensorInsightsHealthScoreApi |
| getSensorInsightsNotificationGroupsApi() | Gets SensorInsightsNotificationGroupsApi |
| getSensorInsightsUsersApi() | Gets SensorInsightsUsersApi |
| getSensorInsightsDeviceProfileApi() | Gets SensorInsightsDeviceProfileApi |
| getSensorInsightsSmartAlertMetricsApi() | Gets SensorInsightsSmartAlertMetricsApi |
| getAppConfigServiceApi() | Gets AppConfigServiceApi |
| getRegistrationApi() | Gets RegistrationApi |
| getMapDataManagerApi() | Gets MapDataManagerApi |
| getOauthAuthorizationApi() | Gets OauthAuthorizationApi |

