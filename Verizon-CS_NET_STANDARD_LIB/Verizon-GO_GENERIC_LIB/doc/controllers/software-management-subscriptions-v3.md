# Software Management Subscriptions V3

```go
softwareManagementSubscriptionsV3Api := client.SoftwareManagementSubscriptionsV3Api()
```

## Class Name

`SoftwareManagementSubscriptionsV3Api`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```go
GetAccountSubscriptionStatus(
    ctx context.Context,
    acc string) (
    models.ApiResponse[models.FotaV3Subscription],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV3Subscription](../../doc/models/fota-v3-subscription.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

apiResponse, err := softwareManagementSubscriptionsV3Api.GetAccountSubscriptionStatus(ctx, acc)
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
  "accountName": "0000123456-000001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 500,
  "licenseUsedCount": 400,
  "updateTime": "2020-09-17T21:11:32.170Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

