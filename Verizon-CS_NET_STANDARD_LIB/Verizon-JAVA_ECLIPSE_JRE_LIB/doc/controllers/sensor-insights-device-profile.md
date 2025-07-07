# Sensor Insights Device Profile

```java
SensorInsightsDeviceProfileApi sensorInsightsDeviceProfileApi = client.getSensorInsightsDeviceProfileApi();
```

## Class Name

`SensorInsightsDeviceProfileApi`

## Methods

* [Create a Profile](../../doc/controllers/sensor-insights-device-profile.md#create-a-profile)
* [Delete a Profile](../../doc/controllers/sensor-insights-device-profile.md#delete-a-profile)
* [Update a Profile](../../doc/controllers/sensor-insights-device-profile.md#update-a-profile)
* [Query a Profile](../../doc/controllers/sensor-insights-device-profile.md#query-a-profile)


# Create a Profile

Create a device profile

```java
CompletableFuture<ApiResponse<List<DtoProfileResponse>>> createAProfileAsync(
    final DtoConfigurationProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfile`](../../doc/models/dto-configuration-profile.md) | Body, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DtoProfileResponse>`](../../doc/models/dto-profile-response.md).

## Example Usage

```java
DtoConfigurationProfile body = new DtoConfigurationProfile.Builder()
    .accountname("0000123456-00001")
    .profiles(Arrays.asList(
        new DtoProfile.Builder()
            .kind("the kind of profile being created")
            .version("1.0")
            .modelid("00000000-0000-0000-0000-000000000019")
            .name("Demo Entry sensor 1730928792")
            .configuration(ApiHelper.deserialize("{\"randomInt\":21,\"resportingInterval\":24}"))
            .build()
    ))
    .build();

sensorInsightsDeviceProfileApi.createAProfileAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Delete a Profile

Delete a device profile

```java
CompletableFuture<ApiResponse<List<DtoProfileResponse>>> deleteAProfileAsync(
    final DtoConfigurationProfileDelete deleterequest)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequest` | [`DtoConfigurationProfileDelete`](../../doc/models/dto-configuration-profile-delete.md) | Header, Required | payload for the delete request |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DtoProfileResponse>`](../../doc/models/dto-profile-response.md).

## Example Usage

```java
DtoConfigurationProfileDelete deleterequest = new DtoConfigurationProfileDelete.Builder()
    .accountName("0000123456-00001")
    .build();

sensorInsightsDeviceProfileApi.deleteAProfileAsync(deleterequest).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Update a Profile

Partially update a device profile

```java
CompletableFuture<ApiResponse<List<DtoProfileResponse>>> updateAProfileAsync(
    final DtoConfigurationProfilePath body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfilePath`](../../doc/models/dto-configuration-profile-path.md) | Body, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DtoProfileResponse>`](../../doc/models/dto-profile-response.md).

## Example Usage

```java
DtoConfigurationProfilePath body = new DtoConfigurationProfilePath.Builder()
.additionalProperty("accountname", ApiHelper.deserialize("\"0000123456-00001\""))
.additionalProperty("profiles", ApiHelper.deserialize("[{\"kind\":\"the kind of profile being created\",\"version\":\"1.0\",\"modelid\":\"00000000-0000-0000-0000-000000000019\",\"name\":\"Demo Entry sensor 1730928792\",\"configuration\":{\"randomInt\":21,\"resportingInterval\":24}}]"))
    .build();

sensorInsightsDeviceProfileApi.updateAProfileAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Query a Profile

Query a device profile for an individual device

```java
CompletableFuture<ApiResponse<List<DtoProfileResponse>>> queryAProfileAsync(
    final ResourceResourceQuery body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourceResourceQuery`](../../doc/models/resource-resource-query.md) | Body, Required | body |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DtoProfileResponse>`](../../doc/models/dto-profile-response.md).

## Example Usage

```java
ResourceResourceQuery body = new ResourceResourceQuery.Builder()
    .filter(new Devicepropertyfilter.Builder()
        .mSelection(new Devicepropertyselection.Builder()
            .modelid("00000000-0000-0000-0000-000000000019")
            .build())
        .mQuerytotalcount(true)
        .build())
    .build();

sensorInsightsDeviceProfileApi.queryAProfileAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

