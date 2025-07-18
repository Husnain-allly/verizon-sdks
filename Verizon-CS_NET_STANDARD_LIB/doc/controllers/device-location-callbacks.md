# Device Location Callbacks

```csharp
DeviceLocationCallbacksApi deviceLocationCallbacksApi = client.DeviceLocationCallbacksApi;
```

## Class Name

`DeviceLocationCallbacksApi`

## Methods

* [Cancel Async Report](../../doc/controllers/device-location-callbacks.md#cancel-async-report)
* [List Registered Callbacks](../../doc/controllers/device-location-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/device-location-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/device-location-callbacks.md#deregister-callback)


# Cancel Async Report

Cancel an asynchronous report request.

```csharp
CancelAsyncReportAsync(
    string accountName,
    string txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | The `transactionId` value. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionId](../../doc/models/transaction-id.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
string txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33";
try
{
    ApiResponse<TransactionId> result = await deviceLocationCallbacksApi.CancelAsyncReportAsync(
        accountName,
        txid
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Registered Callbacks

Returns a list of all registered callback URLs for the account.

```csharp
ListRegisteredCallbacksAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DeviceLocationCallback>](../../doc/models/device-location-callback.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<List<DeviceLocationCallback>> result = await deviceLocationCallbacksApi.ListRegisteredCallbacksAsync(accountName);
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
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/Location.asmx"
  },
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/DeviceLocation.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Register Callback

Provide a URL to receive messages from a ThingSpace callback service.

```csharp
RegisterCallbackAsync(
    string accountName,
    Models.DeviceLocationCallback body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `body` | [`DeviceLocationCallback`](../../doc/models/device-location-callback.md) | Body, Required | Request to register a callback. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CallbackRegistrationResult](../../doc/models/callback-registration-result.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
DeviceLocationCallback body = new DeviceLocationCallback
{
    Name = CallbackServiceName.Location,
    Url = "http://10.120.102.183:50559/CallbackListener/LocationServiceMessages.asmx",
};

try
{
    ApiResponse<CallbackRegistrationResult> result = await deviceLocationCallbacksApi.RegisterCallbackAsync(
        accountName,
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
  "account": "0212312345-00001",
  "name": "Location"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Deregister Callback

Deregister a URL to stop receiving callback messages.

```csharp
DeregisterCallbackAsync(
    string accountName,
    Models.CallbackServiceName service)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `service` | [`CallbackServiceName`](../../doc/models/callback-service-name.md) | Template, Required | Callback service name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
CallbackServiceName service = CallbackServiceName.Location;
try
{
    ApiResponse<DeviceLocationSuccessResult> result = await deviceLocationCallbacksApi.DeregisterCallbackAsync(
        accountName,
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
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

