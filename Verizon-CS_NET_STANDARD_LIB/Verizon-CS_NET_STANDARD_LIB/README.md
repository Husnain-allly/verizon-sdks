
# Getting Started with Verizon

## Introduction

The Verizon Edge Discovery Service API can direct your application clients to connect to the optimal service endpoints for your Multi-access Edge Computing (MEC) applications for every session. The Edge Discovery Service takes into account the current location of a device, its IP anchor location, current network traffic and other factors to determine which 5G Edge platform a device should connect to.

Verizon Terms of Service: [https://www.verizon.com/business/5g-edge-portal/legal.html](https://www.verizon.com/business/5g-edge-portal/legal.html)

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (Verizon.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the Verizon.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Verizon-CSharp&workspaceName=Verizon&projectName=Verizon.Standard&rootNamespace=Verizon.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Verizon-CSharp&workspaceName=Verizon&projectName=Verizon.Standard&rootNamespace=Verizon.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Verizon-CSharp&workspaceName=Verizon&projectName=Verizon.Standard&rootNamespace=Verizon.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `Verizon.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Verizon-CSharp&workspaceName=Verizon&projectName=Verizon.Standard&rootNamespace=Verizon.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `Verizon.Standard` and click `OK`. By doing this, we have added a reference of the `Verizon.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Verizon-CSharp&workspaceName=Verizon&projectName=Verizon.Standard&rootNamespace=Verizon.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Api class. Sample code to initialize the client library and using Api methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Verizon-CSharp&workspaceName=Verizon&projectName=Verizon.Standard&rootNamespace=Verizon.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ThingspaceOauthCredentials | [`ThingspaceOauthCredentials`](doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| VzM2MTokenCredentials | [`VzM2MTokenCredentials`](doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| ThingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](doc/auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| SessionTokenCredentials | [`SessionTokenCredentials`](doc/auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

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

* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](doc/http-client-configuration-builder.md)
* [LogBuilder](doc/log-builder.md)
* [LogRequestBuilder](doc/log-request-builder.md)
* [LogResponseBuilder](doc/log-response-builder.md)
* [ProxyConfigurationBuilder](doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](doc/http-callback.md)
* [HttpContext](doc/http-context.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)

### Utilities

* [ApiException](doc/api-exception.md)
* [ApiResponse](doc/api-response.md)
* [ApiHelper](doc/api-helper.md)
* [CustomDateTimeConverter](doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](doc/unix-date-time-converter.md)

