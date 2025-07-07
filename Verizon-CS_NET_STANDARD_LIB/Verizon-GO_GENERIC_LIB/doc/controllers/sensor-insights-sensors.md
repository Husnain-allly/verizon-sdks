# Sensor Insights Sensors

```go
sensorInsightsSensorsApi := client.SensorInsightsSensorsApi()
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

```go
SensorInsightsListSensorDevicesRequest(
    ctx context.Context,
    body models.DtoListSensorDevicesRequest) (
    models.ApiResponse[[]models.ResourceDevice],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListSensorDevicesRequest`](../../doc/models/dto-list-sensor-devices-request.md) | Body, Required | List details of the sensors |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.ResourceDevice](../../doc/models/resource-device.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListSensorDevicesRequest{
    Accountname:        models.ToPointer("0000123456-00001"),
    Filter:             models.ToPointer(models.DtoFilter{
        MExpand:       models.ToPointer("device detail(s)"),
        MLimitnumber:  models.ToPointer(100),
        MNopagination: models.ToPointer(true),
        MPage:         models.ToPointer("The number of pages"),
        MPagenumber:   models.ToPointer(1),
        MProjection:   []string{
            "specific device fields requested",
        },
        MSelection:    map[string]interface{}{
            "additionalProp1": interface{}("string"),
            "additionalProp2": interface{}("string"),
            "additionalProp3": interface{}("string"),
        },
    }),
    Resourceidentifier: models.ToPointer(models.DtoDeviceResourceIdentifier{
        Deveui:       models.ToPointer("The unique EUI64 address of the device"),
        Deviceid:     models.ToPointer("The UUID of the device"),
        Esn:          models.ToPointer(223372036854775800),
        Iccid:        models.ToPointer("The 20-digit Integrated Circuit Card ID (SIM card ID)"),
        Imei:         models.ToPointer(223372036854775),
        Imsi:         models.ToPointer(223372036854775800),
        Mac:          models.ToPointer("The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX"),
        Manufacturer: models.ToPointer("REOLINK"),
        Meid:         models.ToPointer("The 56-bit Mobile Equipment ID"),
        Msisdn:       models.ToPointer("The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number"),
        NodeUuid:     models.ToPointer("The UUID of the node the device is associated with"),
        Qrcode:       models.ToPointer("The Quick Response (QR) code"),
        Serial:       models.ToPointer("The device's serial number"),
    }),
}

apiResponse, err := sensorInsightsSensorsApi.SensorInsightsListSensorDevicesRequest(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

```go
SensorInsightsOnBoardSensorRequest(
    ctx context.Context,
    body models.DtoOnBoardSensorRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoOnBoardSensorRequest`](../../doc/models/dto-on-board-sensor-request.md) | Body, Required | Onboarding a sensor |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

body := models.DtoOnBoardSensorRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Payload:     models.ToPointer(models.Payload{
        Addsensor:             models.ToPointer(models.ResourceOnBoardSensor{
            Deveui:      "The unique EUI64 address of the device",
            Appeui:      "global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame",
            Appkey:      "Encryption key used for messages during every over the air activation",
            Class:       "A",
            Kind:        "ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US",
            Description: "used to identify water leaks",
            Name:        "Water Leak sensor",
            Customdata:  map[string]interface{}{
                "additionalProp1": interface{}("100"),
                "additionalProp2": interface{}("100"),
                "additionalProp3": interface{}("100"),
            },
        }),
    }),
}

resp, err := sensorInsightsSensorsApi.SensorInsightsOnBoardSensorRequest(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
}
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

```go
SensorInsightsSensorOnBoardStatusRequest(
    ctx context.Context,
    body models.DtoSensorOnBoardStatusRequest) (
    models.ApiResponse[models.DtoSensorOnBoardingStatusResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoSensorOnBoardStatusRequest`](../../doc/models/dto-sensor-on-board-status-request.md) | Body, Required | Get the sensor's onboarding status |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoSensorOnBoardingStatusResponse](../../doc/models/dto-sensor-on-boarding-status-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoSensorOnBoardStatusRequest{
    Accountname:       models.ToPointer("0000123456-00001"),
    Gatewayidentifier: models.ToPointer(models.Gatewayidentifier{
        Deviceid:              models.ToPointer("00000000-0000-0000-0000-000000000255"),
    }),
    Onboarding:        models.ToPointer(models.Onboarding{
        AdditionalProperties:  map[string]interface{}{
            "sensoridentifiers": interface{}("[deveui, The unique EUI64 address of the device]"),
        },
    }),
}

apiResponse, err := sensorInsightsSensorsApi.SensorInsightsSensorOnBoardStatusRequest(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

```go
SensorInsightsOffBoardSensorRequest(
    ctx context.Context,
    body models.DtoOffBoardSensorRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoOffBoardSensorRequest`](../../doc/models/dto-off-board-sensor-request.md) | Body, Required | Offboard a sensor |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

body := models.DtoOffBoardSensorRequest{
    Accountname:   models.ToPointer("0000123456-00001"),
    Configuration: models.ToPointer(models.Sensorinsightsconfig{
        Removesensor:          models.ToPointer(models.DtoOffBoardSensor{
            Deveui: models.ToPointer("The unique EUI64 address of the device"),
        }),
    }),
}

resp, err := sensorInsightsSensorsApi.SensorInsightsOffBoardSensorRequest(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |


# Sensor Insights Sensor Off Boarding Status Request

```go
SensorInsightsSensorOffBoardingStatusRequest(
    ctx context.Context,
    body models.DtoSensorOffBoardStatusRequest) (
    models.ApiResponse[models.DtoSensorOffBoardingStatusResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoSensorOffBoardStatusRequest`](../../doc/models/dto-sensor-off-board-status-request.md) | Body, Required | Get a sensor's offboarding status |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoSensorOffBoardingStatusResponse](../../doc/models/dto-sensor-off-boarding-status-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoSensorOffBoardStatusRequest{
    Accountname:       models.ToPointer("0000123456-00001"),
    Gatewayidentifier: models.ToPointer(models.Gatewayidentifier{
        Deviceid:              models.ToPointer("UUID of the Gateway device"),
    }),
    Offboarding:       models.ToPointer(models.Offboarding{
        AdditionalProperties:  map[string]interface{}{
            "sensoridentifiers": interface{}("[deveui, The unique EUI64 address of the device]"),
        },
    }),
}

apiResponse, err := sensorInsightsSensorsApi.SensorInsightsSensorOffBoardingStatusRequest(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

