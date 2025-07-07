# E UICC Device Profile Management

```java
EuiccDeviceProfileManagementApi euiccDeviceProfileManagementApi = client.getEuiccDeviceProfileManagementApi();
```

## Class Name

`EuiccDeviceProfileManagementApi`

## Methods

* [Download Local Profile to Enable](../../doc/controllers/e-uicc-device-profile-management.md#download-local-profile-to-enable)
* [Download Local Profile to Disable](../../doc/controllers/e-uicc-device-profile-management.md#download-local-profile-to-disable)
* [Enable Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#enable-local-profile)
* [Disable Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#disable-local-profile)
* [Delete Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#delete-local-profile)


# Download Local Profile to Enable

Downloads an eUICC local profile to devices and enables the profile.

```java
CompletableFuture<ApiResponse<DeviceManagementResult>> downloadLocalProfileToEnableAsync(
    final ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceManagementResult`](../../doc/models/device-management-result.md).

## Example Usage

```java
ProfileChangeStateRequest body = new ProfileChangeStateRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId.Builder(
                    "678912789123453456784008666456",
                    "eid"
                )
                .build(),
                new DeviceId.Builder(
                    "78425989148000000840",
                    "iccid"
                )
                .build()
            ))
            .build()
    ),
    "1223334444-00001",
    "1.3.6.1.4.1.31746.1.500.200.101.5"
)
.build();

euiccDeviceProfileManagementApi.downloadLocalProfileToEnableAsync(body).thenAccept(result -> {
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Download Local Profile to Disable

Downloads an eUICC local profile to devices and leaves the profile disabled.

```java
CompletableFuture<ApiResponse<DeviceManagementResult>> downloadLocalProfileToDisableAsync(
    final ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceManagementResult`](../../doc/models/device-management-result.md).

## Example Usage

```java
ProfileChangeStateRequest body = new ProfileChangeStateRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId.Builder(
                    "678912789123453456784008666456",
                    "eid"
                )
                .build(),
                new DeviceId.Builder(
                    "78425989148000000840",
                    "iccid"
                )
                .build()
            ))
            .build()
    ),
    "1223334444-00001",
    "1.3.6.1.4.1.31746.1.500.200.101.5"
)
.build();

euiccDeviceProfileManagementApi.downloadLocalProfileToDisableAsync(body).thenAccept(result -> {
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Enable Local Profile

Enable a local profile that has been downloaded to eUICC devices.

```java
CompletableFuture<ApiResponse<RequestResponse>> enableLocalProfileAsync(
    final ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
ProfileChangeStateRequest body = new ProfileChangeStateRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId.Builder(
                    "678912789123453456784008666456",
                    "eid"
                )
                .build(),
                new DeviceId.Builder(
                    "78425989148000000840",
                    "iccid"
                )
                .build()
            ))
            .build()
    ),
    "1223334444-00001",
    "1.3.6.1.4.1.31746.1.500.200.101.5"
)
.build();

euiccDeviceProfileManagementApi.enableLocalProfileAsync(body).thenAccept(result -> {
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Disable Local Profile

Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.

```java
CompletableFuture<ApiResponse<RequestResponse>> disableLocalProfileAsync(
    final ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
ProfileChangeStateRequest body = new ProfileChangeStateRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId.Builder(
                    "678912789123453456784008666456",
                    "eid"
                )
                .build(),
                new DeviceId.Builder(
                    "78425989148000000840",
                    "iccid"
                )
                .build()
            ))
            .build()
    ),
    "1223334444-00001",
    "1.3.6.1.4.1.31746.1.500.200.101.5"
)
.build();

euiccDeviceProfileManagementApi.disableLocalProfileAsync(body).thenAccept(result -> {
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Delete Local Profile

Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.

```java
CompletableFuture<ApiResponse<RequestResponse>> deleteLocalProfileAsync(
    final ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```java
ProfileChangeStateRequest body = new ProfileChangeStateRequest.Builder(
    Arrays.asList(
        new DeviceList.Builder()
            .deviceIds(Arrays.asList(
                new DeviceId.Builder(
                    "678912789123453456784008666456",
                    "eid"
                )
                .build(),
                new DeviceId.Builder(
                    "78425989148000000840",
                    "iccid"
                )
                .build()
            ))
            .build()
    ),
    "1223334444-00001",
    "1.3.6.1.4.1.31746.1.500.200.101.5"
)
.build();

euiccDeviceProfileManagementApi.deleteLocalProfileAsync(body).thenAccept(result -> {
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

