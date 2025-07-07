# Account Subscriptions

```go
accountSubscriptionsApi := client.AccountSubscriptionsApi()
```

## Class Name

`AccountSubscriptionsApi`


# List Account Subscriptions

Retrieves the total number of SIM-Secure for IoT subscription licenses purchased for your account by license type, and lists the number of licenses assigned and available for each license type.

```go
ListAccountSubscriptions(
    ctx context.Context,
    body models.SecuritySubscriptionRequest,
    xRequestId *string) (
    models.ApiResponse[models.SecuritySubscriptionResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SecuritySubscriptionRequest`](../../doc/models/security-subscription-request.md) | Body, Required | Request for account subscription. |
| `xRequestId` | `*string` | Header, Optional | Transaction Id.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]-[0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SecuritySubscriptionResult](../../doc/models/security-subscription-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.SecuritySubscriptionRequest{
    AccountName: models.ToPointer("000012345600001"),
    SkuNumber:   models.ToPointer("SIMSec-IoT-Lt"),
}



apiResponse, err := accountSubscriptionsApi.ListAccountSubscriptions(ctx, body, nil)
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
  "accountName": "000012345600001",
  "subscriptionList": [
    {
      "skuNumber": "TS-BUNDLE-KTO-SIMSEC-MRC",
      "licenseType": "Flexible Bundle",
      "licensePurchased": 9,
      "licenseAssigned": 7,
      "licenseAvailable": 1
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 401 | Unauthorized request. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 403 | Request forbidden. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 404 | Not Found / Does not exist. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 406 | Format / Request Unacceptable. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 429 | Too many requests. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| Default | Error response. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |

