# Software Management Callbacks V1

```csharp
SoftwareManagementCallbacksV1Api softwareManagementCallbacksV1Api = client.SoftwareManagementCallbacksV1Api;
```

## Class Name

`SoftwareManagementCallbacksV1Api`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v1.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/software-management-callbacks-v1.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v1.md#deregister-callback)


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```csharp
ListRegisteredCallbacksAsync(
    string account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.RegisteredCallbacks>](../../doc/models/registered-callbacks.md).

## Example Usage

```csharp
string account = "0242078689-00001";
try
{
    ApiResponse<List<RegisteredCallbacks>> result = await softwareManagementCallbacksV1Api.ListRegisteredCallbacksAsync(account);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "aname": "0252012345-00001",
    "name": "Fota",
    "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Register Callback

Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.

```csharp
RegisterCallbackAsync(
    string account,
    Models.FotaV1CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`FotaV1CallbackRegistrationRequest`](../../doc/models/fota-v1-callback-registration-request.md) | Body, Required | Callback details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.FotaV1CallbackRegistrationResult](../../doc/models/fota-v1-callback-registration-result.md).

## Example Usage

```csharp
string account = "0242078689-00001";
FotaV1CallbackRegistrationRequest body = new FotaV1CallbackRegistrationRequest
{
    Name = "Fota",
    Url = "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
};

try
{
    ApiResponse<FotaV1CallbackRegistrationResult> result = await softwareManagementCallbacksV1Api.RegisterCallbackAsync(
        account,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0204563412-00001",
  "serviceName": "Fota"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Deregister Callback

Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.

```csharp
DeregisterCallbackAsync(
    string account,
    Models.CallbackService service)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `service` | [`CallbackService`](../../doc/models/callback-service.md) | Template, Required | Callback type. Must be 'Fota' for Software Management Services API. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.FotaV1SuccessResult](../../doc/models/fota-v1-success-result.md).

## Example Usage

```csharp
string account = "0242078689-00001";
CallbackService service = CallbackService.Fota;
try
{
    ApiResponse<FotaV1SuccessResult> result = await softwareManagementCallbacksV1Api.DeregisterCallbackAsync(
        account,
        service
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

