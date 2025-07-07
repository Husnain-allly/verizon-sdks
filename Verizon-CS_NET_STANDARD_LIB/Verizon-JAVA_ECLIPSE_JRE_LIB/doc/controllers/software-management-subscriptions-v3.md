# Software Management Subscriptions V3

```java
SoftwareManagementSubscriptionsV3Api softwareManagementSubscriptionsV3Api = client.getSoftwareManagementSubscriptionsV3Api();
```

## Class Name

`SoftwareManagementSubscriptionsV3Api`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```java
CompletableFuture<ApiResponse<FotaV3Subscription>> getAccountSubscriptionStatusAsync(
    final String acc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV3Subscription`](../../doc/models/fota-v3-subscription.md).

## Example Usage

```java
String acc = "0000123456-00001";

softwareManagementSubscriptionsV3Api.getAccountSubscriptionStatusAsync(acc).thenAccept(result -> {
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

