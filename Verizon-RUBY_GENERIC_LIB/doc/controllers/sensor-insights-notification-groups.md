# Sensor Insights Notification Groups

```ruby
sensor_insights_notification_groups_api = client.sensor_insights_notification_groups
```

## Class Name

`SensorInsightsNotificationGroupsApi`

## Methods

* [Sensor Insights List Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-list-notification-group-request)
* [Sensor Insights Update Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-update-notification-group-request)
* [Sensor Insights Create Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-create-notification-group-request)
* [Sensor Insights Delete Notification Group](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-delete-notification-group)
* [Sensor Insights Add Users to Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-add-users-to-notification-group-request)
* [Sensor Insights Remove Users From Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-remove-users-from-notification-group-request)


# Sensor Insights List Notification Group Request

```ruby
def sensor_insights_list_notification_group_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNotificationGroupRequest`](../../doc/models/dto-list-notification-group-request.md) | Body, Required | Retrieve a notification group |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<DtoNotificationGroupResponseEntity>`](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```ruby
body = DtoListNotificationGroupRequest.new(
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
  )
)

result = sensor_insights_notification_groups_api.sensor_insights_list_notification_group_request(body)

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


# Sensor Insights Update Notification Group Request

```ruby
def sensor_insights_update_notification_group_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateNotificationGroupRequest`](../../doc/models/dto-update-notification-group-request.md) | Body, Required | Partially update a notification group |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DtoNotificationGroupResponseEntity`](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```ruby
body = DtoUpdateNotificationGroupRequest.new(
  group: DtoNotificationGroupRequestEntity.new(
    description: 'a short description',
    groupemail: 'email@domain.com',
    name: 'User defined name of the record'
  ),
  accountname: '0000123456-00001',
  id: '7b0b9c53-eeee-ffff-gggg-bde5e44f4b12',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ]
)

result = sensor_insights_notification_groups_api.sensor_insights_update_notification_group_request(body)

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


# Sensor Insights Create Notification Group Request

```ruby
def sensor_insights_create_notification_group_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateNotificationGroupRequest`](../../doc/models/dto-create-notification-group-request.md) | Body, Required | Create a notification group |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DtoNotificationGroupResponseEntity`](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```ruby
body = DtoCreateNotificationGroupRequest.new(
  group: DtoNotificationGroupRequestEntity.new(
    description: 'a short description',
    groupemail: 'email@domain.com',
    name: 'User defined name of the record'
  ),
  accountname: '0000123456-00001',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ]
)

result = sensor_insights_notification_groups_api.sensor_insights_create_notification_group_request(body)

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


# Sensor Insights Delete Notification Group

```ruby
def sensor_insights_delete_notification_group(payload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payload` | [`DtoDeleteNotificationGroupRequest`](../../doc/models/dto-delete-notification-group-request.md) | Query, Required | Payload for the delete request. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
payload = DtoDeleteNotificationGroupRequest.new(
  accountname: '0000123456-00001',
  force: true,
  id: '6737ca22-eeee-ffff-gggg-84c09f2ede8e'
)

result = sensor_insights_notification_groups_api.sensor_insights_delete_notification_group(payload)

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


# Sensor Insights Add Users to Notification Group Request

```ruby
def sensor_insights_add_users_to_notification_group_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoAddUsersToNotificationGroupRequest`](../../doc/models/dto-add-users-to-notification-group-request.md) | Body, Required | Add users to a notification group |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
body = DtoAddUsersToNotificationGroupRequest.new(
  accountname: '0000123456-00001',
  id: '45f1a56e-eeee-ffff-gggg-68cb994feb5f',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ]
)

result = sensor_insights_notification_groups_api.sensor_insights_add_users_to_notification_group_request(body)

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


# Sensor Insights Remove Users From Notification Group Request

```ruby
def sensor_insights_remove_users_from_notification_group_request(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoRemoveUsersFromNotificationGroupRequest`](../../doc/models/dto-remove-users-from-notification-group-request.md) | Body, Required | Remove users from a notification group |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
body = DtoRemoveUsersFromNotificationGroupRequest.new(
  accountname: '0000123456-00001',
  id: '111538a8-eeee-ffff-gggg-3b72804403e8',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ]
)

result = sensor_insights_notification_groups_api.sensor_insights_remove_users_from_notification_group_request(body)

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

