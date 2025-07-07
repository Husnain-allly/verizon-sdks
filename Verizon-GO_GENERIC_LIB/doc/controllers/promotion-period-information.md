# Promotion Period Information

```go
promotionPeriodInformationApi := client.PromotionPeriodInformationApi()
```

## Class Name

`PromotionPeriodInformationApi`

## Methods

* [Get Promo Device Usage History](../../doc/controllers/promotion-period-information.md#get-promo-device-usage-history)
* [Get Promo Device Aggregate Usage History](../../doc/controllers/promotion-period-information.md#get-promo-device-aggregate-usage-history)


# Get Promo Device Usage History

Retrieves the usage history of a device during the promotion period.

```go
GetPromoDeviceUsageHistory(
    ctx context.Context,
    body models.ARequestBodyForUsage) (
    models.ApiResponse[models.ResponseToUsageQuery],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ARequestBodyForUsage`](../../doc/models/a-request-body-for-usage.md) | Body, Required | Retrieve Aggregate Usage |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ResponseToUsageQuery](../../doc/models/response-to-usage-query.md).

## Example Usage

```go
ctx := context.Background()

body := models.ARequestBodyForUsage{
    StartTime:             models.ToPointer(parseTime(time.RFC3339, "08/15/2021 00:00:00", func(err error) { log.Fatalln(err) })),
    EndTime:               models.ToPointer(parseTime(time.RFC3339, "08/16/2021 00:00:00", func(err error) { log.Fatalln(err) })),
}

apiResponse, err := promotionPeriodInformationApi.GetPromoDeviceUsageHistory(ctx, body)
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
  "hasmoredata": false,
  "deviceId": {
    "kind": "iccid",
    "id": "20-digit iccid"
  },
  "usageHistory": [
    {
      "bytesUsed": 3072,
      "serviceplan": "The serviceplan name",
      "smsUsed": 0,
      "moSMS": 0,
      "mtSMS": 0,
      "source": "Raw Usage",
      "eventDateTime": "2021-08-15T00:00:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | All error responses will be in this format | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get Promo Device Aggregate Usage History

Retrieves the aggregate usage for an account using pseudo-MDN during the promotional period using a callback.

```go
GetPromoDeviceAggregateUsageHistory(
    ctx context.Context,
    body models.RequestBodyForUsage) (
    models.ApiResponse[models.UsageRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.RequestBodyForUsage`](../../doc/models/request-body-for-usage.md) | Body, Required | Retrieve Aggregate Usage |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UsageRequestResponse](../../doc/models/usage-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.RequestBodyForUsage{
    AccountId:             models.ToPointer("0000123456-000001"),
    StartTime:             models.ToPointer(parseTime(time.RFC3339, "08/15/2021 00:00:00", func(err error) { log.Fatalln(err) })),
    EndTime:               models.ToPointer(parseTime(time.RFC3339, "08/16/2021 00:00:00", func(err error) { log.Fatalln(err) })),
}

apiResponse, err := promotionPeriodInformationApi.GetPromoDeviceAggregateUsageHistory(ctx, body)
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
  "requestId": "be1b5958-3e11-41db-9abd-b1b7618c0035"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

