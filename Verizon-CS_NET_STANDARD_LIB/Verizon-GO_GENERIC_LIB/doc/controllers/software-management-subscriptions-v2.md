# Software Management Subscriptions V2

```go
softwareManagementSubscriptionsV2Api := client.SoftwareManagementSubscriptionsV2Api()
```

## Class Name

`SoftwareManagementSubscriptionsV2Api`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```go
GetAccountSubscriptionStatus(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.FotaV2Subscription],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV2Subscription](../../doc/models/fota-v2-subscription.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

apiResponse, err := softwareManagementSubscriptionsV2Api.GetAccountSubscriptionStatus(ctx, account)
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
  "accountName": "00000000000-123345",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2020-09-17T21:11:32.170Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

