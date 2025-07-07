# Diagnostics Settings

```go
diagnosticsSettingsApi := client.DiagnosticsSettingsApi()
```

## Class Name

`DiagnosticsSettingsApi`


# List Diagnostics Settings

This endpoint retrieves diagnostics settings synchronously.

```go
ListDiagnosticsSettings(
    ctx context.Context,
    accountName string,
    devices string) (
    models.ApiResponse[[]models.DiagnosticObservationSetting],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |
| `devices` | `string` | Query, Required | Devices list formatted as "id, kind" |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DiagnosticObservationSetting](../../doc/models/diagnostic-observation-setting.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

devices := "864508030026238,IMEI"

apiResponse, err := diagnosticsSettingsApi.ListDiagnosticsSettings(ctx, accountName, devices)
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
[
  {
    "accountName": "string",
    "device": {
      "id": "864508030026238",
      "kind": "IMEI"
    },
    "attributes": [
      {
        "name": "MANUFACTURER",
        "value": "string",
        "createdOn": "2019-09-07T23:08:03.532Z",
        "isObservable": true,
        "isObserving": true,
        "frequency": {
          "value": 5,
          "unit": "SECOND"
        }
      }
    ]
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

