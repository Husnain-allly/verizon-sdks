# Exclusions

Exclude devices from location services.

```java
ExclusionsApi exclusionsApi = client.getExclusionsApi();
```

## Class Name

`ExclusionsApi`

## Methods

* [Devices Location Get Consent Async](../../doc/controllers/exclusions.md#devices-location-get-consent-async)
* [Devices Location Give Consent Async](../../doc/controllers/exclusions.md#devices-location-give-consent-async)
* [Devices Location Update Consent](../../doc/controllers/exclusions.md#devices-location-update-consent)
* [Exclude Devices](../../doc/controllers/exclusions.md#exclude-devices)
* [Remove Devices From Exclusion List](../../doc/controllers/exclusions.md#remove-devices-from-exclusion-list)
* [List Excluded Devices](../../doc/controllers/exclusions.md#list-excluded-devices)


# Devices Location Get Consent Async

Get the consent settings for the entire account or device list in an account.

```java
CompletableFuture<ApiResponse<GetAccountDeviceConsent>> devicesLocationGetConsentAsyncAsync(
    final String accountName,
    final String deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Query, Required | The numeric name of the account. |
| `deviceId` | `String` | Query, Optional | The IMEI of the device being queried |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`GetAccountDeviceConsent`](../../doc/models/get-account-device-consent.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String deviceId = "900000000000009";

exclusionsApi.devicesLocationGetConsentAsyncAsync(accountName, deviceId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Devices Location Give Consent Async

Create a consent record to use location services as an asynchronous request.

```java
CompletableFuture<ApiResponse<ConsentTransactionId>> devicesLocationGiveConsentAsyncAsync(
    final AccountConsentCreate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AccountConsentCreate`](../../doc/models/account-consent-create.md) | Body, Optional | Account details to create a consent record. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ConsentTransactionId`](../../doc/models/consent-transaction-id.md).

## Example Usage

```java
AccountConsentCreate body = new AccountConsentCreate.Builder()
    .accountName("0000123456-00001")
    .build();

exclusionsApi.devicesLocationGiveConsentAsyncAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Devices Location Update Consent

Update the location services consent record for an entire account.

```java
CompletableFuture<ApiResponse<ConsentTransactionId>> devicesLocationUpdateConsentAsync(
    final AccountConsentUpdate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AccountConsentUpdate`](../../doc/models/account-consent-update.md) | Body, Optional | Account details to update a consent record. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ConsentTransactionId`](../../doc/models/consent-transaction-id.md).

## Example Usage

```java
AccountConsentUpdate body = new AccountConsentUpdate.Builder()
    .accountName("0000123456-00001")
    .allDeviceConsent(0)
    .build();

exclusionsApi.devicesLocationUpdateConsentAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Exclude Devices

This consents endpoint sets a new exclusion list.

```java
CompletableFuture<ApiResponse<DeviceLocationSuccessResult>> excludeDevicesAsync(
    final ConsentRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ConsentRequest`](../../doc/models/consent-request.md) | Body, Required | Request to update account consent exclusion list. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceLocationSuccessResult`](../../doc/models/device-location-success-result.md).

## Example Usage

```java
ConsentRequest body = new ConsentRequest.Builder(
    "1234567890-00001"
)
.allDevice(false)
.type("replace")
.exclusion(Arrays.asList(
        "980003420535573",
        "375535024300089",
        "A100003861E585"
    ))
.build();

exclusionsApi.excludeDevicesAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Remove Devices From Exclusion List

Removes devices from the exclusion list so that they can be located with Device Location Services requests.

```java
CompletableFuture<ApiResponse<DeviceLocationSuccessResult>> removeDevicesFromExclusionListAsync(
    final String accountName,
    final String deviceList)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Query, Required | The numeric name of the account. |
| `deviceList` | `String` | Query, Required | A list of the device IDs to remove from the exclusion list. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceLocationSuccessResult`](../../doc/models/device-location-success-result.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String deviceList = "IMEI";

exclusionsApi.removeDevicesFromExclusionListAsync(accountName, deviceList).thenAccept(result -> {
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Excluded Devices

This consents endpoint retrieves a list of excluded devices in an account.

```java
CompletableFuture<ApiResponse<DevicesConsentResult>> listExcludedDevicesAsync(
    final String accountName,
    final String startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `String` | Template, Required | Zero-based number of the first record to return. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DevicesConsentResult`](../../doc/models/devices-consent-result.md).

## Example Usage

```java
String accountName = "0252012345-00001";
String startIndex = "0";

exclusionsApi.listExcludedDevicesAsync(accountName, startIndex).thenAccept(result -> {
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
  "allDevice": false,
  "hasMoreData": false,
  "totalCount": 4,
  "updateTime": "2018-05-18 19:20:50.076 +0000 UTC",
  "exclusion": [
    "990003420535375",
    "420535399000375",
    "A100003861E585",
    "205353759900034"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

