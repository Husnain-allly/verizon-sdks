# SIM Actions

```go
simActionsApi := client.SimActionsApi()
```

## Class Name

`SimActionsApi`

## Methods

* [Newactivatecode](../../doc/controllers/sim-actions.md#newactivatecode)
* [Setactivate Using POST](../../doc/controllers/sim-actions.md#setactivate-using-post)
* [Setdeactivate Using POST](../../doc/controllers/sim-actions.md#setdeactivate-using-post)


# Newactivatecode

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

```go
Newactivatecode(
    ctx context.Context,
    body models.EsimProfileRequest2) (
    models.ApiResponse[models.EsimRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.EsimProfileRequest2`](../../doc/models/esim-profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.EsimProfileRequest2{
    Devices:     []models.EsimDeviceList{
        models.EsimDeviceList{
            DeviceIds: []models.EsimDeviceListDeviceIds{
                models.EsimDeviceListDeviceIdsContainer.FromEsimDeviceId(models.EsimDeviceId{
                    Id:                    models.ToPointer("15-digit IMEI"),
                    Kind:                  models.ToPointer("imei"),
                }),
                models.EsimDeviceListDeviceIdsContainer.FromEsimDeviceId(models.EsimDeviceId{
                    Id:                    models.ToPointer("20-digit ICCID"),
                    Kind:                  models.ToPointer("iccid"),
                }),
            },
        },
    },
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("the service plan name"),
    MdnZipCode:  models.ToPointer("five digit zip code"),
}

apiResponse, err := simActionsApi.Newactivatecode(ctx, body)
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
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setactivate Using POST

Uses the profile to activate the SIM.

```go
SetactivateUsingPost(
    ctx context.Context,
    body models.EsimProfileRequest) (
    models.ApiResponse[models.EsimRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.EsimProfileRequest`](../../doc/models/esim-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.EsimProfileRequest{
    Devices:     []models.EsimDeviceList{
        models.EsimDeviceList{
            DeviceIds: []models.EsimDeviceListDeviceIds{
                models.EsimDeviceListDeviceIdsContainer.FromEsimDeviceId(models.EsimDeviceId{
                    Id:                    models.ToPointer("32-digit EID"),
                    Kind:                  models.ToPointer("eid"),
                }),
                models.EsimDeviceListDeviceIdsContainer.FromEsimDeviceId(models.EsimDeviceId{
                    Id:                    models.ToPointer("15-digit IMEI"),
                    Kind:                  models.ToPointer("imei"),
                }),
                models.EsimDeviceListDeviceIdsContainer.FromEsimDeviceId(models.EsimDeviceId{
                    Id:                    models.ToPointer("20-digit ICCID"),
                    Kind:                  models.ToPointer("iccid (ICCID is only used for reactivation)"),
                }),
            },
        },
    },
    CarrierName: models.ToPointer("Verizon Wireless"),
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("the service plan name"),
    MdnZipCode:  models.ToPointer("five digit zip code"),
}

apiResponse, err := simActionsApi.SetactivateUsingPost(ctx, body)
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
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setdeactivate Using POST

Uses the profile to deactivate the SIM.

```go
SetdeactivateUsingPost(
    ctx context.Context,
    body models.ProfileRequest2) (
    models.ApiResponse[models.EsimRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileRequest2{
    AccountName:          models.ToPointer("0000123456-00001"),
    CarrierName:          models.ToPointer("Verizon Wireless"),
    ReasonCode:           models.ToPointer("FF"),
    EtfWaiver:            models.ToPointer(true),
    CheckFallbackProfile: models.ToPointer(false),
}

apiResponse, err := simActionsApi.SetdeactivateUsingPost(ctx, body)
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
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

