# Sensor Insights Sensors

```java
SensorInsightsSensorsApi sensorInsightsSensorsApi = client.getSensorInsightsSensorsApi();
```

## Class Name

`SensorInsightsSensorsApi`

## Methods

* [Sensor Insights List Sensor Devices Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-list-sensor-devices-request)
* [Sensor Insights on Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-on-board-sensor-request)
* [Sensor Insights Sensor on Board Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-on-board-status-request)
* [Sensor Insights Off Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-off-board-sensor-request)
* [Sensor Insights Sensor Off Boarding Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-off-boarding-status-request)


# Sensor Insights List Sensor Devices Request

```java
CompletableFuture<ApiResponse<List<ResourceDevice>>> sensorInsightsListSensorDevicesRequestAsync(
    final DtoListSensorDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSensorDevicesRequest`](../../doc/models/dto-list-sensor-devices-request.md) | Body, Required | List details of the sensors |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<ResourceDevice>`](../../doc/models/resource-device.md).

## Example Usage

```java
DtoListSensorDevicesRequest body = new DtoListSensorDevicesRequest.Builder()
    .accountname("0000123456-00001")
    .filter(new DtoFilter.Builder()
        .mExpand("device detail(s)")
        .mLimitnumber(100)
        .mNopagination(true)
        .mPage("The number of pages")
        .mPagenumber(1)
        .mProjection(Arrays.asList(
            "specific device fields requested"
        ))
        .mSelection(new LinkedHashMap<String, Object>() {{
            put("additionalProp1", ApiHelper.deserialize("\"string\""));
            put("additionalProp2", ApiHelper.deserialize("\"string\""));
            put("additionalProp3", ApiHelper.deserialize("\"string\""));
        }})
        .build())
    .resourceidentifier(new DtoDeviceResourceIdentifier.Builder()
        .deveui("The unique EUI64 address of the device")
        .deviceid("The UUID of the device")
        .esn(223372036854775800)
        .iccid("The 20-digit Integrated Circuit Card ID (SIM card ID)")
        .imei(223372036854775)
        .imsi(223372036854775800)
        .mac("The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX")
        .manufacturer("REOLINK")
        .meid("The 56-bit Mobile Equipment ID")
        .msisdn("The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number")
        .nodeUuid("The UUID of the node the device is associated with")
        .qrcode("The Quick Response (QR) code")
        .serial("The device's serial number")
        .build())
    .build();

sensorInsightsSensorsApi.sensorInsightsListSensorDevicesRequestAsync(body).thenAccept(result -> {
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
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights on Board Sensor Request

```java
CompletableFuture<ApiResponse<Void>> sensorInsightsOnBoardSensorRequestAsync(
    final DtoOnBoardSensorRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOnBoardSensorRequest`](../../doc/models/dto-on-board-sensor-request.md) | Body, Required | Onboarding a sensor |

## Server

`Server.THINGSPACE`

## Response Type

`void`

## Example Usage

```java
DtoOnBoardSensorRequest body = new DtoOnBoardSensorRequest.Builder()
    .accountname("0000123456-00001")
    .payload(new Payload.Builder()
        .addsensor(new ResourceOnBoardSensor.Builder(
            "The unique EUI64 address of the device",
            "global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame",
            "Encryption key used for messages during every over the air activation",
            "A",
            "ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US",
            "used to identify water leaks",
            "Water Leak sensor"
        )
        .customdata(new LinkedHashMap<String, Object>() {{
                put("additionalProp1", ApiHelper.deserialize("[100]"));
                put("additionalProp2", ApiHelper.deserialize("[100]"));
                put("additionalProp3", ApiHelper.deserialize("[100]"));
            }})
        .build())
        .build())
    .build();

sensorInsightsSensorsApi.sensorInsightsOnBoardSensorRequestAsync(body).thenAccept(result -> {
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Sensor on Board Status Request

```java
CompletableFuture<ApiResponse<DtoSensorOnBoardingStatusResponse>> sensorInsightsSensorOnBoardStatusRequestAsync(
    final DtoSensorOnBoardStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOnBoardStatusRequest`](../../doc/models/dto-sensor-on-board-status-request.md) | Body, Required | Get the sensor's onboarding status |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DtoSensorOnBoardingStatusResponse`](../../doc/models/dto-sensor-on-boarding-status-response.md).

## Example Usage

```java
DtoSensorOnBoardStatusRequest body = new DtoSensorOnBoardStatusRequest.Builder()
    .accountname("0000123456-00001")
    .gatewayidentifier(new Gatewayidentifier.Builder()
        .deviceid("00000000-0000-0000-0000-000000000255")
        .build())
    .onboarding(new Onboarding.Builder()
    .additionalProperty("sensoridentifiers", ApiHelper.deserialize("{\"deveui\":\"The unique EUI64 address of the device\"}"))
        .build())
    .build();

sensorInsightsSensorsApi.sensorInsightsSensorOnBoardStatusRequestAsync(body).thenAccept(result -> {
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
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Off Board Sensor Request

```java
CompletableFuture<ApiResponse<Void>> sensorInsightsOffBoardSensorRequestAsync(
    final DtoOffBoardSensorRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOffBoardSensorRequest`](../../doc/models/dto-off-board-sensor-request.md) | Body, Required | Offboard a sensor |

## Server

`Server.THINGSPACE`

## Response Type

`void`

## Example Usage

```java
DtoOffBoardSensorRequest body = new DtoOffBoardSensorRequest.Builder()
    .accountname("0000123456-00001")
    .configuration(new Sensorinsightsconfig.Builder()
        .removesensor(new DtoOffBoardSensor.Builder()
            .deveui("The unique EUI64 address of the device")
            .build())
        .build())
    .build();

sensorInsightsSensorsApi.sensorInsightsOffBoardSensorRequestAsync(body).thenAccept(result -> {
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


# Sensor Insights Sensor Off Boarding Status Request

```java
CompletableFuture<ApiResponse<DtoSensorOffBoardingStatusResponse>> sensorInsightsSensorOffBoardingStatusRequestAsync(
    final DtoSensorOffBoardStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOffBoardStatusRequest`](../../doc/models/dto-sensor-off-board-status-request.md) | Body, Required | Get a sensor's offboarding status |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DtoSensorOffBoardingStatusResponse`](../../doc/models/dto-sensor-off-boarding-status-response.md).

## Example Usage

```java
DtoSensorOffBoardStatusRequest body = new DtoSensorOffBoardStatusRequest.Builder()
    .accountname("0000123456-00001")
    .gatewayidentifier(new Gatewayidentifier.Builder()
        .deviceid("UUID of the Gateway device")
        .build())
    .offboarding(new Offboarding.Builder()
    .additionalProperty("sensoridentifiers", ApiHelper.deserialize("{\"deveui\":\"The unique EUI64 address of the device\"}"))
        .build())
    .build();

sensorInsightsSensorsApi.sensorInsightsSensorOffBoardingStatusRequestAsync(body).thenAccept(result -> {
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
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

