# SIM Actions

```csharp
SimActionsApi simActionsApi = client.SimActionsApi;
```

## Class Name

`SimActionsApi`

## Methods

* [Newactivatecode](../../doc/controllers/sim-actions.md#newactivatecode)
* [Setactivate Using POST](../../doc/controllers/sim-actions.md#setactivate-using-post)
* [Setdeactivate Using POST](../../doc/controllers/sim-actions.md#setdeactivate-using-post)


# Newactivatecode

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

```csharp
NewactivatecodeAsync(
    Models.EsimProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest2`](../../doc/models/esim-profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```csharp
EsimProfileRequest2 body = new EsimProfileRequest2
{
    Devices = new List<EsimDeviceList>
    {
        new EsimDeviceList
        {
            DeviceIds = new List<EsimDeviceListDeviceIds>
            {
                EsimDeviceListDeviceIds.FromESIMDeviceId(
                    new EsimDeviceId
                    {
                        Id = "15-digit IMEI",
                        Kind = "imei",
                    }
                ),
                EsimDeviceListDeviceIds.FromESIMDeviceId(
                    new EsimDeviceId
                    {
                        Id = "20-digit ICCID",
                        Kind = "iccid",
                    }
                ),
            },
        },
    },
    AccountName = "0000123456-00001",
    ServicePlan = "the service plan name",
    MdnZipCode = "five digit zip code",
};

try
{
    ApiResponse<EsimRequestResponse> result = await simActionsApi.NewactivatecodeAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setactivate Using POST

Uses the profile to activate the SIM.

```csharp
SetactivateUsingPostAsync(
    Models.EsimProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest`](../../doc/models/esim-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```csharp
EsimProfileRequest body = new EsimProfileRequest
{
    Devices = new List<EsimDeviceList>
    {
        new EsimDeviceList
        {
            DeviceIds = new List<EsimDeviceListDeviceIds>
            {
                EsimDeviceListDeviceIds.FromESIMDeviceId(
                    new EsimDeviceId
                    {
                        Id = "32-digit EID",
                        Kind = "eid",
                    }
                ),
                EsimDeviceListDeviceIds.FromESIMDeviceId(
                    new EsimDeviceId
                    {
                        Id = "15-digit IMEI",
                        Kind = "imei",
                    }
                ),
                EsimDeviceListDeviceIds.FromESIMDeviceId(
                    new EsimDeviceId
                    {
                        Id = "20-digit ICCID",
                        Kind = "iccid (ICCID is only used for reactivation)",
                    }
                ),
            },
        },
    },
    CarrierName = "Verizon Wireless",
    AccountName = "0000123456-00001",
    ServicePlan = "the service plan name",
    MdnZipCode = "five digit zip code",
};

try
{
    ApiResponse<EsimRequestResponse> result = await simActionsApi.SetactivateUsingPostAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setdeactivate Using POST

Uses the profile to deactivate the SIM.

```csharp
SetdeactivateUsingPostAsync(
    Models.ProfileRequest2 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```csharp
ProfileRequest2 body = new ProfileRequest2
{
    AccountName = "0000123456-00001",
    CarrierName = "Verizon Wireless",
    ReasonCode = "FF",
    EtfWaiver = true,
    CheckFallbackProfile = false,
};

try
{
    ApiResponse<EsimRequestResponse> result = await simActionsApi.SetdeactivateUsingPostAsync(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

