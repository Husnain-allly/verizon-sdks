# Usage Trigger Management

```go
usageTriggerManagementApi := client.UsageTriggerManagementApi()
```

## Class Name

`UsageTriggerManagementApi`

## Methods

* [Create New Trigger](../../doc/controllers/usage-trigger-management.md#create-new-trigger)
* [Update Trigger](../../doc/controllers/usage-trigger-management.md#update-trigger)
* [Delete Trigger](../../doc/controllers/usage-trigger-management.md#delete-trigger)


# Create New Trigger

Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.

```go
CreateNewTrigger(
    ctx context.Context,
    body *models.UsageTriggerAddRequest) (
    models.ApiResponse[models.UsageTriggerResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`*models.UsageTriggerAddRequest`](../../doc/models/usage-trigger-add-request.md) | Body, Optional | License assignment. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UsageTriggerResponse](../../doc/models/usage-trigger-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.UsageTriggerAddRequest{
    TriggerName:           models.ToPointer("95% usage alert"),
    AccountName:           "0212312345-00001",
    ServiceName:           models.ServiceName_Location,
    ThresholdValue:        "95",
    AllowExcess:           models.ToPointer(true),
    SendSmsNotification:   models.ToPointer(true),
    SmsPhoneNumbers:       models.ToPointer("5551231234"),
    SendEmailNotification: models.ToPointer(true),
    EmailAddresses:        models.ToPointer("you@theinternet.com"),
}

apiResponse, err := usageTriggerManagementApi.CreateNewTrigger(ctx, &body)
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
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d",
  "triggerName": "90 percent",
  "accountName": "1000012345-00001",
  "serviceName": "Location",
  "thresholdValue": "90",
  "allowExcess": true,
  "sendSmsNotification": true,
  "smsPhoneNumbers": "5558794321",
  "sendEmailNotification": false,
  "emailAddresses": "",
  "createDate": "2018-08-11",
  "updateDate": "2018-08-12"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Update Trigger

Update an existing usage trigger

```go
UpdateTrigger(
    ctx context.Context,
    triggerId string,
    body *models.UsageTriggerUpdateRequest) (
    models.ApiResponse[models.UsageTriggerResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | Usage trigger ID |
| `body` | [`*models.UsageTriggerUpdateRequest`](../../doc/models/usage-trigger-update-request.md) | Body, Optional | New trigger values |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UsageTriggerResponse](../../doc/models/usage-trigger-response.md).

## Example Usage

```go
ctx := context.Background()

triggerId := "595f5c44-c31c-4552-8670-020a1545a84d"

body := models.UsageTriggerUpdateRequest{
    AccountName:           "1000012345-00001",
    ThresholdValue:        models.ToPointer("95"),
}

apiResponse, err := usageTriggerManagementApi.UpdateTrigger(ctx, triggerId, &body)
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
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d",
  "triggerName": "90 percent",
  "accountName": "1000012345-00001",
  "serviceName": "Location",
  "thresholdValue": "90",
  "allowExcess": true,
  "sendSmsNotification": true,
  "smsPhoneNumbers": "5558794321",
  "sendEmailNotification": false,
  "emailAddresses": "",
  "createDate": "2018-08-11",
  "updateDate": "2018-08-12"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Delete Trigger

eletes the specified usage trigger from the given account

```go
DeleteTrigger(
    ctx context.Context,
    accountName string,
    triggerId string) (
    models.ApiResponse[models.DeviceLocationSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account name |
| `triggerId` | `string` | Template, Required | Usage trigger ID |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0212312345-00001"

triggerId := "595f5c44-c31c-4552-8670-020a1545a84d"

apiResponse, err := usageTriggerManagementApi.DeleteTrigger(ctx, accountName, triggerId)
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
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

