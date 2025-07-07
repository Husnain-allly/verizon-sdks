# Sensor Insights Users

```python
sensor_insights_users_api = client.sensor_insights_users
```

## Class Name

`SensorInsightsUsersApi`

## Methods

* [Sensor Insights Create User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-create-user-request)
* [Sensor Insights Delete User](../../doc/controllers/sensor-insights-users.md#sensor-insights-delete-user)
* [Sensor Insights Update User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-update-user-request)
* [Sensor Insights List User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-list-user-request)


# Sensor Insights Create User Request

```python
def sensor_insights_create_user_request(self,
                                       body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateUserRequest`](../../doc/models/dto-create-user-request.md) | Body, Required | Create a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`ResourceUser`](../../doc/models/resource-user.md).

## Example Usage

```python
body = DtoCreateUserRequest(
    accountname='0000123456-00001',
    user=DtoUserDto(
        email='email@domain.com',
        firstname='First name',
        lastname='Last name or Surname',
        mdn='908-555-1234',
        customdata={
            'additionalProp1': jsonpickle.decode('[100]'),
            'additionalProp2': jsonpickle.decode('[100]'),
            'additionalProp3': jsonpickle.decode('[100]')
        }
    )
)

result = sensor_insights_users_api.sensor_insights_create_user_request(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
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


# Sensor Insights Delete User

```python
def sensor_insights_delete_user(self,
                               deleterequestpayload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequestpayload` | [`DtoDeleteUserRequest`](../../doc/models/dto-delete-user-request.md) | Query, Required | Payload for the delete user request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```python
deleterequestpayload = DtoDeleteUserRequest(
    accountname='0000123456-00001',
    id='8ea30999-eeee-ffff-gggg-3ea409f5fee4'
)

result = sensor_insights_users_api.sensor_insights_delete_user(deleterequestpayload)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Update User Request

```python
def sensor_insights_update_user_request(self,
                                       body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateUserRequest`](../../doc/models/dto-update-user-request.md) | Body, Required | Partially update a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`ResourceUser`](../../doc/models/resource-user.md).

## Example Usage

```python
body = DtoUpdateUserRequest(
    accountname='0000123456-00001',
    id='9dd573ba-eeee-ffff-gggg-8009758bcaca',
    user=DtoUserDto(
        email='email@domain.com',
        firstname='First name',
        lastname='Last name or Surname',
        mdn='908-555-1234',
        customdata={
            'additionalProp1': jsonpickle.decode('[100]'),
            'additionalProp2': jsonpickle.decode('[100]'),
            'additionalProp3': jsonpickle.decode('[100]')
        }
    )
)

result = sensor_insights_users_api.sensor_insights_update_user_request(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
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


# Sensor Insights List User Request

```python
def sensor_insights_list_user_request(self,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListUserRequest`](../../doc/models/dto-list-user-request.md) | Body, Required | A summary of user profile records on an account |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[ResourceUser]`](../../doc/models/resource-user.md).

## Example Usage

```python
body = DtoListUserRequest(
    accountname='0000123456-00001',
    filter=DtoFilter(
        m_expand='device detail(s)',
        m_limitnumber=100,
        m_nopagination=True,
        m_page='The number of pages',
        m_pagenumber=100,
        m_projection=[
            'specific device fields requested'
        ],
        m_selection={
            'additionalProp1': jsonpickle.decode('"string"'),
            'additionalProp2': jsonpickle.decode('"string"'),
            'additionalProp3': jsonpickle.decode('"string"')
        }
    )
)

result = sensor_insights_users_api.sensor_insights_list_user_request(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
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

