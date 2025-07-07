# Devices Location Subscriptions

```java
DevicesLocationSubscriptionsApi devicesLocationSubscriptionsApi = client.getDevicesLocationSubscriptionsApi();
```

## Class Name

`DevicesLocationSubscriptionsApi`

## Methods

* [Get Location Service Subscription Status](../../doc/controllers/devices-location-subscriptions.md#get-location-service-subscription-status)
* [Get Location Service Usage](../../doc/controllers/devices-location-subscriptions.md#get-location-service-usage)


# Get Location Service Subscription Status

This subscriptions endpoint retrieves an account's current location subscription status.

```java
CompletableFuture<ApiResponse<DeviceLocationSubscription>> getLocationServiceSubscriptionStatusAsync(
    final String accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier in "##########-#####". |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceLocationSubscription`](../../doc/models/device-location-subscription.md).

## Example Usage

```java
String accountName = "0000123456-00001";

devicesLocationSubscriptionsApi.getLocationServiceSubscriptionStatusAsync(accountName).thenAccept(result -> {
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
  "accountName": "2024009649-00001",
  "locType": "TS-LOC-COARSE-CellID-5K",
  "maxAllowance": "5000",
  "purchaseTime": "2017-05-10 06:25:25.171 +0000 UTC"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Get Location Service Usage

This endpoint allows user to search for billable usage for accounts based on the provided date range.

```java
CompletableFuture<ApiResponse<Object>> getLocationServiceUsageAsync(
    final BillUsageRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`BillUsageRequest`](../../doc/models/bill-usage-request.md) | Body, Required | Request to obtain billable usage for accounts. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type `Object`.

## Example Usage

```java
BillUsageRequest body = new BillUsageRequest.Builder(
    "1234567890-00001",
    "04-01-2018",
    "04-30-2018"
)
.usageForAllAccounts(true)
.build();

devicesLocationSubscriptionsApi.getLocationServiceUsageAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response

```
{
  "accountName": "1223334444-00001",
  "usageForAllAcounts": false,
  "skuName": "TS-LOC-COARSE-CellID-Aggr",
  "transactionsAllowed": "5000",
  "totalTransactionCount": "350",
  "PrimaryAccount": {
    "accountName": "1223334444-00001",
    "transactionsCount": "125"
  },
  "ManagedAccounts": []
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

