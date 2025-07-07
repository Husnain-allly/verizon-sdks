# Software Management Subscriptions V2

```java
SoftwareManagementSubscriptionsV2Api softwareManagementSubscriptionsV2Api = client.getSoftwareManagementSubscriptionsV2Api();
```

## Class Name

`SoftwareManagementSubscriptionsV2Api`


# Get Account Subscription Status

This endpoint retrieves a FOTA subscription by account.

```java
CompletableFuture<ApiResponse<FotaV2Subscription>> getAccountSubscriptionStatusAsync(
    final String account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV2Subscription`](../../doc/models/fota-v2-subscription.md).

## Example Usage

```java
String account = "0000123456-00001";

softwareManagementSubscriptionsV2Api.getAccountSubscriptionStatusAsync(account).thenAccept(result -> {
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

