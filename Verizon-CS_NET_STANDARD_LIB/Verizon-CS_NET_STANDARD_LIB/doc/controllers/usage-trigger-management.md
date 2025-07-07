# Usage Trigger Management

```csharp
UsageTriggerManagementApi usageTriggerManagementApi = client.UsageTriggerManagementApi;
```

## Class Name

`UsageTriggerManagementApi`

## Methods

* [Create New Trigger](../../doc/controllers/usage-trigger-management.md#create-new-trigger)
* [Update Trigger](../../doc/controllers/usage-trigger-management.md#update-trigger)
* [Delete Trigger](../../doc/controllers/usage-trigger-management.md#delete-trigger)


# Create New Trigger

Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.

```csharp
CreateNewTriggerAsync(
    Models.UsageTriggerAddRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UsageTriggerAddRequest`](../../doc/models/usage-trigger-add-request.md) | Body, Optional | License assignment. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UsageTriggerResponse](../../doc/models/usage-trigger-response.md).

## Example Usage

```csharp
UsageTriggerAddRequest body = new UsageTriggerAddRequest
{
    AccountName = "0212312345-00001",
    ServiceName = ServiceName.Location,
    ThresholdValue = "95",
    TriggerName = "95% usage alert",
    AllowExcess = true,
    SendSmsNotification = true,
    SmsPhoneNumbers = "5551231234",
    SendEmailNotification = true,
    EmailAddresses = "you@theinternet.com",
};

try
{
    ApiResponse<UsageTriggerResponse> result = await usageTriggerManagementApi.CreateNewTriggerAsync(body);
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

```csharp
UpdateTriggerAsync(
    string triggerId,
    Models.UsageTriggerUpdateRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | Usage trigger ID |
| `body` | [`UsageTriggerUpdateRequest`](../../doc/models/usage-trigger-update-request.md) | Body, Optional | New trigger values |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UsageTriggerResponse](../../doc/models/usage-trigger-response.md).

## Example Usage

```csharp
string triggerId = "595f5c44-c31c-4552-8670-020a1545a84d";
UsageTriggerUpdateRequest body = new UsageTriggerUpdateRequest
{
    AccountName = "1000012345-00001",
    ThresholdValue = "95",
};

try
{
    ApiResponse<UsageTriggerResponse> result = await usageTriggerManagementApi.UpdateTriggerAsync(
        triggerId,
        body
    );
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

```csharp
DeleteTriggerAsync(
    string accountName,
    string triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account name |
| `triggerId` | `string` | Template, Required | Usage trigger ID |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```csharp
string accountName = "0212312345-00001";
string triggerId = "595f5c44-c31c-4552-8670-020a1545a84d";
try
{
    ApiResponse<DeviceLocationSuccessResult> result = await usageTriggerManagementApi.DeleteTriggerAsync(
        accountName,
        triggerId
    );
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

