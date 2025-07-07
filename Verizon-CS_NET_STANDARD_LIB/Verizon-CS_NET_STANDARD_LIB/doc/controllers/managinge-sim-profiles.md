# Managinge SIM Profiles

```csharp
ManagingeSimProfilesApi managingeSimProfilesApi = client.ManagingeSimProfilesApi;
```

## Class Name

`ManagingeSimProfilesApi`

## Methods

* [Resume Profile](../../doc/controllers/managinge-sim-profiles.md#resume-profile)
* [Profile Suspend](../../doc/controllers/managinge-sim-profiles.md#profile-suspend)
* [Device Suspend](../../doc/controllers/managinge-sim-profiles.md#device-suspend)
* [Set Fallback](../../doc/controllers/managinge-sim-profiles.md#set-fallback)
* [Activate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#activate-a-device-profile)
* [Enable a Device Profile](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile)
* [Deactivate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#deactivate-a-device-profile)
* [Enable a Device Profile for Download](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile-for-download)
* [Download a Device Profile](../../doc/controllers/managinge-sim-profiles.md#download-a-device-profile)
* [Delete a Device Profile](../../doc/controllers/managinge-sim-profiles.md#delete-a-device-profile)


# Resume Profile

Resume service to a device with either a lead or local profile.

```csharp
ResumeProfileAsync(
    Models.GioProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
GioProfileRequest body = new GioProfileRequest
{
    Devices = new List<GioDeviceList>
    {
        new GioDeviceList
        {
        },
    },
    AccountName = "0000123456-00001",
    MdnZipCode = "12345",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.ResumeProfileAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Profile Suspend

Suspend a device's Global profile.

```csharp
ProfileSuspendAsync(
    Models.GioProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
GioProfileRequest body = new GioProfileRequest
{
    Devices = new List<GioDeviceList>
    {
        new GioDeviceList
        {
        },
    },
    AccountName = "0000123456-00001",
    MdnZipCode = "12345",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.ProfileSuspendAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Device Suspend

Suspend all service to an eUICC device, including the lead and local profile.

```csharp
DeviceSuspendAsync(
    Models.GioProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
GioProfileRequest body = new GioProfileRequest
{
    Devices = new List<GioDeviceList>
    {
        new GioDeviceList
        {
        },
    },
    AccountName = "0000123456-00001",
    MdnZipCode = "12345",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.DeviceSuspendAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Set Fallback

Enable a fallback profile to be set.

```csharp
SetFallbackAsync(
    Models.FallBack body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`FallBack`](../../doc/models/fall-back.md) | Body, Required | Set the fallback attributes to allow a fallback profile to be activated. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
FallBack body = new FallBack
{
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.SetFallbackAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Activate a Device Profile

Activate a device with either a lead or local profile.

```csharp
ActivateADeviceProfileAsync(
    Models.GioProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
GioProfileRequest body = new GioProfileRequest
{
    Devices = new List<GioDeviceList>
    {
        new GioDeviceList
        {
        },
    },
    AccountName = "0000123456-00001",
    MdnZipCode = "12345",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.ActivateADeviceProfileAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile

Enable a device lead or local profile.

```csharp
EnableADeviceProfileAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.EnableADeviceProfileAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Deactivate a Device Profile

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

```csharp
DeactivateADeviceProfileAsync(
    Models.GioDeactivateDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioDeactivateDeviceProfileRequest`](../../doc/models/gio-deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
GioDeactivateDeviceProfileRequest body = new GioDeactivateDeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
    EtfWaiver = false,
    ReasonCode = "FF",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.DeactivateADeviceProfileAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile for Download

Enable the Global IoT Orchestration device profile for download.

```csharp
EnableADeviceProfileForDownloadAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.EnableADeviceProfileForDownloadAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Download a Device Profile

Download a Global IoT Orchestration device profile.

```csharp
DownloadADeviceProfileAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.DownloadADeviceProfileAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Delete a Device Profile

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

```csharp
DeleteADeviceProfileAsync(
    Models.DeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
DeviceProfileRequest body = new DeviceProfileRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
};

try
{
    ApiResponse<GioRequestResponse> result = await managingEsimProfilesApi.DeleteADeviceProfileAsync(body);
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

