# 5G BI Device Actions

```go
m5GBiDeviceActionsApi := client.M5GBiDeviceActionsApi()
```

## Class Name

`M5GBiDeviceActionsApi`

## Methods

* [Business Internetlist Device Information](../../doc/controllers/5g-bi-device-actions.md#business-internetlist-device-information)
* [Business Internetactivate Using POST](../../doc/controllers/5g-bi-device-actions.md#business-internetactivate-using-post)
* [Business Internet Serviceplanchange](../../doc/controllers/5g-bi-device-actions.md#business-internet-serviceplanchange)


# Business Internetlist Device Information

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

```go
BusinessInternetlistDeviceInformation(
    ctx context.Context,
    body models.M5GBideviceId) (
    models.ApiResponse[models.M5GBideviceDetailsresponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.M5GBideviceId`](../../doc/models/m-5g-bidevice-id.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.M5GBideviceDetailsresponse](../../doc/models/m-5g-bidevice-detailsresponse.md).

## Example Usage

```go
ctx := context.Background()

body := models.M5GBideviceId{
    DeviceId:              models.ToPointer(models.M5GBideviceId1{
        Id:                    models.ToPointer("20-digit ICCID"),
        Kind:                  models.ToPointer("iccid"),
    }),
}

apiResponse, err := m5GBiDeviceActionsApi.BusinessInternetlistDeviceInformation(ctx, body)
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
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internetactivate Using POST

Uses the device's ICCID and IMEI to activate service.

```go
BusinessInternetactivateUsingPost(
    ctx context.Context,
    body models.M5GBiactivateRequest) (
    models.ApiResponse[models.M5GBiRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.M5GBiactivateRequest`](../../doc/models/m-5g-biactivate-request.md) | Body, Required | Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN). |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.M5GBiRequestResponse](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.M5GBiactivateRequest{
    AccountName:                  models.ToPointer("0000123456-00001"),
    ServicePlan:                  models.ToPointer("service plan name"),
    DeviceListWithServiceAddress: []models.DeviceListWithServiceAddress1{
        models.DeviceListWithServiceAddress1{
            DeviceId:              []models.M5GBideviceId1{
                models.M5GBideviceId1{
                    Id:                    models.ToPointer("15-digit IMEI"),
                    Kind:                  models.ToPointer("imei"),
                },
                models.M5GBideviceId1{
                    Id:                    models.ToPointer("20-digit ICCID"),
                    Kind:                  models.ToPointer("iccid"),
                },
            },
        },
        models.DeviceListWithServiceAddress1{
            PrimaryPlaceofuse:     models.ToPointer(models.M5GBiprimaryPlaceofuse{
                Address:               models.ToPointer(models.M5GBiAddress{
                    AddressLine1:          models.ToPointer("street number and name"),
                    City:                  models.ToPointer("city of address"),
                    State:                 models.ToPointer("2-letter state ID (conforms to ISO 3166-2)"),
                    Zip:                   models.ToPointer("5-digit ZIP code"),
                    Zip4:                  models.ToPointer("the +4 digits used for ZIP codes"),
                    Phone:                 models.ToPointer("a 10-digit phone number"),
                    PhoneType:             models.ToPointer("W"),
                }),
                CustomerName:          models.ToPointer(models.M5GBiCustomerName{
                    FirstName:             models.ToPointer("First name"),
                    LastName:              models.ToPointer("Surname or Last Name"),
                    MiddleName:            models.ToPointer("middle name or initial"),
                    Title:                 models.ToPointer("Mr. or Ms."),
                    Suffex:                models.ToPointer("Dr or Esq"),
                }),
            }),
        },
    },
    PublicIpRestriction:          models.ToPointer("Unrestricted"),
    CarrierName:                  models.ToPointer("Verizon Wireless"),
    MdnZipCode:                   models.ToPointer("the 5-digit ZIP code of the Mobile Directory Number (MDN)"),
}

apiResponse, err := m5GBiDeviceActionsApi.BusinessInternetactivateUsingPost(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

```go
BusinessInternetServiceplanchange(
    ctx context.Context,
    body models.M5GBichangeRequest) (
    models.ApiResponse[models.M5GBiRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.M5GBichangeRequest`](../../doc/models/m-5g-bichange-request.md) | Body, Required | This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.M5GBiRequestResponse](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.M5GBichangeRequest{
    AccountName:                  models.ToPointer("0000123456-00001"),
    ServicePlan:                  models.ToPointer("5G BI service plan name being changed to"),
    DeviceListWithServiceAddress: []models.DeviceListWithServiceAddress{
        models.DeviceListWithServiceAddress{
            DeviceId:              []models.M5GBideviceId1{
                models.M5GBideviceId1{
                    Id:                    models.ToPointer("15-digit IMEI"),
                    Kind:                  models.ToPointer("imei"),
                },
            },
        },
        models.DeviceListWithServiceAddress{
            PrimaryPlaceofuse:     models.ToPointer(models.M5GBiaddressAndcustomerinfo{
                AdditionalProperties:  map[string]interface{}{
                    "address": interface{}("[addressLine1, street number and name][city, city of address][state, 2-letter state ID (conforms to ISO 3166-2)][zip, 5-digit ZIP code][zip+4, the +4 digits used for ZIP codes]"),
                    "customerName": interface{}("[firstName, First name][lastName, Surname or Last Name]"),
                },
            }),
        },
    },
    CurrentServicePlan:           models.ToPointer("Name of the plan being changed from"),
}

apiResponse, err := m5GBiDeviceActionsApi.BusinessInternetServiceplanchange(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

