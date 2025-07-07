# Sensor Insights Smart Alerts

```ruby
sensor_insights_smart_alerts_api = client.sensor_insights_smart_alerts
```

## Class Name

`SensorInsightsSmartAlertsApi`

## Methods

* [Sensor Insights List Smart Alerts Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-list-smart-alerts-request)
* [Sensor Insights Patch Smart Alert Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-patch-smart-alert-request)
* [Sensor Insights Bulk Update](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-bulk-update)


# Sensor Insights List Smart Alerts Request

```ruby
def sensor_insights_list_smart_alerts_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSmartAlertsRequest`](../../doc/models/dto-list-smart-alerts-request.md) | Body, Required | Retrieve a smart alert |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<UserSmartAlert>`](../../doc/models/user-smart-alert.md).

## Example Usage

```ruby
body = DtoListSmartAlertsRequest.new(
  accountname: '0000123456-00001',
  filter: DtoFilter.new(
    m_expand: 'device detail(s)',
    m_limitnumber: 100,
    m_nopagination: true,
    m_page: 'The number of pages',
    m_pagenumber: 100,
    m_projection: [
      'specific device fields requested'
    ],
    m_selection: {
      'additionalProp1' => JSON.parse('"string"'),
      'additionalProp2' => JSON.parse('"string"'),
      'additionalProp3' => JSON.parse('"string"')
    }
  ),
  resourceidentifier: DtoResourceidentifier.new(
    id: 'cb3eea68-eeee-ffff-gggg-ac4463ccd073'
  )
)

result = sensor_insights_smart_alerts_api.sensor_insights_list_smart_alerts_request(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Patch Smart Alert Request

```ruby
def sensor_insights_patch_smart_alert_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchSmartAlertRequest`](../../doc/models/dto-patch-smart-alert-request.md) | Body, Required | Partially update a smart alert |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`UserSmartAlert`](../../doc/models/user-smart-alert.md).

## Example Usage

```ruby
body = DtoPatchSmartAlertRequest.new(
  accountname: '0000123456-00001',
  resourceidentifier: DtoResourceidentifier.new(
    id: '0b37ab8b-eeee-ffff-gggg-e0149af43f43'
  ),
  smartalert: UserSmartAlert.new(
    createdon: DateTimeHelper.from_rfc3339('2023-10-02T15:46:34.562Z'),
    lastupdated: DateTimeHelper.from_rfc3339('2023-10-02T15:46:34.562Z'),
    versionid: '337bd2e8-eeee-ffff-gggg-5207992fd395',
    accountclientid: 'null',
    billingaccountid: '0000123456-00001',
    category: 'telemetry',
    condition: 2592000,
    description: 'a short description',
    deviceid: 'The UUID of the device',
    foreignid: 'c1f178d3-eeee-ffff-gggg-0d6b7ae6022a',
    id: 'fecbe450-eeee-ffff-gggg-aa166fd5f8e3',
    isacknowledged: true,
    iscleared: true,
    isdisabled: false,
    name: 'User defined name of the record',
    ruleid: 'The UUID of a rule',
    severity: 'minor',
    state: 'success',
    template: 'The template ID',
    version: '1.0'
  )
)

result = sensor_insights_smart_alerts_api.sensor_insights_patch_smart_alert_request(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Bulk Update

```ruby
def sensor_insights_bulk_update(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoBulkUpdate`](../../doc/models/dto-bulk-update.md) | Body, Required | Bulk update smart alerts |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`UserSmartAlert`](../../doc/models/user-smart-alert.md).

## Example Usage

```ruby
body = DtoBulkUpdate.new(
  accountname: '0000123456-00001',
  resourceidentifiers: [
    TheIDresourceandDeviceId.new(
      id: 'ee70a869-eeee-ffff-gggg-07c14c31f96e'
    ),
    TheIDresourceandDeviceId.new(
      deviceid: 'The UUID of the device'
    )
  ],
  smartalert: BulkUpdateSmartalert.new(
    name: 'User defined name of the record'
  )
)

result = sensor_insights_smart_alerts_api.sensor_insights_bulk_update(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

