# Diagnostics History

```go
diagnosticsHistoryApi := client.DiagnosticsHistoryApi()
```

## Class Name

`DiagnosticsHistoryApi`


# Get Diagnostics History

This endpoint allows the user to get the history data.

```go
GetDiagnosticsHistory(
    ctx context.Context,
    body models.HistorySearchRequest) (
    models.ApiResponse[[]models.History],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.HistorySearchRequest`](../../doc/models/history-search-request.md) | Body, Required | History data information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.History](../../doc/models/history.md).

## Example Usage

```go
ctx := context.Background()

body := models.HistorySearchRequest{
    MFilter:               models.HistorySearchFilter{
        AccountName:           "0000123456-00001",
        Device:                models.Device{
            Id:                    "15-digit IMEI",
            Kind:                  "IMEI",
        },
        Attributes:            models.ToPointer(models.HistorySearchFilterAttributes{
            Name:                  models.ToPointer(models.AttributeIdentifier_LinkQuality),
        }),
    },
}

apiResponse, err := diagnosticsHistoryApi.GetDiagnosticsHistory(ctx, body)
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
    "accountName": "0000123456-00001",
    "attributes": {
      "createdOn": "2022-02-10T16:02:21.406Z",
      "name": "LINK_QUALITY",
      "value": "47"
    },
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI"
    }
  },
  {
    "accountName": "0000123456-00001",
    "attributes": {
      "createdOn": "2022-02-10T16:02:05.316Z",
      "name": "LINK_QUALITY",
      "value": "47"
    },
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

