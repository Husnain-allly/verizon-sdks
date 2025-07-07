# Sensor Insights Sensors

```ruby
sensor_insights_sensors_api = client.sensor_insights_sensors
```

## Class Name

`SensorInsightsSensorsApi`

## Methods

* [Sensor Insights List Sensor Devices Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-list-sensor-devices-request)
* [Sensor Insights on Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-on-board-sensor-request)
* [Sensor Insights Sensor on Board Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-on-board-status-request)
* [Sensor Insights Off Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-off-board-sensor-request)
* [Sensor Insights Sensor Off Boarding Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-off-boarding-status-request)


# Sensor Insights List Sensor Devices Request

```ruby
def sensor_insights_list_sensor_devices_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSensorDevicesRequest`](../../doc/models/dto-list-sensor-devices-request.md) | Body, Required | List details of the sensors |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<ResourceDevice>`](../../doc/models/resource-device.md).

## Example Usage

```ruby
body = DtoListSensorDevicesRequest.new(
  accountname: '0000123456-00001',
  filter: DtoFilter.new(
    m_expand: 'device detail(s)',
    m_limitnumber: 100,
    m_nopagination: true,
    m_page: 'The number of pages',
    m_pagenumber: 1,
    m_projection: [
      'specific device fields requested'
    ],
    m_selection: {
      'additionalProp1' => JSON.parse('"string"'),
      'additionalProp2' => JSON.parse('"string"'),
      'additionalProp3' => JSON.parse('"string"')
    }
  ),
  resourceidentifier: DtoDeviceResourceIdentifier.new(
    deveui: 'The unique EUI64 address of the device',
    deviceid: 'The UUID of the device',
    esn: 223372036854775800,
    iccid: 'The 20-digit Integrated Circuit Card ID (SIM card ID)',
    imei: 223372036854775,
    imsi: 223372036854775800,
    mac: 'The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX',
    manufacturer: 'REOLINK',
    meid: 'The 56-bit Mobile Equipment ID',
    msisdn: 'The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number',
    node_uuid: 'The UUID of the node the device is associated with',
    qrcode: 'The Quick Response (QR) code',
    serial: 'The device\'s serial number'
  )
)

result = sensor_insights_sensors_api.sensor_insights_list_sensor_devices_request(body)

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


# Sensor Insights on Board Sensor Request

```ruby
def sensor_insights_on_board_sensor_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOnBoardSensorRequest`](../../doc/models/dto-on-board-sensor-request.md) | Body, Required | Onboarding a sensor |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
body = DtoOnBoardSensorRequest.new(
  accountname: '0000123456-00001',
  payload: Payload.new(
    addsensor: ResourceOnBoardSensor.new(
      deveui: 'The unique EUI64 address of the device',
      appeui: 'global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame',
      appkey: 'Encryption key used for messages during every over the air activation',
      mclass: 'A',
      kind: 'ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US',
      description: 'used to identify water leaks',
      name: 'Water Leak sensor',
      customdata: {
        'additionalProp1' => JSON.parse('[100]'),
        'additionalProp2' => JSON.parse('[100]'),
        'additionalProp3' => JSON.parse('[100]')
      }
    )
  )
)

result = sensor_insights_sensors_api.sensor_insights_on_board_sensor_request(body)

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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Sensor on Board Status Request

```ruby
def sensor_insights_sensor_on_board_status_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOnBoardStatusRequest`](../../doc/models/dto-sensor-on-board-status-request.md) | Body, Required | Get the sensor's onboarding status |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DtoSensorOnBoardingStatusResponse`](../../doc/models/dto-sensor-on-boarding-status-response.md).

## Example Usage

```ruby
body = DtoSensorOnBoardStatusRequest.new(
  accountname: '0000123456-00001',
  gatewayidentifier: Gatewayidentifier.new(
    deviceid: '00000000-0000-0000-0000-000000000255'
  ),
  onboarding: Onboarding.new(
    additional_properties: {
      'sensoridentifiers' => JSON.parse('{"deveui":"The unique EUI64 address of the device"}')
    }
  )
)

result = sensor_insights_sensors_api.sensor_insights_sensor_on_board_status_request(body)

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


# Sensor Insights Off Board Sensor Request

```ruby
def sensor_insights_off_board_sensor_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOffBoardSensorRequest`](../../doc/models/dto-off-board-sensor-request.md) | Body, Required | Offboard a sensor |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
body = DtoOffBoardSensorRequest.new(
  accountname: '0000123456-00001',
  configuration: Sensorinsightsconfig.new(
    removesensor: DtoOffBoardSensor.new(
      deveui: 'The unique EUI64 address of the device'
    )
  )
)

result = sensor_insights_sensors_api.sensor_insights_off_board_sensor_request(body)

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


# Sensor Insights Sensor Off Boarding Status Request

```ruby
def sensor_insights_sensor_off_boarding_status_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOffBoardStatusRequest`](../../doc/models/dto-sensor-off-board-status-request.md) | Body, Required | Get a sensor's offboarding status |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DtoSensorOffBoardingStatusResponse`](../../doc/models/dto-sensor-off-boarding-status-response.md).

## Example Usage

```ruby
body = DtoSensorOffBoardStatusRequest.new(
  accountname: '0000123456-00001',
  gatewayidentifier: Gatewayidentifier.new(
    deviceid: 'UUID of the Gateway device'
  ),
  offboarding: Offboarding.new(
    additional_properties: {
      'sensoridentifiers' => JSON.parse('{"deveui":"The unique EUI64 address of the device"}')
    }
  )
)

result = sensor_insights_sensors_api.sensor_insights_sensor_off_boarding_status_request(body)

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

