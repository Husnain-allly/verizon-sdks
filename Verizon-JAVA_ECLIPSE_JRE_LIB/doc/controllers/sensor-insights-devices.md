# Sensor Insights Devices

```java
SensorInsightsDevicesApi sensorInsightsDevicesApi = client.getSensorInsightsDevicesApi();
```

## Class Name

`SensorInsightsDevicesApi`

## Methods

* [Sensor Insights List Devices Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-devices-request)
* [Sensor Insights Patch Device Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-patch-device-request)
* [Sensor Insights Last Reported Time Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-last-reported-time-request)
* [Sensor Insights Device Action Set Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-device-action-set-request)
* [Sensor Insights List Device Experience History Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-device-experience-history-request)
* [Sensor Insights List Network Experience History Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-network-experience-history-request)


# Sensor Insights List Devices Request

```java
CompletableFuture<ApiResponse<List<DtoExpandedDeviceResponse>>> sensorInsightsListDevicesRequestAsync(
    final DtoListDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | List all device details on an account |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DtoExpandedDeviceResponse>`](../../doc/models/dto-expanded-device-response.md).

## Example Usage

```java
DtoListDevicesRequest body = new DtoListDevicesRequest.Builder()
    .accountname("0000123456-00001")
    .filter(new DtoFilter.Builder()
        .mExpand("device detail(s)")
        .mLimitnumber(100)
        .mNopagination(true)
        .mPage("The number of pages")
        .mPagenumber(100)
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

sensorInsightsDevicesApi.sensorInsightsListDevicesRequestAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 404 | Not Found | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Patch Device Request

```java
CompletableFuture<ApiResponse<ResourceDevice>> sensorInsightsPatchDeviceRequestAsync(
    final DtoPatchDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchDeviceRequest`](../../doc/models/dto-patch-device-request.md) | Body, Required | Partially update a device's details |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ResourceDevice`](../../doc/models/resource-device.md).

## Example Usage

```java
DtoPatchDeviceRequest body = new DtoPatchDeviceRequest.Builder()
    .accountname("0000123456-00001")
    .device(new ResourceDevice.Builder(
        DateTimeHelper.fromRfc8601DateTime("2023-10-02T15:46:34.562Z"),
        "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        DateTimeHelper.fromRfc8601DateTime("2023-10-02T15:46:34.562Z"),
        "success",
        "337bd2e8-eeee-ffff-gggg-5207992fd395"
    )
    .accountclientid("null")
    .billingaccountid("0000123456-00001")
    .chipset("The chipset used by the device")
    .customdata(new LinkedHashMap<String, Object>() {{
            put("additionalProp1", ApiHelper.deserialize("[100]"));
            put("additionalProp2", ApiHelper.deserialize("[100]"));
            put("additionalProp3", ApiHelper.deserialize("[100]"));
        }})
    .description("The number of days to retaing the event data")
    .esn(223372036854775800)
    .fields(new DtoFields.Builder()
            .additionalProp1("string")
            .additionalProp2("string")
            .additionalProp3("string")
            .build())
    .hardwareversion("1.0")
    .iccid("The 20-digit Integrated Circuit Card ID (SIM card ID)")
    .id("33e21f61-a44a-44c9-b7a0-a63f5d19bd4f")
    .imei(223372036854775)
    .imsi(223372036854775800)
    .licenses(Arrays.asList(
            "licenses assigned to the device"
        ))
    .mac("The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX")
    .manufacturer("REOLINK")
    .meid("The 56-bit Mobile Equipment ID")
    .msisdn("The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number")
    .name("User defined name of the record")
    .parentdeviceid("BLE device ID")
    .productmodel("Model name of the device")
    .providerid("Verizon Wireless")
    .qrcode("The Quick Response (QR) code")
    .refid("P3730-1422323050860")
    .refidtype("The type of value represented by `refid`")
    .serial("The device's serial number")
    .services(Arrays.asList(
            "configuration"
        ))
    .sku("The Stock Keeping Unit (SKU) number")
    .softwareversion("the current device software version")
    .version("1.0")
    .eventretention(90)
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

sensorInsightsDevicesApi.sensorInsightsPatchDeviceRequestAsync(body).thenAccept(result -> {
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


# Sensor Insights Last Reported Time Request

```java
CompletableFuture<ApiResponse<DtoLastReportedTimeResponse>> sensorInsightsLastReportedTimeRequestAsync(
    final DtoLastReportedTimeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoLastReportedTimeRequest`](../../doc/models/dto-last-reported-time-request.md) | Body, Required | Get the last reported information for a device |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DtoLastReportedTimeResponse`](../../doc/models/dto-last-reported-time-response.md).

## Example Usage

```java
DtoLastReportedTimeRequest body = new DtoLastReportedTimeRequest.Builder()
    .accountname("0000123456-00001")
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

sensorInsightsDevicesApi.sensorInsightsLastReportedTimeRequestAsync(body).thenAccept(result -> {
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
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Device Action Set Request

```java
CompletableFuture<ApiResponse<DtoDeviceActionSetResponse>> sensorInsightsDeviceActionSetRequestAsync(
    final DmV1DevicesActionsSetRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DmV1DevicesActionsSetRequest`](../../doc/models/dm-v1-devices-actions-set-request.md) | Body, Required | Set device configuration |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DtoDeviceActionSetResponse`](../../doc/models/dto-device-action-set-response.md).

## Example Usage

```java
DmV1DevicesActionsSetRequest body = new DmV1DevicesActionsSetRequest.Builder()
    .accountname("0000123456-00001")
    .configuration(new DtoDeviceActionSetConfiguration1.Builder()
        .deviceConfig(new DtoDeviceConfig.Builder()
            .ble(new SensorInsightsBle.Builder()
                .dataMode(1)
                .manufacturerId(13200)
                .maxNumScan(100)
                .minSigStr(-115)
                .monitorPeriod(300)
                .moreManufId(Arrays.asList(
                    ApiHelper.deserialize("{}")
                ))
                .opMode(1)
                .reportOffset(0)
                .reportPeriod(300)
                .reportType(2)
                .scanDuration(20)
                .build())
            .build())
        .build())
    .resourceidentifier(new DtoDeviceResourceIdentifier1.Builder()
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

sensorInsightsDevicesApi.sensorInsightsDeviceActionSetRequestAsync(body).thenAccept(result -> {
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
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights List Device Experience History Request

```java
CompletableFuture<ApiResponse<List<UserDeviceExperienceHistory>>> sensorInsightsListDeviceExperienceHistoryRequestAsync(
    final DtoListDeviceExperienceHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDeviceExperienceHistoryRequest`](../../doc/models/dto-list-device-experience-history-request.md) | Body, Required | List the device experience |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<UserDeviceExperienceHistory>`](../../doc/models/user-device-experience-history.md).

## Example Usage

```java
DtoListDeviceExperienceHistoryRequest body = new DtoListDeviceExperienceHistoryRequest.Builder()
    .accountname("0000123456-00001")
    .filter(new DtoFilter.Builder()
        .mExpand("device detail(s)")
        .mLimitnumber(100)
        .mNopagination(true)
        .mPage("The number of pages")
        .mPagenumber(100)
        .mProjection(Arrays.asList(
            "specific device fields requested"
        ))
        .mSelection(new LinkedHashMap<String, Object>() {{
            put("additionalProp1", ApiHelper.deserialize("\"string\""));
            put("additionalProp2", ApiHelper.deserialize("\"string\""));
            put("additionalProp3", ApiHelper.deserialize("\"string\""));
        }})
        .build())
    .build();

sensorInsightsDevicesApi.sensorInsightsListDeviceExperienceHistoryRequestAsync(body).thenAccept(result -> {
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


# Sensor Insights List Network Experience History Request

```java
CompletableFuture<ApiResponse<List<UserNetworkExperienceHistory>>> sensorInsightsListNetworkExperienceHistoryRequestAsync(
    final DtoListNetworkExperienceHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNetworkExperienceHistoryRequest`](../../doc/models/dto-list-network-experience-history-request.md) | Body, Required | List the network experience |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<UserNetworkExperienceHistory>`](../../doc/models/user-network-experience-history.md).

## Example Usage

```java
DtoListNetworkExperienceHistoryRequest body = new DtoListNetworkExperienceHistoryRequest.Builder()
    .accountname("0000123456-00001")
    .filter(new DtoFilter.Builder()
        .mExpand("device detail(s)")
        .mLimitnumber(100)
        .mNopagination(true)
        .mPage("The number of pages")
        .mPagenumber(100)
        .mProjection(Arrays.asList(
            "specific device fields requested"
        ))
        .mSelection(new LinkedHashMap<String, Object>() {{
            put("additionalProp1", ApiHelper.deserialize("\"string\""));
            put("additionalProp2", ApiHelper.deserialize("\"string\""));
            put("additionalProp3", ApiHelper.deserialize("\"string\""));
        }})
        .build())
    .build();

sensorInsightsDevicesApi.sensorInsightsListNetworkExperienceHistoryRequestAsync(body).thenAccept(result -> {
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

