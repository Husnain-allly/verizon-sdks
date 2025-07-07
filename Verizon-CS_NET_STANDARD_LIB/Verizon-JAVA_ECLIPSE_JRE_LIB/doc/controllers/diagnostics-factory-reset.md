# Diagnostics Factory Reset

```java
DiagnosticsFactoryResetApi diagnosticsFactoryResetApi = client.getDiagnosticsFactoryResetApi();
```

## Class Name

`DiagnosticsFactoryResetApi`


# Decives Restart

Performs a device reboot or a factory reset on the modem portion of the device.

```java
CompletableFuture<ApiResponse<DiagnosticsObservationResult>> decivesRestartAsync(
    final DeviceResetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceResetRequest`](../../doc/models/device-reset-request.md) | Body, Required | A request to perform a device reboot. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DiagnosticsObservationResult`](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```java
DeviceResetRequest body = new DeviceResetRequest.Builder()
    .accountName("0642233522-00003")
    .action("reboot")
    .devices(Arrays.asList(
        new Device.Builder(
            "355154080648401",
            "IMEI"
        )
        .build()
    ))
    .build();

diagnosticsFactoryResetApi.decivesRestartAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "createdOn": "2019-02-03T06:48:07",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "FACTORY_RESET_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

