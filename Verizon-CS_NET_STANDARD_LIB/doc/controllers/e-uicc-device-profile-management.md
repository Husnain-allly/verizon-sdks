# E UICC Device Profile Management

```csharp
EuiccDeviceProfileManagementApi euiccDeviceProfileManagementApi = client.EuiccDeviceProfileManagementApi;
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

```csharp
DownloadLocalProfileToEnableAsync(
    Models.ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
ProfileChangeStateRequest body = new ProfileChangeStateRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "678912789123453456784008666456",
                    Kind = "eid",
                },
                new DeviceId
                {
                    Id = "78425989148000000840",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "1223334444-00001",
    SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
};

try
{
    ApiResponse<DeviceManagementResult> result = await euiccDeviceProfileManagementApi.DownloadLocalProfileToEnableAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Download Local Profile to Disable

Downloads an eUICC local profile to devices and leaves the profile disabled.

```csharp
DownloadLocalProfileToDisableAsync(
    Models.ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
ProfileChangeStateRequest body = new ProfileChangeStateRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "678912789123453456784008666456",
                    Kind = "eid",
                },
                new DeviceId
                {
                    Id = "78425989148000000840",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "1223334444-00001",
    SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
};

try
{
    ApiResponse<DeviceManagementResult> result = await euiccDeviceProfileManagementApi.DownloadLocalProfileToDisableAsync(body);
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
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Enable Local Profile

Enable a local profile that has been downloaded to eUICC devices.

```csharp
EnableLocalProfileAsync(
    Models.ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```csharp
ProfileChangeStateRequest body = new ProfileChangeStateRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "678912789123453456784008666456",
                    Kind = "eid",
                },
                new DeviceId
                {
                    Id = "78425989148000000840",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "1223334444-00001",
    SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
};

try
{
    ApiResponse<RequestResponse> result = await euiccDeviceProfileManagementApi.EnableLocalProfileAsync(body);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Disable Local Profile

Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.

```csharp
DisableLocalProfileAsync(
    Models.ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```csharp
ProfileChangeStateRequest body = new ProfileChangeStateRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "678912789123453456784008666456",
                    Kind = "eid",
                },
                new DeviceId
                {
                    Id = "78425989148000000840",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "1223334444-00001",
    SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
};

try
{
    ApiResponse<RequestResponse> result = await euiccDeviceProfileManagementApi.DisableLocalProfileAsync(body);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Delete Local Profile

Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.

```csharp
DeleteLocalProfileAsync(
    Models.ProfileChangeStateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```csharp
ProfileChangeStateRequest body = new ProfileChangeStateRequest
{
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "678912789123453456784008666456",
                    Kind = "eid",
                },
                new DeviceId
                {
                    Id = "78425989148000000840",
                    Kind = "iccid",
                },
            },
        },
    },
    AccountName = "1223334444-00001",
    SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
};

try
{
    ApiResponse<RequestResponse> result = await euiccDeviceProfileManagementApi.DeleteLocalProfileAsync(body);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

