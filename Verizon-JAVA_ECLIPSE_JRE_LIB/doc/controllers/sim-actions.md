# SIM Actions

```java
SimActionsApi simActionsApi = client.getSimActionsApi();
```

## Class Name

`SimActionsApi`

## Methods

* [Newactivatecode](../../doc/controllers/sim-actions.md#newactivatecode)
* [Setactivate Using POST](../../doc/controllers/sim-actions.md#setactivate-using-post)
* [Setdeactivate Using POST](../../doc/controllers/sim-actions.md#setdeactivate-using-post)


# Newactivatecode

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

```java
CompletableFuture<ApiResponse<EsimRequestResponse>> newactivatecodeAsync(
    final EsimProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest2`](../../doc/models/esim-profile-request-2.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```java
EsimProfileRequest2 body = new EsimProfileRequest2.Builder()
    .devices(Arrays.asList(
        new EsimDeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId2.Builder()
                    .id("15-digit IMEI")
                    .kind("imei")
                    .build(),
                new DeviceId2.Builder()
                    .id("20-digit ICCID")
                    .kind("iccid")
                    .build()
            ))
            .build()
    ))
    .accountName("0000123456-00001")
    .servicePlan("the service plan name")
    .mdnZipCode("five digit zip code")
    .build();

simActionsApi.newactivatecodeAsync(body).thenAccept(result -> {
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setactivate Using POST

Uses the profile to activate the SIM.

```java
CompletableFuture<ApiResponse<EsimRequestResponse>> setactivateUsingPostAsync(
    final EsimProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest`](../../doc/models/esim-profile-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```java
EsimProfileRequest body = new EsimProfileRequest.Builder()
    .devices(Arrays.asList(
        new EsimDeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId2.Builder()
                    .id("32-digit EID")
                    .kind("eid")
                    .build(),
                new DeviceId2.Builder()
                    .id("15-digit IMEI")
                    .kind("imei")
                    .build(),
                new DeviceId2.Builder()
                    .id("20-digit ICCID")
                    .kind("iccid (ICCID is only used for reactivation)")
                    .build()
            ))
            .build()
    ))
    .carrierName("Verizon Wireless")
    .accountName("0000123456-00001")
    .servicePlan("the service plan name")
    .mdnZipCode("five digit zip code")
    .build();

simActionsApi.setactivateUsingPostAsync(body).thenAccept(result -> {
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setdeactivate Using POST

Uses the profile to deactivate the SIM.

```java
CompletableFuture<ApiResponse<EsimRequestResponse>> setdeactivateUsingPostAsync(
    final ProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```java
ProfileRequest2 body = new ProfileRequest2.Builder()
    .accountName("0000123456-00001")
    .carrierName("Verizon Wireless")
    .reasonCode("FF")
    .etfWaiver(true)
    .checkFallbackProfile(false)
    .build();

simActionsApi.setdeactivateUsingPostAsync(body).thenAccept(result -> {
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

