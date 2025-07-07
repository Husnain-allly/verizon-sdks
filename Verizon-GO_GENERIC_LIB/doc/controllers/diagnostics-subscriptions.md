# Diagnostics Subscriptions

```go
diagnosticsSubscriptionsApi := client.DiagnosticsSubscriptionsApi()
```

## Class Name

`DiagnosticsSubscriptionsApi`


# Get Diagnostics Subscription

This endpoint retrieves a diagnostics subscription by account.

```go
GetDiagnosticsSubscription(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.DiagnosticsSubscription],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DiagnosticsSubscription](../../doc/models/diagnostics-subscription.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

apiResponse, err := diagnosticsSubscriptionsApi.GetDiagnosticsSubscription(ctx, accountName)
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
  "accountName": "TestQAAccount",
  "skuName": "TS-BUNDLE-KTO-DIAGNOSTIC-MRC",
  "totalAllowed": 100,
  "totalUsed": 50,
  "createdOn": "2019-08-29T00:47:59.240Z",
  "lastUpdated": "2019-08-29T00:47:59.240Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

