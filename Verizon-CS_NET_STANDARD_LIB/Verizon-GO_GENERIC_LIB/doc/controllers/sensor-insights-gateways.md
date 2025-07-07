# Sensor Insights Gateways

```go
sensorInsightsGatewaysApi := client.SensorInsightsGatewaysApi()
```

## Class Name

`SensorInsightsGatewaysApi`


# Sensor Insights List Gateway Devices Request

```go
SensorInsightsListGatewayDevicesRequest(
    ctx context.Context,
    body models.DtoListDevicesRequest) (
    models.ApiResponse[[]models.ResourceDevice],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | Get gateway information |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.ResourceDevice](../../doc/models/resource-device.md).

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

apiResponse, err := sensorInsightsGatewaysApi.SensorInsightsListGatewayDevicesRequest(ctx, body)
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

