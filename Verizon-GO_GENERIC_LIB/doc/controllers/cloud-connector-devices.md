# Cloud Connector Devices

```go
cloudConnectorDevicesApi := client.CloudConnectorDevicesApi()
```

## Class Name

`CloudConnectorDevicesApi`

## Methods

* [Update Devices Configuration Value](../../doc/controllers/cloud-connector-devices.md#update-devices-configuration-value)
* [Find Device by Property Values](../../doc/controllers/cloud-connector-devices.md#find-device-by-property-values)
* [Search Devices Resources by Property Values](../../doc/controllers/cloud-connector-devices.md#search-devices-resources-by-property-values)
* [Search Device Event History](../../doc/controllers/cloud-connector-devices.md#search-device-event-history)
* [Search Sensor Readings](../../doc/controllers/cloud-connector-devices.md#search-sensor-readings)
* [Delete Device From Account](../../doc/controllers/cloud-connector-devices.md#delete-device-from-account)


# Update Devices Configuration Value

Change configuration values on a device, such as setting how often a device records and reports sensor readings.

```go
UpdateDevicesConfigurationValue(
    ctx context.Context,
    body models.ChangeConfigurationRequest) (
    models.ApiResponse[models.ChangeConfigurationResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ChangeConfigurationRequest`](../../doc/models/change-configuration-request.md) | Body, Required | The request body changes configuration values on a device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ChangeConfigurationResponse](../../doc/models/change-configuration-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ChangeConfigurationRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    }),
    Resourceidentifier:    models.ToPointer(models.ResourceIdentifier{
        Imei:                  models.ToPointer("864508030147323"),
    }),
    Configuration:         models.ToPointer(models.Configuration{
        Frequency:             models.ToPointer("Low"),
    }),
}

apiResponse, err := cloudConnectorDevicesApi.UpdateDevicesConfigurationValue(ctx, body)
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
  "action": "set",
  "createdon": "2019-02-14T01:41:03.619217664Z",
  "deviceid": "8461f530-2e31-6e87-e357-6c38251d4d01",
  "fields": {
    "configuration": {
      "frequency": "Low"
    }
  },
  "foreignid": "e1f15861-7de7-69cb-ed7d-b4a92e091bc4",
  "id": "05c12adc-50c0-6ebb-feb0-b9f9637a1dba",
  "kind": "ts.event.configuration",
  "lastupdated": "2019-02-14T01:41:03.619217727Z",
  "name": "SetConfigurationReq",
  "state": "pending",
  "transactionid": "1d38aae7-558d-4cb9-8269-e8d4c0519045",
  "version": "1.0"
}
```


# Find Device by Property Values

Find devices by property values. Returns an array of all matching device resources.

```go
FindDeviceByPropertyValues(
    ctx context.Context,
    body models.QuerySubscriptionRequest) (
    models.ApiResponse[models.FindDeviceByPropertyResponseList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.QuerySubscriptionRequest`](../../doc/models/query-subscription-request.md) | Body, Required | The request body specifies fields and values to match. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FindDeviceByPropertyResponseList](../../doc/models/find-device-by-property-response-list.md).

## Example Usage

```go
ctx := context.Background()

body := models.QuerySubscriptionRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    }),
    Resourceidentifier:    models.ToPointer(models.ResourceIdentifier{
        Imei:                  models.ToPointer("159495694333703"),
    }),
}

apiResponse, err := cloudConnectorDevicesApi.FindDeviceByPropertyValues(ctx, body)
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
  "DeviceProperty": [
    {
      "billingaccountid": "1223334444-00001",
      "createdon": "2018-12-19T06:45:41.496Z",
      "eventretention": "90",
      "iccid": "20332350053095597842",
      "id": "64612cb3-3685-6dad-fd2b-ea1adeb5a269",
      "imei": "320778042285497",
      "kind": "ts.device",
      "lastupdated": "2018-12-19T06:45:41.508Z",
      "providerid": "8a314f07-849e-6568-e3c1-8381c1f61bfc",
      "refid": "20332350053095597842",
      "refidtype": "iccid",
      "state": "registered",
      "version": "1.0",
      "versionid": "b3cdaddb-0359-11e9-aba2-02420a4e1b0a"
    },
    {
      "billingaccountid": "1223334444-00001",
      "createdon": "2018-12-20T18:42:23.548Z",
      "eventretention": "90",
      "iccid": "89148000004197486411",
      "id": "0481cf95-e3b1-63eb-eb18-43bf717156cb",
      "imei": "864508030147323",
      "kind": "ts.device.cHeAssetTracker",
      "lastupdated": "2018-12-20T18:42:23.688Z",
      "providerid": "9dfcfa69-a1c8-4eae-8611-b282646bb113",
      "refid": "864508030147323",
      "refidtype": "imei",
      "state": "ready",
      "version": "1.0",
      "versionid": "fd835cc9-0486-11e9-a7da-02420a481608"
    }
  ]
}
```


# Search Devices Resources by Property Values

Search for devices by property values. Returns an array of all matching device resources.

```go
SearchDevicesResourcesByPropertyValues(
    ctx context.Context,
    body models.QuerySubscriptionRequest) (
    models.ApiResponse[models.SearchDeviceByPropertyResponseList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.QuerySubscriptionRequest`](../../doc/models/query-subscription-request.md) | Body, Required | The request body specifies fields and values to match. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SearchDeviceByPropertyResponseList](../../doc/models/search-device-by-property-response-list.md).

## Example Usage

```go
ctx := context.Background()

body := models.QuerySubscriptionRequest{
    Accountidentifier:     models.ToPointer(models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    }),
    MSelection:            map[string]string{
        "iccid": "89148000003499233389",
    },
}

apiResponse, err := cloudConnectorDevicesApi.SearchDevicesResourcesByPropertyValues(ctx, body)
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
  "DeviceProperty": [
    {
      "billingaccountid": "1223334444-00001",
      "createdon": "2018-12-19T06:45:41.496Z",
      "eventretention": "90",
      "iccid": "20332350053095597842",
      "id": "64612cb3-3685-6dad-fd2b-ea1adeb5a269",
      "imei": "320778042285497",
      "kind": "ts.device",
      "lastupdated": "2018-12-19T06:45:41.508Z",
      "providerid": "8a314f07-849e-6568-e3c1-8381c1f61bfc",
      "refid": "20332350053095597842",
      "refidtype": "iccid",
      "state": "registered",
      "version": "1.0",
      "versionid": "b3cdaddb-0359-11e9-aba2-02420a4e1b0a"
    }
  ]
}
```


# Search Device Event History

Search device event history to find events that match criteria.Sensor readings, configuration changes, and other device data are all stored as events.

```go
SearchDeviceEventHistory(
    ctx context.Context,
    body models.SearchDeviceEventHistoryRequest) (
    models.ApiResponse[models.SearchDeviceEventHistoryResponseList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SearchDeviceEventHistoryRequest`](../../doc/models/search-device-event-history-request.md) | Body, Required | The device identifier and fields to match in the search. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SearchDeviceEventHistoryResponseList](../../doc/models/search-device-event-history-response-list.md).

## Example Usage

```go
ctx := context.Background()

body := models.SearchDeviceEventHistoryRequest{
    Accountidentifier:     models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    },
    MSelection:            map[string]string{
        "kind": "ts.event.configuration",
    },
    Resourceidentifier:    models.ResourceIdentifier{
        Imei:                  models.ToPointer("864508030084997"),
    },
    MLimitnumber:          models.ToPointer(2),
}

apiResponse, err := cloudConnectorDevicesApi.SearchDeviceEventHistory(ctx, body)
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
  "SearchDeviceEventHistory": [
    {
      "action": "set",
      "createdon": "2019-02-21T02:05:25.270417481Z",
      "deviceid": "8461f530-2e31-6e87-e357-6c38251d4d01",
      "id": "e521b8ae-440d-6cc1-f687-7c80e085ff29",
      "kind": "ts.event.configuration",
      "lastupdated": "2019-02-21T02:05:25.394230017Z",
      "name": "SetConfigurationReq",
      "state": "update",
      "tagids": [
        "4d110e4f-7a7c-6b26-eaac-31cc34c6e1d4",
        "cd81ed16-18ae-6c7d-eaba-2883b0395387"
      ],
      "transactionid": "c7a0a8cf-6856-4733-93ea-69913650e4ca",
      "version": "1.0",
      "versionid": "270e4820-357d-11e9-9d6c-02420a470c06"
    },
    {
      "action": "set",
      "createdon": "2019-02-21T01:58:45.163Z",
      "deviceid": "8461f530-2e31-6e87-e357-6c38251d4d01",
      "id": "25819e96-c4f2-6545-fb68-0e1d9662359f",
      "kind": "ts.event.configuration",
      "lastupdated": "2019-02-21T01:58:45.163Z",
      "state": "pending",
      "tagids": [
        "4d110e4f-7a7c-6b26-eaac-31cc34c6e1d4",
        "cd81ed16-18ae-6c7d-eaba-2883b0395387"
      ],
      "transactionid": "c7a0a8cf-6856-4733-93ea-69913650e4ca",
      "version": "1.0",
      "versionid": "387fe2fe-357c-11e9-ae40-02420a49140a"
    }
  ]
}
```


# Search Sensor Readings

Returns the readings of a specified sensor, with the most recent reading first. Sensor readings are stored as events; this request an array of events.

```go
SearchSensorReadings(
    ctx context.Context,
    fieldname string,
    body models.SearchSensorHistoryRequest) (
    models.ApiResponse[models.SearchSensorHistoryResponseList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `fieldname` | `string` | Template, Required | The name of the sensor. |
| `body` | [`models.SearchSensorHistoryRequest`](../../doc/models/search-sensor-history-request.md) | Body, Required | The device identifier and fields to match in the search. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SearchSensorHistoryResponseList](../../doc/models/search-sensor-history-response-list.md).

## Example Usage

```go
ctx := context.Background()

fieldname := "fieldname8"

body := models.SearchSensorHistoryRequest{
    Accountidentifier:     models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    },
    Resourceidentifier:    models.ResourceIdentifier{
        Imei:                  models.ToPointer("864508030084997"),
    },
    MLimitnumber:          models.ToPointer(2),
}

apiResponse, err := cloudConnectorDevicesApi.SearchSensorReadings(ctx, fieldname, body)
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
  "SearchSensorHistory": [
    {
      "action": "update",
      "createdon": "2019-02-22T04:05:26Z",
      "deviceid": "8461f530-2e31-6e87-e357-6c38251d4d01",
      "fields": {
        "temperature": "18.4"
      },
      "id": "4521b7a7-7de1-6e68-f020-1345ef3b764a",
      "kind": "ts.event",
      "lastupdated": "2019-02-22T04:05:49.786Z",
      "state": "update",
      "tagids": [
        "4d110e4f-7a7c-6b26-eaac-31cc34c6e1d4",
        "cd81ed16-18ae-6c7d-eaba-2883b0395387"
      ],
      "transactionid": "864508030084997-OnBoard-c05f946c-3f5c-4527-b4d0-5aca256fc3dd",
      "version": "1.0",
      "versionid": "238addb9-3657-11e9-8848-02420a951f13"
    },
    {
      "action": "update",
      "createdon": "2019-02-22T03:05:26Z",
      "deviceid": "8461f530-2e31-6e87-e357-6c38251d4d01",
      "fields": {
        "temperature": "19.0"
      },
      "id": "05b1ea7b-4bf2-6af6-ea8b-414595f2c3e9",
      "kind": "ts.event",
      "lastupdated": "2019-02-22T03:05:48.483Z",
      "state": "update",
      "tagids": [
        "4d110e4f-7a7c-6b26-eaac-31cc34c6e1d4",
        "cd81ed16-18ae-6c7d-eaba-2883b0395387"
      ],
      "transactionid": "864508030084997-OnBoard-5f71f47d-4464-4f69-a3ee-5c243f0ef5b8",
      "version": "1.0",
      "versionid": "c0ffa4b5-364e-11e9-a3ee-02420a8c0d14"
    }
  ]
}
```


# Delete Device From Account

Remove a device from a ThingSpace account.

```go
DeleteDeviceFromAccount(
    ctx context.Context,
    body models.RemoveDeviceRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.RemoveDeviceRequest`](../../doc/models/remove-device-request.md) | Body, Required | The request body identifies the device to delete. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

body := models.RemoveDeviceRequest{
    Accountidentifier:     models.AccountIdentifier{
        Billingaccountid:      models.ToPointer("1223334444-00001"),
    },
    Resourceidentifier:    models.ResourceIdentifier{
        Imei:                  models.ToPointer("864508030084997"),
    },
}

resp, err := cloudConnectorDevicesApi.DeleteDeviceFromAccount(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
}
```

