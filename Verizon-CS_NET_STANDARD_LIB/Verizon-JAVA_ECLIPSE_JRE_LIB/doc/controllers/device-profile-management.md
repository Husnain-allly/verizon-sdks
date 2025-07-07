# Device Profile Management

```java
DeviceProfileManagementApi deviceProfileManagementApi = client.getDeviceProfileManagementApi();
```

## Class Name

`DeviceProfileManagementApi`

## Methods

* [Activate Device Through Profile](../../doc/controllers/device-profile-management.md#activate-device-through-profile)
* [Profile to Activate Device](../../doc/controllers/device-profile-management.md#profile-to-activate-device)
* [Profile to Deactivate Device](../../doc/controllers/device-profile-management.md#profile-to-deactivate-device)
* [Profile to Set Fallback Attribute](../../doc/controllers/device-profile-management.md#profile-to-set-fallback-attribute)


# Activate Device Through Profile

Uses the profile to bring the device under management.

```java
CompletableFuture<ApiResponse<RequestResponse>> activateDeviceThroughProfileAsync(
    final ActivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ActivateDeviceProfileRequest`](../../doc/models/activate-device-profile-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
ActivateDeviceProfileRequest body = new ActivateDeviceProfileRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId.Builder(
                    "32-digit EID",
                    "eid"
                )
                .build(),
                new DeviceId.Builder(
                    "15-digit IMEI",
                    "imei"
                )
                .build()
            ))
            .build()
    ),
    "0000123456-00001"
)
.servicePlan("The service plan name")
.mdnZipCode("five digit zip code")
.build();

deviceProfileManagementApi.activateDeviceThroughProfileAsync(body).thenAccept(result -> {
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Activate Device

Uses the profile to activate the device.

```java
CompletableFuture<ApiResponse<RequestResponse>> profileToActivateDeviceAsync(
    final ProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest`](../../doc/models/profile-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
ProfileRequest body = new ProfileRequest.Builder(
    "0000123456-00001",
    Arrays.asList(
        new DeviceList.Builder()
            .build()
    )
)
.carrierName("the name of the mobile service provider")
.servicePlan("The service plan name")
.mdnZipCode("five digit zip code")
.build();

deviceProfileManagementApi.profileToActivateDeviceAsync(body).thenAccept(result -> {
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Deactivate Device

Uses the profile to deactivate the device.

```java
CompletableFuture<ApiResponse<RequestResponse>> profileToDeactivateDeviceAsync(
    final DeactivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeactivateDeviceProfileRequest`](../../doc/models/deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
DeactivateDeviceProfileRequest body = new DeactivateDeviceProfileRequest.Builder(
    "0000123456-00001",
    "a short code for the reason action was taken"
)
.carrierName("the name of the mobile service provider")
.etfWaiver(true)
.checkFallbackProfile(false)
.build();

deviceProfileManagementApi.profileToDeactivateDeviceAsync(body).thenAccept(result -> {
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Set Fallback Attribute

Allows the profile to set the fallback attribute to the device.

```java
CompletableFuture<ApiResponse<RequestResponse>> profileToSetFallbackAttributeAsync(
    final SetFallbackAttributeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SetFallbackAttributeRequest`](../../doc/models/set-fallback-attribute-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
SetFallbackAttributeRequest body = new SetFallbackAttributeRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .build()
    ),
    "0000123456-00001"
)
.carrierName("the name of the mobile service provider")
.build();

deviceProfileManagementApi.profileToSetFallbackAttributeAsync(body).thenAccept(result -> {
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

