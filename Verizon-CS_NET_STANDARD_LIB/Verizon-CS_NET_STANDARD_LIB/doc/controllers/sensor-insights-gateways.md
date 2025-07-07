# Sensor Insights Gateways

```csharp
SensorInsightsGatewaysApi sensorInsightsGatewaysApi = client.SensorInsightsGatewaysApi;
```

## Class Name

`SensorInsightsGatewaysApi`


# Sensor Insights List Gateway Devices Request

```csharp
SensorInsightsListGatewayDevicesRequestAsync(
    Models.DtoListDevicesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | Get gateway information |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ResourceDevice>](../../doc/models/resource-device.md).

## Example Usage

```csharp
DtoListDevicesRequest body = new DtoListDevicesRequest
{
    Accountname = "0000123456-00001",
    Filter = new DtoFilter
    {
        MExpand = "device detail(s)",
        MLimitnumber = 100,
        MNopagination = true,
        MPage = "The number of pages",
        MPagenumber = 100,
        MProjection = new List<string>
        {
            "specific device fields requested",
        },
        MSelection = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("\"string\""),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("\"string\""),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("\"string\""),
        },
    },
    Resourceidentifier = new DtoDeviceResourceIdentifier
    {
        Deveui = "The unique EUI64 address of the device",
        Deviceid = "The UUID of the device",
        Esn = 223372036854775800,
        Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
        Imei = 223372036854775,
        Imsi = 223372036854775800,
        Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
        Manufacturer = "REOLINK",
        Meid = "The 56-bit Mobile Equipment ID",
        Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
        NodeUuid = "The UUID of the node the device is associated with",
        Qrcode = "The Quick Response (QR) code",
        Serial = "The device's serial number",
    },
};

try
{
    ApiResponse<List<ResourceDevice>> result = await sensorInsightsGatewaysApi.SensorInsightsListGatewayDevicesRequestAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

