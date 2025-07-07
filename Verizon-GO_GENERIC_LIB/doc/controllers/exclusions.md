# Exclusions

Exclude devices from location services.

```go
exclusionsApi := client.ExclusionsApi()
```

## Class Name

`ExclusionsApi`

## Methods

* [Devices Location Get Consent Async](../../doc/controllers/exclusions.md#devices-location-get-consent-async)
* [Devices Location Give Consent Async](../../doc/controllers/exclusions.md#devices-location-give-consent-async)
* [Devices Location Update Consent](../../doc/controllers/exclusions.md#devices-location-update-consent)
* [Exclude Devices](../../doc/controllers/exclusions.md#exclude-devices)
* [Remove Devices From Exclusion List](../../doc/controllers/exclusions.md#remove-devices-from-exclusion-list)
* [List Excluded Devices](../../doc/controllers/exclusions.md#list-excluded-devices)


# Devices Location Get Consent Async

Get the consent settings for the entire account or device list in an account.

```go
DevicesLocationGetConsentAsync(
    ctx context.Context,
    accountName string,
    deviceId *string) (
    models.ApiResponse[models.GetAccountDeviceConsent],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | The numeric name of the account. |
| `deviceId` | `*string` | Query, Optional | The IMEI of the device being queried |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GetAccountDeviceConsent](../../doc/models/get-account-device-consent.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

deviceId := "900000000000009"

apiResponse, err := exclusionsApi.DevicesLocationGetConsentAsync(ctx, accountName, &deviceId)
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
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Devices Location Give Consent Async

Create a consent record to use location services as an asynchronous request.

```go
DevicesLocationGiveConsentAsync(
    ctx context.Context,
    body *models.AccountConsentCreate) (
    models.ApiResponse[models.ConsentTransactionId],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`*models.AccountConsentCreate`](../../doc/models/account-consent-create.md) | Body, Optional | Account details to create a consent record. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConsentTransactionId](../../doc/models/consent-transaction-id.md).

## Example Usage

```go
ctx := context.Background()

body := models.AccountConsentCreate{
    AccountName:           models.ToPointer("0000123456-00001"),
}

apiResponse, err := exclusionsApi.DevicesLocationGiveConsentAsync(ctx, &body)
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
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Devices Location Update Consent

Update the location services consent record for an entire account.

```go
DevicesLocationUpdateConsent(
    ctx context.Context,
    body *models.AccountConsentUpdate) (
    models.ApiResponse[models.ConsentTransactionId],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`*models.AccountConsentUpdate`](../../doc/models/account-consent-update.md) | Body, Optional | Account details to update a consent record. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConsentTransactionId](../../doc/models/consent-transaction-id.md).

## Example Usage

```go
ctx := context.Background()

body := models.AccountConsentUpdate{
    AccountName:           models.ToPointer("0000123456-00001"),
    AllDeviceConsent:      models.ToPointer(0),
}

apiResponse, err := exclusionsApi.DevicesLocationUpdateConsent(ctx, &body)
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
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Exclude Devices

This consents endpoint sets a new exclusion list.

```go
ExcludeDevices(
    ctx context.Context,
    body models.ConsentRequest) (
    models.ApiResponse[models.DeviceLocationSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ConsentRequest`](../../doc/models/consent-request.md) | Body, Required | Request to update account consent exclusion list. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.ConsentRequest{
    AccountName:           "1234567890-00001",
    AllDevice:             models.ToPointer(false),
    Type:                  models.ToPointer("replace"),
    Exclusion:             []string{
        "980003420535573",
        "375535024300089",
        "A100003861E585",
    },
}

apiResponse, err := exclusionsApi.ExcludeDevices(ctx, body)
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
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Remove Devices From Exclusion List

Removes devices from the exclusion list so that they can be located with Device Location Services requests.

```go
RemoveDevicesFromExclusionList(
    ctx context.Context,
    accountName string,
    deviceList string) (
    models.ApiResponse[models.DeviceLocationSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | The numeric name of the account. |
| `deviceList` | `string` | Query, Required | A list of the device IDs to remove from the exclusion list. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

deviceList := "IMEI"

apiResponse, err := exclusionsApi.RemoveDevicesFromExclusionList(ctx, accountName, deviceList)
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Excluded Devices

This consents endpoint retrieves a list of excluded devices in an account.

```go
ListExcludedDevices(
    ctx context.Context,
    accountName string,
    startIndex string) (
    models.ApiResponse[models.DevicesConsentResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `string` | Template, Required | Zero-based number of the first record to return. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DevicesConsentResult](../../doc/models/devices-consent-result.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0252012345-00001"

startIndex := "0"

apiResponse, err := exclusionsApi.ListExcludedDevices(ctx, accountName, startIndex)
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
  "accountName": "2024009649-00001",
  "allDevice": false,
  "hasMoreData": false,
  "totalCount": 4,
  "updateTime": "2018-05-18 19:20:50.076 +0000 UTC",
  "exclusion": [
    "990003420535375",
    "420535399000375",
    "A100003861E585",
    "205353759900034"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

