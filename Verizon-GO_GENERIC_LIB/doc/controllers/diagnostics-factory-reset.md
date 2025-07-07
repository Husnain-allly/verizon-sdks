# Diagnostics Factory Reset

```go
diagnosticsFactoryResetApi := client.DiagnosticsFactoryResetApi()
```

## Class Name

`DiagnosticsFactoryResetApi`


# Decives Restart

Performs a device reboot or a factory reset on the modem portion of the device.

```go
DecivesRestart(
    ctx context.Context,
    body models.DeviceResetRequest) (
    models.ApiResponse[models.DiagnosticsObservationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeviceResetRequest`](../../doc/models/device-reset-request.md) | Body, Required | A request to perform a device reboot. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DiagnosticsObservationResult](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.DeviceResetRequest{
    AccountName:           models.ToPointer("0642233522-00003"),
    Action:                models.ToPointer("reboot"),
    Devices:               []models.Device{
        models.Device{
            Id:                    "355154080648401",
            Kind:                  "IMEI",
        },
    },
}

apiResponse, err := diagnosticsFactoryResetApi.DecivesRestart(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

