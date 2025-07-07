# Account Requests

```go
accountRequestsApi := client.AccountRequestsApi()
```

## Class Name

`AccountRequestsApi`


# Get Current Asynchronous Request Status

Returns the current status of an asynchronous request that was made for a single device.

```go
GetCurrentAsynchronousRequestStatus(
    ctx context.Context,
    aname string,
    requestId string) (
    models.ApiResponse[models.AsynchronousRequestResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `requestId` | `string` | Template, Required | UUID from synchronous response. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AsynchronousRequestResult](../../doc/models/asynchronous-request-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

requestId := "86c83330-4bf5-4235-9c4e-a83f93aeae4c"

apiResponse, err := accountRequestsApi.GetCurrentAsynchronousRequestStatus(ctx, aname, requestId)
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
  "requestId": "86c83330-4bf5-4235-9c4e-a83f93aeae4c",
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

