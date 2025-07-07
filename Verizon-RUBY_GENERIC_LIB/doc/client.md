
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| environment | `Environment` | The API environment. <br> **Default: `Environment.PRODUCTION`** |
| connection | `Faraday::Connection` | The Faraday connection object passed by the SDK user for making requests |
| adapter | `Faraday::Adapter` | The Faraday adapter object passed by the SDK user for performing http requests |
| timeout | `Float` | The value to use for connection timeout. <br> **Default: 30** |
| max_retries | `Integer` | The number of times to retry an endpoint call if it fails. <br> **Default: 0** |
| retry_interval | `Float` | Pause in seconds between retries. <br> **Default: 1** |
| backoff_factor | `Float` | The amount to multiply each successive retry's interval amount by in order to provide backoff. <br> **Default: 2** |
| retry_statuses | `Array` | A list of HTTP statuses to retry. <br> **Default: [408, 413, 429, 500, 502, 503, 504, 521, 522, 524]** |
| retry_methods | `Array` | A list of HTTP methods to retry. <br> **Default: %i[get put]** |
| http_callback | `HttpCallBack` | The Http CallBack allows defining callables for pre and post API calls. |
| logging_configuration | [`LoggingConfiguration`](../doc/logging-configuration.md) | The SDK logging configuration for API calls |
| thingspace_oauth_credentials | [`ThingspaceOauthCredentials`](auth/oauth-2-client-credentials-grant.md) | The credential object for OAuth 2 Client Credentials Grant |
| vz_m2m_token_credentials | [`VzM2MTokenCredentials`](auth/custom-header-signature.md) | The credential object for Custom Header Signature |
| thingspace_oauth_1_credentials | [`ThingspaceOauth1Credentials`](auth/oauth-2-client-credentials-grant-1.md) | The credential object for OAuth 2 Client Credentials Grant |
| session_token_credentials | [`SessionTokenCredentials`](auth/custom-header-signature-1.md) | The credential object for Custom Header Signature |

The API client can be initialized as follows:

```ruby
client = Verizon::Client.new(
  thingspace_oauth_credentials: ThingspaceOauthCredentials.new(
    oauth_client_id: 'OAuthClientId',
    oauth_client_secret: 'OAuthClientSecret',
    oauth_scopes: [
      OauthScopeThingspaceOauth::DISCOVERYREAD,
      OauthScopeThingspaceOauth::SERVICEPROFILEREAD
    ]
  ),
  vz_m2m_token_credentials: VzM2MTokenCredentials.new(
    vz_m2m_token: 'VZ-M2M-Token'
  ),
  thingspace_oauth_1_credentials: ThingspaceOauth1Credentials.new(
    oauth_client_id: 'OAuthClientId',
    oauth_client_secret: 'OAuthClientSecret'
  ),
  session_token_credentials: SessionTokenCredentials.new(
    session_token: 'SessionToken'
  ),
  environment: Environment::PRODUCTION,
  logging_configuration: LoggingConfiguration.new(
    log_level: Logger::INFO,
    request_logging_config: RequestLoggingConfiguration.new(
      log_body: true
    ),
    response_logging_config: ResponseLoggingConfiguration.new(
      log_headers: true
    )
  )
)
```

## Verizon Client

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

## Apis

| Name | Description |
|  --- | --- |
| m_5g_edge_platforms | Gets M5GEdgePlatformsApi |
| service_endpoints | Gets ServiceEndpointsApi |
| service_profiles | Gets ServiceProfilesApi |
| device_management | Gets DeviceManagementApi |
| accounts | Gets AccountsApi |
| device_groups | Gets DeviceGroupsApi |
| sms | Gets SmsApi |
| session_management | Gets SessionManagementApi |
| connectivity_callbacks | Gets ConnectivityCallbacksApi |
| account_requests | Gets AccountRequestsApi |
| service_plans | Gets ServicePlansApi |
| device_diagnostics | Gets DeviceDiagnosticsApi |
| device_monitoring | Gets DeviceMonitoringApi |
| device_profile_management | Gets DeviceProfileManagementApi |
| e_uicc_device_profile_management | Gets EuiccDeviceProfileManagementApi |
| devices_locations | Gets DevicesLocationsApi |
| exclusions | Gets ExclusionsApi |
| devices_location_subscriptions | Gets DevicesLocationSubscriptionsApi |
| device_location_callbacks | Gets DeviceLocationCallbacksApi |
| usage_trigger_management | Gets UsageTriggerManagementApi |
| billing | Gets BillingApi |
| software_management_subscriptions_v1 | Gets SoftwareManagementSubscriptionsV1Api |
| software_management_licenses_v1 | Gets SoftwareManagementLicensesV1Api |
| firmware_v1 | Gets FirmwareV1Api |
| software_management_callbacks_v1 | Gets SoftwareManagementCallbacksV1Api |
| software_management_reports_v1 | Gets SoftwareManagementReportsV1Api |
| software_management_subscriptions_v2 | Gets SoftwareManagementSubscriptionsV2Api |
| software_management_licenses_v2 | Gets SoftwareManagementLicensesV2Api |
| campaigns_v2 | Gets CampaignsV2Api |
| software_management_callbacks_v2 | Gets SoftwareManagementCallbacksV2Api |
| software_management_reports_v2 | Gets SoftwareManagementReportsV2Api |
| client_logging | Gets ClientLoggingApi |
| server_logging | Gets ServerLoggingApi |
| configuration_files | Gets ConfigurationFilesApi |
| software_management_subscriptions_v3 | Gets SoftwareManagementSubscriptionsV3Api |
| software_management_licenses_v3 | Gets SoftwareManagementLicensesV3Api |
| campaigns_v3 | Gets CampaignsV3Api |
| software_management_reports_v3 | Gets SoftwareManagementReportsV3Api |
| firmware_v3 | Gets FirmwareV3Api |
| account_devices | Gets AccountDevicesApi |
| software_management_callbacks_v3 | Gets SoftwareManagementCallbacksV3Api |
| sim_secure_for_io_t_licenses | Gets SimSecureForIoTLicensesApi |
| account_subscriptions | Gets AccountSubscriptionsApi |
| performance_metrics | Gets PerformanceMetricsApi |
| diagnostics_subscriptions | Gets DiagnosticsSubscriptionsApi |
| diagnostics_observations | Gets DiagnosticsObservationsApi |
| diagnostics_history | Gets DiagnosticsHistoryApi |
| diagnostics_settings | Gets DiagnosticsSettingsApi |
| diagnostics_callbacks | Gets DiagnosticsCallbacksApi |
| diagnostics_factory_reset | Gets DiagnosticsFactoryResetApi |
| targets | Gets TargetsApi |
| cloud_connector_subscriptions | Gets CloudConnectorSubscriptionsApi |
| cloud_connector_devices | Gets CloudConnectorDevicesApi |
| device_service_management | Gets DeviceServiceManagementApi |
| device_reports | Gets DeviceReportsApi |
| hyper_precise_location_callbacks | Gets HyperPreciseLocationCallbacksApi |
| anomaly_settings | Gets AnomalySettingsApi |
| anomaly_triggers | Gets AnomalyTriggersApi |
| anomaly_triggers_v2 | Gets AnomalyTriggersV2Api |
| wireless_network_performance | Gets WirelessNetworkPerformanceApi |
| managing_e_sim_profiles | Gets ManagingEsimProfilesApi |
| device_sms_messaging | Gets DeviceSmsMessagingApi |
| device_actions | Gets DeviceActionsApi |
| thing_space_quality_of_service_api_actions | Gets ThingSpaceQualityOfServiceApiActionsApi |
| pwn | Gets PwnApi |
| promotion_period_information | Gets PromotionPeriodInformationApi |
| retrieve_the_triggers | Gets RetrieveTheTriggersApi |
| update_triggers | Gets UpdateTriggersApi |
| sim_actions | Gets SimActionsApi |
| global_reporting | Gets GlobalReportingApi |
| retrieve_rate_plan_list | Gets RetrieveRatePlanListApi |
| create_price_plan_triggers | Gets CreatePricePlanTriggersApi |
| update_price_plan_triggers | Gets UpdatePricePlanTriggersApi |
| m_5g_bi_device_actions | Gets M5GBiDeviceActionsApi |
| sensor_insights_sensors | Gets SensorInsightsSensorsApi |
| sensor_insights_devices | Gets SensorInsightsDevicesApi |
| sensor_insights_gateways | Gets SensorInsightsGatewaysApi |
| sensor_insights_smart_alerts | Gets SensorInsightsSmartAlertsApi |
| sensor_insights_rules | Gets SensorInsightsRulesApi |
| sensor_insights_health_score | Gets SensorInsightsHealthScoreApi |
| sensor_insights_notification_groups | Gets SensorInsightsNotificationGroupsApi |
| sensor_insights_users | Gets SensorInsightsUsersApi |
| sensor_insights_device_profile | Gets SensorInsightsDeviceProfileApi |
| sensor_insights_smart_alert_metrics | Gets SensorInsightsSmartAlertMetricsApi |
| app_config_service | Gets AppConfigServiceApi |
| registration | Gets RegistrationApi |
| map_data_manager | Gets MapDataManagerApi |
| oauth_authorization | Gets OauthAuthorizationApi |

