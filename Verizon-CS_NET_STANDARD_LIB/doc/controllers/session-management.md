# Session Management

```csharp
SessionManagementApi sessionManagementApi = client.SessionManagementApi;
```

## Class Name

`SessionManagementApi`

## Methods

* [Start Connectivity Management Session](../../doc/controllers/session-management.md#start-connectivity-management-session)
* [End Connectivity Management Session](../../doc/controllers/session-management.md#end-connectivity-management-session)
* [Reset Connectivity Management Password](../../doc/controllers/session-management.md#reset-connectivity-management-password)


# Start Connectivity Management Session

Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

```csharp
StartConnectivityManagementSessionAsync(
    Models.LogInRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LogInRequest`](../../doc/models/log-in-request.md) | Body, Optional | Request to initiate a session. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.LogInResult](../../doc/models/log-in-result.md).

## Example Usage

```csharp
LogInRequest body = new LogInRequest
{
    Username = "zbeeblebrox",
    Password = "IMgr8",
};

try
{
    ApiResponse<LogInResult> result = await sessionManagementApi.StartConnectivityManagementSessionAsync(body);
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
  "sessionToken": "bcce3ea6-fe4f-4952-bacf-eadd80718e83"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# End Connectivity Management Session

Ends a Connectivity Management session.

```csharp
EndConnectivityManagementSessionAsync()
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.LogOutRequest](../../doc/models/log-out-request.md).

## Example Usage

```csharp
try
{
    ApiResponse<LogOutRequest> result = await sessionManagementApi.EndConnectivityManagementSessionAsync();
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
  "sessionToken": "bcce3ea6-fe4f-4952-bacf-eadd80718e83"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Reset Connectivity Management Password

The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.

```csharp
ResetConnectivityManagementPasswordAsync(
    Models.SessionResetPasswordRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SessionResetPasswordRequest`](../../doc/models/session-reset-password-request.md) | Body, Required | Request with current password that needs to be reset. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SessionResetPasswordResult](../../doc/models/session-reset-password-result.md).

## Example Usage

```csharp
SessionResetPasswordRequest body = new SessionResetPasswordRequest
{
    OldPassword = "grflbk",
};

try
{
    ApiResponse<SessionResetPasswordResult> result = await sessionManagementApi.ResetConnectivityManagementPasswordAsync(body);
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
  "newPassword": "Wh0a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

