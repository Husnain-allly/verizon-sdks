# Firmware V3

```csharp
FirmwareV3Api firmwareV3Api = client.FirmwareV3Api;
```

## Class Name

`FirmwareV3Api`

## Methods

* [List Available Firmware](../../doc/controllers/firmware-v3.md#list-available-firmware)
* [Synchronize Device Firmware](../../doc/controllers/firmware-v3.md#synchronize-device-firmware)
* [Report Device Firmware](../../doc/controllers/firmware-v3.md#report-device-firmware)


# List Available Firmware

This endpoint allows user to list the firmware of an account.

```csharp
ListAvailableFirmwareAsync(
    string acc,
    Models.FirmwareProtocol protocol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `protocol` | [`FirmwareProtocol`](../../doc/models/firmware-protocol.md) | Query, Required | Filter to retrieve a specific protocol type used. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.FirmwarePackage>](../../doc/models/firmware-package.md).

## Example Usage

```csharp
string acc = "0000123456-00001";
FirmwareProtocol protocol = FirmwareProtocol.LwM2M;
try
{
    ApiResponse<List<FirmwarePackage>> result = await firmwareV3Api.ListAvailableFirmwareAsync(
        acc,
        protocol
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "firmwareName": "VerizonSmartCommunities_LCO-277C4N_BG96MAR04A04M1G_BG96MAR04A04M1G_BETA0130B",
    "firmwareFrom": "BG96MAR04A04M1G",
    "firmwareTo": "BG96MAR04A04M1G_BETA0130B",
    "launchDate": "2012-04-23T18:25:43.511Z",
    "releaseNote": "",
    "model": "LCO-277C4N",
    "make": "Verizon Smart Communities",
    "protocol": "LWM2M"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Synchronize Device Firmware

Synchronize ThingSpace with the FOTA server for up to 100 devices.

```csharp
SynchronizeDeviceFirmwareAsync(
    string acc,
    Models.FirmwareImei body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`FirmwareImei`](../../doc/models/firmware-imei.md) | Body, Required | DeviceIds to get firmware info synchronously. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceFirmwareList](../../doc/models/device-firmware-list.md).

## Example Usage

```csharp
string acc = "0000123456-00001";
FirmwareImei body = new FirmwareImei
{
    DeviceList = new List<string>
    {
        "15-digit IMEI",
    },
};

try
{
    ApiResponse<DeviceFirmwareList> result = await firmwareV3Api.SynchronizeDeviceFirmwareAsync(
        acc,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "deviceFirmwarVersionList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "FirmwareVersionUpdateSuccess",
      "firmwareVersion": "SR1.2.0.0-10657"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Report Device Firmware

Ask a device to report its firmware version asynchronously.

```csharp
ReportDeviceFirmwareAsync(
    string acc,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceFirmwareVersionUpdateResult](../../doc/models/device-firmware-version-update-result.md).

## Example Usage

```csharp
string acc = "0000123456-00001";
string deviceId = "15-digit IMEI";
try
{
    ApiResponse<DeviceFirmwareVersionUpdateResult> result = await firmwareV3Api.ReportDeviceFirmwareAsync(
        acc,
        deviceId
    );
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

