# Sensor Insights Devices

```go
sensorInsightsDevicesApi := client.SensorInsightsDevicesApi()
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

```go
SensorInsightsListDevicesRequest(
    ctx context.Context,
    body models.DtoListDevicesRequest) (
    models.ApiResponse[[]models.DtoExpandedDeviceResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | List all device details on an account |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DtoExpandedDeviceResponse](../../doc/models/dto-expanded-device-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListDevicesRequest{
    Accountname:        models.ToPointer("0000123456-00001"),
    Filter:             models.ToPointer(models.DtoFilter{
        MExpand:       models.ToPointer("device detail(s)"),
        MLimitnumber:  models.ToPointer(100),
        MNopagination: models.ToPointer(true),
        MPage:         models.ToPointer("The number of pages"),
        MPagenumber:   models.ToPointer(100),
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

apiResponse, err := sensorInsightsDevicesApi.SensorInsightsListDevicesRequest(ctx, body)
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

```go
SensorInsightsPatchDeviceRequest(
    ctx context.Context,
    body models.DtoPatchDeviceRequest) (
    models.ApiResponse[models.ResourceDevice],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoPatchDeviceRequest`](../../doc/models/dto-patch-device-request.md) | Body, Required | Partially update a device's details |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ResourceDevice](../../doc/models/resource-device.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoPatchDeviceRequest{
    Accountname:        models.ToPointer("0000123456-00001"),
    Device:             models.ToPointer(models.ResourceDevice{
        Accountclientid:  models.ToPointer("null"),
        Billingaccountid: models.ToPointer("0000123456-00001"),
        Chipset:          models.ToPointer("The chipset used by the device"),
        Createdon:        parseTime(time.RFC3339, "2023-10-02T15:46:34.562Z", func(err error) { log.Fatalln(err) }),
        Customdata:       map[string]interface{}{
            "additionalProp1": interface{}("100"),
            "additionalProp2": interface{}("100"),
            "additionalProp3": interface{}("100"),
        },
        Description:      models.ToPointer("The number of days to retaing the event data"),
        Esn:              models.ToPointer(223372036854775800),
        Fields:           models.ToPointer(models.DtoFields{
            AdditionalProp1: models.ToPointer("string"),
            AdditionalProp2: models.ToPointer("string"),
            AdditionalProp3: models.ToPointer("string"),
        }),
        Foreignid:        "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        Hardwareversion:  models.ToPointer("1.0"),
        Iccid:            models.ToPointer("The 20-digit Integrated Circuit Card ID (SIM card ID)"),
        Id:               models.ToPointer("33e21f61-a44a-44c9-b7a0-a63f5d19bd4f"),
        Imei:             models.ToPointer(223372036854775),
        Imsi:             models.ToPointer(223372036854775800),
        Lastupdated:      parseTime(time.RFC3339, "2023-10-02T15:46:34.562Z", func(err error) { log.Fatalln(err) }),
        Licenses:         []string{
            "licenses assigned to the device",
        },
        Mac:              models.ToPointer("The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX"),
        Manufacturer:     models.ToPointer("REOLINK"),
        Meid:             models.ToPointer("The 56-bit Mobile Equipment ID"),
        Msisdn:           models.ToPointer("The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number"),
        Name:             models.ToPointer("User defined name of the record"),
        Parentdeviceid:   models.ToPointer("BLE device ID"),
        Productmodel:     models.ToPointer("Model name of the device"),
        Providerid:       models.ToPointer("Verizon Wireless"),
        Qrcode:           models.ToPointer("The Quick Response (QR) code"),
        Refid:            models.ToPointer("P3730-1422323050860"),
        Refidtype:        models.ToPointer("The type of value represented by `refid`"),
        Serial:           models.ToPointer("The device's serial number"),
        Services:         []string{
            "configuration",
        },
        Sku:              models.ToPointer("The Stock Keeping Unit (SKU) number"),
        Softwareversion:  models.ToPointer("the current device software version"),
        State:            "success",
        Version:          models.ToPointer("1.0"),
        Versionid:        "337bd2e8-eeee-ffff-gggg-5207992fd395",
        Eventretention:   models.ToPointer(90),
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

apiResponse, err := sensorInsightsDevicesApi.SensorInsightsPatchDeviceRequest(ctx, body)
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


# Sensor Insights Last Reported Time Request

```go
SensorInsightsLastReportedTimeRequest(
    ctx context.Context,
    body models.DtoLastReportedTimeRequest) (
    models.ApiResponse[models.DtoLastReportedTimeResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoLastReportedTimeRequest`](../../doc/models/dto-last-reported-time-request.md) | Body, Required | Get the last reported information for a device |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoLastReportedTimeResponse](../../doc/models/dto-last-reported-time-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoLastReportedTimeRequest{
    Accountname:           models.ToPointer("0000123456-00001"),
    Resourceidentifier:    models.ToPointer(models.DtoDeviceResourceIdentifier{
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

apiResponse, err := sensorInsightsDevicesApi.SensorInsightsLastReportedTimeRequest(ctx, body)
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
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Device Action Set Request

```go
SensorInsightsDeviceActionSetRequest(
    ctx context.Context,
    body models.DmV1DevicesActionsSetRequest) (
    models.ApiResponse[models.DtoDeviceActionSetResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DmV1DevicesActionsSetRequest`](../../doc/models/dm-v1-devices-actions-set-request.md) | Body, Required | Set device configuration |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoDeviceActionSetResponse](../../doc/models/dto-device-action-set-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DmV1DevicesActionsSetRequest{
    Accountname:           models.ToPointer("0000123456-00001"),
    Configuration:         models.ToPointer(models.DtoDeviceActionSetConfiguration1{
        DeviceConfig:               models.ToPointer(models.DtoDeviceConfig{
            Ble: models.ToPointer(models.SensorInsightsBle{
                DataMode:              models.ToPointer(1),
                ManufacturerId:        models.ToPointer(13200),
                MaxNumScan:            models.ToPointer(100),
                MinSigStr:             models.ToPointer(-115),
                MonitorPeriod:         models.ToPointer(300),
                MoreManufId:           []interface{}{
                    interface{}(""),
                },
                OpMode:                models.ToPointer(1),
                ReportOffset:          models.ToPointer(0),
                ReportPeriod:          models.ToPointer(300),
                ReportType:            models.ToPointer(2),
                ScanDuration:          models.ToPointer(20),
            }),
        }),
    }),
    Resourceidentifier:    models.ToPointer(models.DtoDeviceResourceIdentifier1{
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

apiResponse, err := sensorInsightsDevicesApi.SensorInsightsDeviceActionSetRequest(ctx, body)
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
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights List Device Experience History Request

```go
SensorInsightsListDeviceExperienceHistoryRequest(
    ctx context.Context,
    body models.DtoListDeviceExperienceHistoryRequest) (
    models.ApiResponse[[]models.UserDeviceExperienceHistory],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListDeviceExperienceHistoryRequest`](../../doc/models/dto-list-device-experience-history-request.md) | Body, Required | List the device experience |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.UserDeviceExperienceHistory](../../doc/models/user-device-experience-history.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListDeviceExperienceHistoryRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Filter:      models.ToPointer(models.DtoFilter{
        MExpand:       models.ToPointer("device detail(s)"),
        MLimitnumber:  models.ToPointer(100),
        MNopagination: models.ToPointer(true),
        MPage:         models.ToPointer("The number of pages"),
        MPagenumber:   models.ToPointer(100),
        MProjection:   []string{
            "specific device fields requested",
        },
        MSelection:    map[string]interface{}{
            "additionalProp1": interface{}("string"),
            "additionalProp2": interface{}("string"),
            "additionalProp3": interface{}("string"),
        },
    }),
}

apiResponse, err := sensorInsightsDevicesApi.SensorInsightsListDeviceExperienceHistoryRequest(ctx, body)
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


# Sensor Insights List Network Experience History Request

```go
SensorInsightsListNetworkExperienceHistoryRequest(
    ctx context.Context,
    body models.DtoListNetworkExperienceHistoryRequest) (
    models.ApiResponse[[]models.UserNetworkExperienceHistory],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListNetworkExperienceHistoryRequest`](../../doc/models/dto-list-network-experience-history-request.md) | Body, Required | List the network experience |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.UserNetworkExperienceHistory](../../doc/models/user-network-experience-history.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListNetworkExperienceHistoryRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Filter:      models.ToPointer(models.DtoFilter{
        MExpand:       models.ToPointer("device detail(s)"),
        MLimitnumber:  models.ToPointer(100),
        MNopagination: models.ToPointer(true),
        MPage:         models.ToPointer("The number of pages"),
        MPagenumber:   models.ToPointer(100),
        MProjection:   []string{
            "specific device fields requested",
        },
        MSelection:    map[string]interface{}{
            "additionalProp1": interface{}("string"),
            "additionalProp2": interface{}("string"),
            "additionalProp3": interface{}("string"),
        },
    }),
}

apiResponse, err := sensorInsightsDevicesApi.SensorInsightsListNetworkExperienceHistoryRequest(ctx, body)
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

