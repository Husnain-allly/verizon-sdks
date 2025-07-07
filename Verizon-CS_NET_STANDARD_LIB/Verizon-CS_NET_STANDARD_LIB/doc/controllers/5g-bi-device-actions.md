# 5G BI Device Actions

```csharp
M5GBiDeviceActionsApi m5GBiDeviceActionsApi = client.M5GBiDeviceActionsApi;
```

## Class Name

`M5GBiDeviceActionsApi`

## Methods

* [Business Internetlist Device Information](../../doc/controllers/5g-bi-device-actions.md#business-internetlist-device-information)
* [Business Internetactivate Using POST](../../doc/controllers/5g-bi-device-actions.md#business-internetactivate-using-post)
* [Business Internet Serviceplanchange](../../doc/controllers/5g-bi-device-actions.md#business-internet-serviceplanchange)


# Business Internetlist Device Information

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

```csharp
BusinessInternetlistDeviceInformationAsync(
    Models.M5GBideviceId body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBideviceId`](../../doc/models/m-5g-bidevice-id.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.M5GBideviceDetailsresponse](../../doc/models/m-5g-bidevice-detailsresponse.md).

## Example Usage

```csharp
M5GBideviceId body = new M5GBideviceId
{
    DeviceId = new M5GBideviceId1
    {
        Id = "20-digit ICCID",
        Kind = "iccid",
    },
};

try
{
    ApiResponse<M5GBideviceDetailsresponse> result = await m5GBiDeviceActionsApi.BusinessInternetlistDeviceInformationAsync(body);
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
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internetactivate Using POST

Uses the device's ICCID and IMEI to activate service.

```csharp
BusinessInternetactivateUsingPostAsync(
    Models.M5GBiactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBiactivateRequest`](../../doc/models/m-5g-biactivate-request.md) | Body, Required | Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN). |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.M5GBiRequestResponse](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```csharp
M5GBiactivateRequest body = new M5GBiactivateRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "service plan name",
    DeviceListWithServiceAddress = new List<M5GBiactivateRequestDeviceListWithServiceAddress>
    {
        M5GBiactivateRequestDeviceListWithServiceAddress.From5gbideviceIdarray(
            new M5GBideviceIdarray
            {
                DeviceId = new List<M5GBideviceIdarrayDeviceId>
                {
                    M5GBideviceIdarrayDeviceId.From5gbideviceId1(
                        new M5GBideviceId1
                        {
                            Id = "15-digit IMEI",
                            Kind = "imei",
                        }
                    ),
                    M5GBideviceIdarrayDeviceId.From5gbideviceId1(
                        new M5GBideviceId1
                        {
                            Id = "20-digit ICCID",
                            Kind = "iccid",
                        }
                    ),
                },
            }
        ),
        M5GBiactivateRequestDeviceListWithServiceAddress.From5gbideviceIdarray(
            new M5GBideviceIdarray
            {
                ["primaryPlaceofuse"] = ApiHelper.JsonDeserialize<object>("{\"address\":{\"addressLine1\":\"street number and name\",\"city\":\"city of address\",\"state\":\"2-letter state ID (conforms to ISO 3166-2)\",\"zip\":\"5-digit ZIP code\",\"zip+4\":\"the +4 digits used for ZIP codes\",\"phone\":\"a 10-digit phone number\",\"phoneType\":\"W\"},\"customerName\":{\"firstName\":\"First name\",\"lastName\":\"Surname or Last Name\",\"middleName\":\"middle name or initial\",\"title\":\"Mr. or Ms.\",\"suffex\":\"Dr or Esq\"}}"),
            }
        ),
    },
    PublicIpRestriction = "Unrestricted",
    CarrierName = "Verizon Wireless",
    MdnZipCode = "the 5-digit ZIP code of the Mobile Directory Number (MDN)",
};

try
{
    ApiResponse<M5GBiRequestResponse> result = await m5GBiDeviceActionsApi.BusinessInternetactivateUsingPostAsync(body);
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
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internet Serviceplanchange

Change a device's service plan to use 5G BI.

```csharp
BusinessInternetServiceplanchangeAsync(
    Models.M5GBichangeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBichangeRequest`](../../doc/models/m-5g-bichange-request.md) | Body, Required | This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.M5GBiRequestResponse](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```csharp
M5GBichangeRequest body = new M5GBichangeRequest
{
    AccountName = "0000123456-00001",
    ServicePlan = "5G BI service plan name being changed to",
    DeviceListWithServiceAddress = new List<M5GBichangeRequestDeviceListWithServiceAddress>
    {
        M5GBichangeRequestDeviceListWithServiceAddress.From5gbideviceIdarray2(
            new M5GBideviceIdarray2
            {
                DeviceId = new List<M5GBideviceId1>
                {
                    new M5GBideviceId1
                    {
                        Id = "15-digit IMEI",
                        Kind = "imei",
                    },
                },
            }
        ),
        M5GBichangeRequestDeviceListWithServiceAddress.From5gbideviceIdarray2(
            new M5GBideviceIdarray2
            {
                ["primaryPlaceofuse"] = ApiHelper.JsonDeserialize<object>("{\"address\":{\"addressLine1\":\"street number and name\",\"city\":\"city of address\",\"state\":\"2-letter state ID (conforms to ISO 3166-2)\",\"zip\":\"5-digit ZIP code\",\"zip+4\":\"the +4 digits used for ZIP codes\"},\"customerName\":{\"firstName\":\"First name\",\"lastName\":\"Surname or Last Name\"}}"),
            }
        ),
    },
    CurrentServicePlan = "Name of the plan being changed from",
};

try
{
    ApiResponse<M5GBiRequestResponse> result = await m5GBiDeviceActionsApi.BusinessInternetServiceplanchangeAsync(body);
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
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |

