# Session Management

```go
sessionManagementApi := client.SessionManagementApi()
```

## Class Name

`SessionManagementApi`

## Methods

* [Start Connectivity Management Session](../../doc/controllers/session-management.md#start-connectivity-management-session)
* [End Connectivity Management Session](../../doc/controllers/session-management.md#end-connectivity-management-session)
* [Reset Connectivity Management Password](../../doc/controllers/session-management.md#reset-connectivity-management-password)


# Start Connectivity Management Session

Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

```go
StartConnectivityManagementSession(
    ctx context.Context,
    body *models.LogInRequest) (
    models.ApiResponse[models.LogInResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`*models.LogInRequest`](../../doc/models/log-in-request.md) | Body, Optional | Request to initiate a session. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.LogInResult](../../doc/models/log-in-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.LogInRequest{
    Username:              "zbeeblebrox",
    Password:              "IMgr8",
}

apiResponse, err := sessionManagementApi.StartConnectivityManagementSession(ctx, &body)
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
  "sessionToken": "bcce3ea6-fe4f-4952-bacf-eadd80718e83"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# End Connectivity Management Session

Ends a Connectivity Management session.

```go
EndConnectivityManagementSession(
    ctx context.Context) (
    models.ApiResponse[models.LogOutRequest],
    error)
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.LogOutRequest](../../doc/models/log-out-request.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := sessionManagementApi.EndConnectivityManagementSession(ctx)
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
  "sessionToken": "bcce3ea6-fe4f-4952-bacf-eadd80718e83"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Reset Connectivity Management Password

The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.

```go
ResetConnectivityManagementPassword(
    ctx context.Context,
    body models.SessionResetPasswordRequest) (
    models.ApiResponse[models.SessionResetPasswordResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SessionResetPasswordRequest`](../../doc/models/session-reset-password-request.md) | Body, Required | Request with current password that needs to be reset. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SessionResetPasswordResult](../../doc/models/session-reset-password-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.SessionResetPasswordRequest{
    OldPassword:           "grflbk",
}

apiResponse, err := sessionManagementApi.ResetConnectivityManagementPassword(ctx, body)
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
  "newPassword": "Wh0a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

