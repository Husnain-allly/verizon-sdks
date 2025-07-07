# SIM Securefor Io T Licenses

```csharp
SimSecureforIoTLicensesApi simSecureforIoTLicensesApi = client.SimSecureforIoTLicensesApi;
```

## Class Name

`SimSecureforIoTLicensesApi`

## Methods

* [Assign License to Devices](../../doc/controllers/sim-securefor-io-t-licenses.md#assign-license-to-devices)
* [Unassign License to Devices](../../doc/controllers/sim-securefor-io-t-licenses.md#unassign-license-to-devices)


# Assign License to Devices

Assigns SIM-Secure for IoT licenses to SIMs.

```csharp
AssignLicenseToDevicesAsync(
    Models.AssignLicenseRequest body,
    string xRequestId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AssignLicenseRequest`](../../doc/models/assign-license-request.md) | Body, Required | Request to assign license to devices. |
| `xRequestId` | `string` | Header, Optional | Transaction Id.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]-[0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SecuritySuccessResult](../../doc/models/security-success-result.md).

## Example Usage

```csharp
AssignLicenseRequest body = new AssignLicenseRequest
{
    AccountName = "0000123456-00001",
    Devices = new List<LicenseDeviceList>
    {
        new LicenseDeviceList
        {
            DeviceIds = new List<LicenseDeviceId>
            {
                new LicenseDeviceId
                {
                    Id = "864508030109877",
                    Kind = "IMEI",
                },
            },
        },
    },
    SkuNumber = "SIMSec-IoT-Lt",
};

try
{
    ApiResponse<SecuritySuccessResult> result = await simSecureForIoTLicensesApi.AssignLicenseToDevicesAsync(body);
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
  "requestId": "c3f3d17c-79ff-4b35-82df-94446785b6e0"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 401 | Unauthorized request. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 403 | Request Forbidden. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 404 | Not Found / Does not exist. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 406 | Format / Request Unacceptable. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 429 | Too many requests. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| Default | Error response. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |


# Unassign License to Devices

Unassigns SIM-Secure for IoT Flexible and Flexible Bundle license from SIMs.

```csharp
UnassignLicenseToDevicesAsync(
    string xRequestId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xRequestId` | `string` | Header, Required | Transaction Id.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]-[0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SecuritySuccessResult](../../doc/models/security-success-result.md).

## Example Usage

```csharp
string xRequestId = "X-Request-ID2";
try
{
    ApiResponse<SecuritySuccessResult> result = await simSecureForIoTLicensesApi.UnassignLicenseToDevicesAsync(xRequestId);
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
  "requestId": "1f28c944-d007-44c9-9543-003b8820cc69"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 401 | Unauthorized request. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 403 | Request forbidden. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 404 | Not Found / Does not exist. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 406 | Format / Request Unacceptable. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| 429 | Too many requests. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |
| Default | Error response. | [`SecurityResultException`](../../doc/models/security-result-exception.md) |

