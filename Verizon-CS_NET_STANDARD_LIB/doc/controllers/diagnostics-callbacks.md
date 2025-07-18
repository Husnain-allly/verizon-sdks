# Diagnostics Callbacks

```csharp
DiagnosticsCallbacksApi diagnosticsCallbacksApi = client.DiagnosticsCallbacksApi;
```

## Class Name

`DiagnosticsCallbacksApi`

## Methods

* [Get Diagnostics Subscription Callback Info](../../doc/controllers/diagnostics-callbacks.md#get-diagnostics-subscription-callback-info)
* [Register Diagnostics Callback URL](../../doc/controllers/diagnostics-callbacks.md#register-diagnostics-callback-url)
* [Unregister Diagnostics Callback](../../doc/controllers/diagnostics-callbacks.md#unregister-diagnostics-callback)


# Get Diagnostics Subscription Callback Info

This endpoint allows user to get the registered callback information of an existing diagnostics subscription.

```csharp
GetDiagnosticsSubscriptionCallbackInfoAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DeviceDiagnosticsCallback>](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<List<DeviceDiagnosticsCallback>> result = await diagnosticsCallbacksApi.GetDiagnosticsSubscriptionCallbackInfoAsync(accountName);
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
    "accountName": "TestQAAccount",
    "serviceName": "string",
    "endpoint": "https://yourwebsite.com",
    "httpHeaders": {},
    "createdOn": "2019-09-07T23:57:53.292Z"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Register Diagnostics Callback URL

This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.

```csharp
RegisterDiagnosticsCallbackUrlAsync(
    Models.CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CallbackRegistrationRequest`](../../doc/models/callback-registration-request.md) | Body, Required | Callback URL registration request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceDiagnosticsCallback](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```csharp
CallbackRegistrationRequest body = new CallbackRegistrationRequest
{
    AccountName = "TestQAAccount",
    ServiceName = "Diagnostics",
    Endpoint = "https://yourwebsite.com",
    HttpHeaders = ApiHelper.JsonDeserialize<object>("{}"),
};

try
{
    ApiResponse<DeviceDiagnosticsCallback> result = await diagnosticsCallbacksApi.RegisterDiagnosticsCallbackUrlAsync(body);
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
  "accountName": "TestQAAccount",
  "serviceName": "string",
  "endpoint": "https://yourwebsite.com",
  "httpHeaders": {},
  "createdOn": "2019-09-07T23:57:53.292Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Unregister Diagnostics Callback

This endpoint allows user to delete a registered callback URL and credential.

```csharp
UnregisterDiagnosticsCallbackAsync(
    string accountName,
    string serviceName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |
| `serviceName` | `string` | Query, Required | Service name for callback notification. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceDiagnosticsCallback](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
string serviceName = "string";
try
{
    ApiResponse<DeviceDiagnosticsCallback> result = await diagnosticsCallbacksApi.UnregisterDiagnosticsCallbackAsync(
        accountName,
        serviceName
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
  "accountName": "TestQAAccount",
  "serviceName": "string",
  "endpoint": "https://yourwebsite.com",
  "httpHeaders": {},
  "createdOn": "2019-09-07T23:57:53.292Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

