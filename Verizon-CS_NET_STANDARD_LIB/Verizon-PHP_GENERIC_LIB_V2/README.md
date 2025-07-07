
# Getting Started with Verizon

## Introduction

The Verizon Edge Discovery Service API can direct your application clients to connect to the optimal service endpoints for your Multi-access Edge Computing (MEC) applications for every session. The Edge Discovery Service takes into account the current location of a device, its IP anchor location, current network traffic and other factors to determine which 5G Edge platform a device should connect to.

Verizon Terms of Service: [https://www.verizon.com/business/5g-edge-portal/legal.html](https://www.verizon.com/business/5g-edge-portal/legal.html)

## Building

The generated code has dependencies over external libraries like UniRest and JsonMapper. JsonMapper requires docblock annotations like `@var`, `@maps`, and `@factory` to map JSON responses with our class definitions. Hence the docblocks in generated code cannot be disabled by deactivating the PHP configurations like `opcache.save_comments`. These dependencies are defined in the `composer.json` file that comes with the SDK. To resolve these dependencies, we use the Composer package manager which requires PHP greater than or equal to 7.2 installed in your system. Visit [https://getcomposer.org/download/](https://getcomposer.org/download/) to download the installer file for Composer and run it in your system. Open command prompt and type `composer --version`. This should display the current version of the Composer installed if the installation was successful.

* Using command line, navigate to the directory containing the generated files (including `composer.json`) for the SDK.
* Run the command `composer install`. This should install all the required dependencies and create the `vendor` directory in your project directory.

![Building SDK - Step 1](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=installDependencies)

### Configuring CURL Certificate Path in php.ini

:information_source: **Note** This is for Windows users only.

CURL used to include a list of accepted CAs, but no longer bundles ANY CA certs. So by default it will reject all SSL certificates as unverifiable. You will have to get your CA's cert and point curl at it. The steps are as follows:

1. Download the certificate bundle (.pem file) from [https://curl.haxx.se/docs/caextract.html](https://curl.haxx.se/docs/caextract.html) on to your system.
2. Add curl.cainfo = "PATH_TO/cacert.pem" to your php.ini file located in your php installation. “PATH_TO” must be an absolute path containing the .pem file.

```
[curl]; A default value for the CURLOPT_CAINFO option. This is required to be an
; absolute path.
curl.cainfo = PATH_TO/cacert.pem
```

## Installation

The following section explains how to use the VerizonLib library in a new project.

### 1. Open Project in an IDE

Open an IDE for PHP like PhpStorm. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

![Open project in PHPStorm - Step 1](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=openIDE)

Click on `Open` in PhpStorm to browse to your generated SDK directory and then click `OK`.

![Open project in PHPStorm - Step 2](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=openProject0)

### 2. Add a new Test Project

Create a new directory by right clicking on the solution name as shown below:

![Add a new project in PHPStorm - Step 1](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=createDirectory)

Name the directory as "test".

![Add a new project in PHPStorm - Step 2](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=nameDirectory)

Add a PHP file to this project.

![Add a new project in PHPStorm - Step 3](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=createFile)

Name it "testSDK".

![Add a new project in PHPStorm - Step 4](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=nameFile)

Depending on your project setup, you might need to include composer's autoloader in your PHP code to enable auto loading of classes.

```php
require_once "vendor/autoload.php";
```

It is important that the path inside require_once correctly points to the file `autoload.php` inside the vendor directory created during dependency installations.

![Add a new project in PHPStorm - Step 5](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=projectFiles)

After this you can add code to initialize the client library and acquire the instance of a Api class. Sample code to initialize the client library and use the Api methods is given in the subsequent sections.

### 3. Run the Test Project

To run your project you must set the Interpreter for your project. Interpreter is the PHP engine installed on your computer.

Open `Settings` from `File` menu.

![Run Test Project - Step 1](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=openSettings)

Select `PHP` from within `Languages & Frameworks`.

![Run Test Project - Step 2](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=setInterpreter0)

Browse for Interpreters near the `Interpreter` option and choose your interpreter.

![Run Test Project - Step 3](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=setInterpreter1)

Once the interpreter is selected, click `OK`.

![Run Test Project - Step 4](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=setInterpreter2)

To run your project, right click on your PHP file inside your Test project and click on `Run`.

![Run Test Project - Step 5](https://apidocs.io/illustration/php?workspaceFolder=Verizon&step=runProject)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

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
| loggingConfiguration | [`LoggingConfigurationBuilder`](doc/logging-configuration-builder.md) | Represents the logging configurations for API calls |
| proxyConfiguration | [`ProxyConfigurationBuilder`](doc/proxy-configuration-builder.md) | Represents the proxy configurations for API calls |
| thingspaceOauthCredentials | [`ThingspaceOauthCredentials`](doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| vzM2MTokenCredentials | [`VzM2MTokenCredentials`](doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| thingspaceOauth1Credentials | [`ThingspaceOauth1Credentials`](doc/auth/oauth-2-client-credentials-grant-1.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| sessionTokenCredentials | [`SessionTokenCredentials`](doc/auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

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

* [ProxyConfigurationBuilder](doc/proxy-configuration-builder.md)
* [LoggingConfigurationBuilder](doc/logging-configuration-builder.md)
* [RequestLoggingConfigurationBuilder](doc/request-logging-configuration-builder.md)
* [ResponseLoggingConfigurationBuilder](doc/response-logging-configuration-builder.md)

### HTTP

* [HttpRequest](doc/http-request.md)

### Utilities

* [FileWrapper](doc/file-wrapper.md)
* [ApiResponse](doc/api-response.md)

