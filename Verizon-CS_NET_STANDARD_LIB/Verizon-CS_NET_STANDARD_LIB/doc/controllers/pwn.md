# PWN

```csharp
PwnApi pwnApi = client.PwnApi;
```

## Class Name

`PwnApi`

## Methods

* [KPI List](../../doc/controllers/pwn.md#kpi-list)
* [Get Profile List](../../doc/controllers/pwn.md#get-profile-list)
* [Change PWN Device State-Activate](../../doc/controllers/pwn.md#change-pwn-device-state-activate)
* [Change PWN Device State-Deactivate](../../doc/controllers/pwn.md#change-pwn-device-state-deactivate)
* [Change PWN Device Profile](../../doc/controllers/pwn.md#change-pwn-device-profile)
* [Change PWN Device IPaddress](../../doc/controllers/pwn.md#change-pwn-device-ipaddress)
* [Get PWN Performance Consent](../../doc/controllers/pwn.md#get-pwn-performance-consent)


# KPI List

```csharp
KpiListAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.KpiInfoList](../../doc/models/kpi-info-list.md).

## Example Usage

```csharp
string aname = "0342351414-00001";
try
{
    ApiResponse<KpiInfoList> result = await pwnApi.KpiListAsync(aname);
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
  "KpiInfoList": [
    {
      "name": "DOWNLINK_THROUGHPUT",
      "value": "23.2",
      "nodeName": "132924_ENB_VZ_EULESS_OLTE_RD-01",
      "nodeType": "BASEBAND",
      "description": "Downlink throughput (4G)",
      "unit": "Mbps",
      "category": "Network Performance Radio",
      "timeOfLastUpdate": "2022-12-07T08:39:59.228Z"
    }
  ]
}
```


# Get Profile List

```csharp
GetProfileListAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PwnProfileList](../../doc/models/pwn-profile-list.md).

## Example Usage

```csharp
string aname = "0342351414-00001";
try
{
    ApiResponse<PwnProfileList> result = await pwnApi.GetProfileListAsync(aname);
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
  "profiles": [
    {
      "profileId": "HSS-EsmProfile_Enterprise",
      "profileName": "HSS EsmProfile Enterprise"
    }
  ]
}
```


# Change PWN Device State-Activate

```csharp
ChangePwnDeviceStateActivateAsync(
    Models.ChangePwnDeviceStateActivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateActivateRequest`](../../doc/models/change-pwn-device-state-activate-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ChangePwnDeviceStateResponse](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```csharp
ChangePwnDeviceStateActivateRequest body = new ChangePwnDeviceStateActivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<PwnDeviceList>
    {
        new PwnDeviceList
        {
            DeviceIds = new List<PwnDeviceId>
            {
                new PwnDeviceId
                {
                    Id = "99948099913024600001",
                    Kind = "iccid",
                },
            },
        },
    },
    Activate = new Activate
    {
        Profile = "HSS EsmProfile Enterprise 5G",
    },
};

try
{
    ApiResponse<ChangePwnDeviceStateResponse> result = await pwnApi.ChangePwnDeviceStateActivateAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device State-Deactivate

```csharp
ChangePwnDeviceStateDeactivateAsync(
    Models.ChangePwnDeviceStateDeactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateDeactivateRequest`](../../doc/models/change-pwn-device-state-deactivate-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ChangePwnDeviceStateResponse](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```csharp
ChangePwnDeviceStateDeactivateRequest body = new ChangePwnDeviceStateDeactivateRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<PwnDeviceList>
    {
        new PwnDeviceList
        {
            DeviceIds = new List<PwnDeviceId>
            {
                new PwnDeviceId
                {
                    Id = "99948099913031600000",
                    Kind = "iccid",
                },
            },
        },
        new PwnDeviceList
        {
            DeviceIds = new List<PwnDeviceId>
            {
                new PwnDeviceId
                {
                    Id = "99948099913031700000",
                    Kind = "iccid",
                },
            },
        },
    },
};

try
{
    ApiResponse<ChangePwnDeviceStateResponse> result = await pwnApi.ChangePwnDeviceStateDeactivateAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device Profile

```csharp
ChangePwnDeviceProfileAsync(
    Models.ChangePwnDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceProfileRequest`](../../doc/models/change-pwn-device-profile-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ChangePwnDeviceProfileResponse](../../doc/models/change-pwn-device-profile-response.md).

## Example Usage

```csharp
ChangePwnDeviceProfileRequest body = new ChangePwnDeviceProfileRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<PwnDeviceList>
    {
        new PwnDeviceList
        {
            DeviceIds = new List<PwnDeviceId>
            {
                new PwnDeviceId
                {
                    Id = "99948099913024600000",
                    Kind = "iccid",
                },
            },
        },
    },
    NewProfile = "HSS EsmProfile Enterprise 5G internet",
};

try
{
    ApiResponse<ChangePwnDeviceProfileResponse> result = await pwnApi.ChangePwnDeviceProfileAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device IPaddress

```csharp
ChangePwnDeviceIpaddressAsync(
    Models.ChangePwnDeviceIpaddressRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceIpaddressRequest`](../../doc/models/change-pwn-device-ipaddress-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ChangePwnDeviceIpaddressResponse](../../doc/models/change-pwn-device-ipaddress-response.md).

## Example Usage

```csharp
ChangePwnDeviceIpaddressRequest body = new ChangePwnDeviceIpaddressRequest
{
    AccountName = "0342351414-00001",
    DeviceList = new List<DeviceListIp>
    {
        new DeviceListIp
        {
            DeviceIds = new List<PwnDeviceId>
            {
                new PwnDeviceId
                {
                    Id = "99948099913024600000",
                    Kind = "iccid",
                },
            },
            Ipaddress = "10.3.4.5",
        },
        new DeviceListIp
        {
            DeviceIds = new List<PwnDeviceId>
            {
                new PwnDeviceId
                {
                    Id = "999480500019111000001",
                    Kind = "iccid",
                },
            },
            Ipaddress = "10.4.5.7",
        },
    },
};

try
{
    ApiResponse<ChangePwnDeviceIpaddressResponse> result = await pwnApi.ChangePwnDeviceIpaddressAsync(body);
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Get PWN Performance Consent

```csharp
GetPwnPerformanceConsentAsync(
    string aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GetPwnPerformanceConsentResponse](../../doc/models/get-pwn-performance-consent-response.md).

## Example Usage

```csharp
string aname = "1533445500-00088";
try
{
    ApiResponse<GetPwnPerformanceConsentResponse> result = await pwnApi.GetPwnPerformanceConsentAsync(aname);
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
  "consent": "false"
}
```

