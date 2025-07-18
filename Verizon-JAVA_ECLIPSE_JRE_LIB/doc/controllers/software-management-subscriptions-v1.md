# Software Management Subscriptions V1

```java
SoftwareManagementSubscriptionsV1Api softwareManagementSubscriptionsV1Api = client.getSoftwareManagementSubscriptionsV1Api();
```

## Class Name

`SoftwareManagementSubscriptionsV1Api`

## Methods

* [Get Account Subscription Status](../../doc/controllers/software-management-subscriptions-v1.md#get-account-subscription-status)
* [Get Account License Status](../../doc/controllers/software-management-subscriptions-v1.md#get-account-license-status)


# Get Account Subscription Status

This subscriptions endpoint retrieves an account's current Software Management Service subscription status.

```java
CompletableFuture<ApiResponse<V1AccountSubscription>> getAccountSubscriptionStatusAsync(
    final String account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V1AccountSubscription`](../../doc/models/v1-account-subscription.md).

## Example Usage

```java
String account = "0402196254-00001";

softwareManagementSubscriptionsV1Api.getAccountSubscriptionStatusAsync(account).thenAccept(result -> {
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
  "accountName": "0402196254-00001",
  "purchaseType": "TS-HFOTA-EVNT,TS-HFOTA-MRC",
  "licenseCount": 9000,
  "licenseUsedCount": 1000,
  "updateTime": "2018-03-02T16:03:06.000Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Get Account License Status

Returns information about an account's Software Management Services licenses and a list of licensed devices.

```java
CompletableFuture<ApiResponse<AccountLicenseInfo>> getAccountLicenseStatusAsync(
    final String account,
    final String startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `String` | Template, Required | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`AccountLicenseInfo`](../../doc/models/account-license-info.md).

## Example Usage

```java
String account = "0402196254-00001";
String startIndex = "0";

softwareManagementSubscriptionsV1Api.getAccountLicenseStatusAsync(account, startIndex).thenAccept(result -> {
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
  "accountName": "0402196254-00001",
  "totalLicenses": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": 1000,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000473475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000347475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990007303425535",
      "assignmentTime": "2016-11-29T15:03:36.000Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

