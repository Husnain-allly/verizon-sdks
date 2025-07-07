# Global Reporting

```go
globalReportingApi := client.GlobalReportingApi()
```

## Class Name

`GlobalReportingApi`

## Methods

* [Deviceprovhistory Using POST](../../doc/controllers/global-reporting.md#deviceprovhistory-using-post)
* [Retrieve Global List](../../doc/controllers/global-reporting.md#retrieve-global-list)


# Deviceprovhistory Using POST

Retrieve the provisioning history of a specific device or devices.

```go
DeviceprovhistoryUsingPost(
    ctx context.Context,
    body models.EsimProvhistoryRequest) (
    models.ApiResponse[models.EsimRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.EsimProvhistoryRequest`](../../doc/models/esim-provhistory-request.md) | Body, Required | Device Provisioning History |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.EsimProvhistoryRequest{
    AccountName:  models.ToPointer("0000123456-00001"),
    Earliest:     models.ToPointer(parseTime(time.RFC3339, "10/15/2021 04:49:35", func(err error) { log.Fatalln(err) })),
    Latest:       models.ToPointer(parseTime(time.RFC3339, "10/15/2021 04:49:49", func(err error) { log.Fatalln(err) })),
}

apiResponse, err := globalReportingApi.DeviceprovhistoryUsingPost(ctx, body)
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


# Retrieve Global List

Retrieve a list of all devices associated with an account.

```go
RetrieveGlobalList(
    ctx context.Context,
    body models.EsimGlobalDeviceList) (
    models.ApiResponse[models.EsimRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.EsimGlobalDeviceList`](../../doc/models/esim-global-device-list.md) | Body, Required | Device List |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.EsimGlobalDeviceList{
    AccountName:              models.ToPointer("0000123456-00001"),
    CarrierNameFilter:        models.ToPointer("VerizonWireless"),
}

apiResponse, err := globalReportingApi.RetrieveGlobalList(ctx, body)
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
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

