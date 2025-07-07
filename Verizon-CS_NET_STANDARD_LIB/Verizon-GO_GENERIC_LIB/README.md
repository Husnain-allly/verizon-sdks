
# Getting Started with Verizon

## Introduction

The Verizon Edge Discovery Service API can direct your application clients to connect to the optimal service endpoints for your Multi-access Edge Computing (MEC) applications for every session. The Edge Discovery Service takes into account the current location of a device, its IP anchor location, current network traffic and other factors to determine which 5G Edge platform a device should connect to.

Verizon Terms of Service: [https://www.verizon.com/business/5g-edge-portal/legal.html](https://www.verizon.com/business/5g-edge-portal/legal.html)

### Requirements

The SDK requires **Go version 1.18 or above**.

## Building

### Install Dependencies

Resolve all the SDK dependencies, using the `go get` command.

## Installation

The following section explains how to use the verizon library in a new project.

### 1. Add SDK as a Dependency to the Application

- Add the following lines to your application's `go.mod` file:

```go
replace verizon => ".\\Verizon" // local path to the SDK

require verizon v0.0.0
```

- Resolve the dependencies in the updated `go.mod` file, using the `go get` command.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| environment | `Environment` | The API environment. <br> **Default: `Environment.PRODUCTION`** |
| httpConfiguration | [`HttpConfiguration`](doc/http-configuration.md) | Configurable http client options like timeout and retries. |
| loggerConfiguration | [`LoggerConfiguration`](doc/logger-configuration.md) | Represents the logger configurations for API calls |
| thingspaceOauthCredentials | [`ThingspaceOauthCredentials`](doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| vzM2MTokenCredentials | [`VzM2MTokenCredentials`](doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| thingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](doc/auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| sessionTokenCredentials | [`SessionTokenCredentials`](doc/auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

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

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |
| Mock server for limited availability, see quick start | - |

## Authorization

This API uses the following authentication schemes.

* [`thingspace_oauth (OAuth 2 Client Credentials Grant)`](doc/auth/oauth-2-client-credentials-grant.md)
* [`VZ-M2M-Token (Custom Header Signature)`](doc/auth/custom-header-signature.md)
* [`thingspace_oauth1 (OAuth 2 Client Credentials Grant)`](doc/auth/oauth-2-client-credentials-grant-1.md)
* [`SessionToken (Custom Header Signature)`](doc/auth/custom-header-signature-1.md)

## List of APIs

* [5G Edge Platforms](doc/controllers/5g-edge-platforms.md)
* [Service Endpoints](doc/controllers/service-endpoints.md)
* [Service Profiles](doc/controllers/service-profiles.md)
* [Device Management](doc/controllers/device-management.md)
* [Device Groups](doc/controllers/device-groups.md)
* [Session Management](doc/controllers/session-management.md)
* [Connectivity Callbacks](doc/controllers/connectivity-callbacks.md)
* [Account Requests](doc/controllers/account-requests.md)
* [Service Plans](doc/controllers/service-plans.md)
* [Device Diagnostics](doc/controllers/device-diagnostics.md)
* [Device Monitoring](doc/controllers/device-monitoring.md)
* [Device Profile Management](doc/controllers/device-profile-management.md)
* [E UICC Device Profile Management](doc/controllers/e-uicc-device-profile-management.md)
* [Devices Locations](doc/controllers/devices-locations.md)
* [Devices Location Subscriptions](doc/controllers/devices-location-subscriptions.md)
* [Device Location Callbacks](doc/controllers/device-location-callbacks.md)
* [Usage Trigger Management](doc/controllers/usage-trigger-management.md)
* [Software Management Subscriptions V1](doc/controllers/software-management-subscriptions-v1.md)
* [Software Management Licenses V1](doc/controllers/software-management-licenses-v1.md)
* [Firmware V1](doc/controllers/firmware-v1.md)
* [Software Management Callbacks V1](doc/controllers/software-management-callbacks-v1.md)
* [Software Management Reports V1](doc/controllers/software-management-reports-v1.md)
* [Software Management Subscriptions V2](doc/controllers/software-management-subscriptions-v2.md)
* [Software Management Licenses V2](doc/controllers/software-management-licenses-v2.md)
* [Campaigns V2](doc/controllers/campaigns-v2.md)
* [Software Management Callbacks V2](doc/controllers/software-management-callbacks-v2.md)
* [Software Management Reports V2](doc/controllers/software-management-reports-v2.md)
* [Client Logging](doc/controllers/client-logging.md)
* [Server Logging](doc/controllers/server-logging.md)
* [Configuration Files](doc/controllers/configuration-files.md)
* [Software Management Subscriptions V3](doc/controllers/software-management-subscriptions-v3.md)
* [Software Management Licenses V3](doc/controllers/software-management-licenses-v3.md)
* [Campaigns V3](doc/controllers/campaigns-v3.md)
* [Software Management Reports V3](doc/controllers/software-management-reports-v3.md)
* [Firmware V3](doc/controllers/firmware-v3.md)
* [Account Devices](doc/controllers/account-devices.md)
* [Software Management Callbacks V3](doc/controllers/software-management-callbacks-v3.md)
* [SIM Securefor Io T Licenses](doc/controllers/sim-securefor-io-t-licenses.md)
* [Account Subscriptions](doc/controllers/account-subscriptions.md)
* [Performance Metrics](doc/controllers/performance-metrics.md)
* [Diagnostics Subscriptions](doc/controllers/diagnostics-subscriptions.md)
* [Diagnostics Observations](doc/controllers/diagnostics-observations.md)
* [Diagnostics History](doc/controllers/diagnostics-history.md)
* [Diagnostics Settings](doc/controllers/diagnostics-settings.md)
* [Diagnostics Callbacks](doc/controllers/diagnostics-callbacks.md)
* [Diagnostics Factory Reset](doc/controllers/diagnostics-factory-reset.md)
* [Cloud Connector Subscriptions](doc/controllers/cloud-connector-subscriptions.md)
* [Cloud Connector Devices](doc/controllers/cloud-connector-devices.md)
* [Device Service Management](doc/controllers/device-service-management.md)
* [Device Reports](doc/controllers/device-reports.md)
* [Hyper Precise Location Callbacks](doc/controllers/hyper-precise-location-callbacks.md)
* [Anomaly Settings](doc/controllers/anomaly-settings.md)
* [Anomaly Triggers](doc/controllers/anomaly-triggers.md)
* [Anomaly Triggers V2](doc/controllers/anomaly-triggers-v2.md)
* [Wireless Network Performance](doc/controllers/wireless-network-performance.md)
* [Managinge SIM Profiles](doc/controllers/managinge-sim-profiles.md)
* [Device SMS Messaging](doc/controllers/device-sms-messaging.md)
* [Device Actions](doc/controllers/device-actions.md)
* [Thing Space Qualityof Service API Actions](doc/controllers/thing-space-qualityof-service-api-actions.md)
* [Promotion Period Information](doc/controllers/promotion-period-information.md)
* [Retrievethe Triggers](doc/controllers/retrievethe-triggers.md)
* [Update Triggers](doc/controllers/update-triggers.md)
* [SIM Actions](doc/controllers/sim-actions.md)
* [Global Reporting](doc/controllers/global-reporting.md)
* [Retrieve Rate Plan List](doc/controllers/retrieve-rate-plan-list.md)
* [Create Price Plan Triggers](doc/controllers/create-price-plan-triggers.md)
* [Update Price Plan Triggers](doc/controllers/update-price-plan-triggers.md)
* [5G BI Device Actions](doc/controllers/5g-bi-device-actions.md)
* [Sensor Insights Sensors](doc/controllers/sensor-insights-sensors.md)
* [Sensor Insights Devices](doc/controllers/sensor-insights-devices.md)
* [Sensor Insights Gateways](doc/controllers/sensor-insights-gateways.md)
* [Sensor Insights Smart Alerts](doc/controllers/sensor-insights-smart-alerts.md)
* [Sensor Insights Rules](doc/controllers/sensor-insights-rules.md)
* [Sensor Insights Health Score](doc/controllers/sensor-insights-health-score.md)
* [Sensor Insights Notification Groups](doc/controllers/sensor-insights-notification-groups.md)
* [Sensor Insights Users](doc/controllers/sensor-insights-users.md)
* [Sensor Insights Device Profile](doc/controllers/sensor-insights-device-profile.md)
* [Sensor Insights Smart Alert Metrics](doc/controllers/sensor-insights-smart-alert-metrics.md)
* [App Config Service](doc/controllers/app-config-service.md)
* [Map Data Manager](doc/controllers/map-data-manager.md)
* [Accounts](doc/controllers/accounts.md)
* [SMS](doc/controllers/sms.md)
* [Exclusions](doc/controllers/exclusions.md)
* [Billing](doc/controllers/billing.md)
* [Targets](doc/controllers/targets.md)
* [PWN](doc/controllers/pwn.md)
* [Registration](doc/controllers/registration.md)

## SDK Infrastructure

### Configuration

* [HttpConfiguration](doc/http-configuration.md)
* [LoggerConfiguration](doc/logger-configuration.md)
* [RequestLoggerConfiguration](doc/request-logger-configuration.md)
* [ResponseLoggerConfiguration](doc/response-logger-configuration.md)
* [RetryConfiguration](doc/retry-configuration.md)

### Utilities

* [ApiResponse](doc/api-response.md)

