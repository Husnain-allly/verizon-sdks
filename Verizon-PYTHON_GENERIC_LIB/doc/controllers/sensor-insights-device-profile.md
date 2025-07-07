# Sensor Insights Device Profile

```python
sensor_insights_device_profile_api = client.sensor_insights_device_profile
```

## Class Name

`SensorInsightsDeviceProfileApi`

## Methods

* [Create a Profile](../../doc/controllers/sensor-insights-device-profile.md#create-a-profile)
* [Delete a Profile](../../doc/controllers/sensor-insights-device-profile.md#delete-a-profile)
* [Update a Profile](../../doc/controllers/sensor-insights-device-profile.md#update-a-profile)
* [Query a Profile](../../doc/controllers/sensor-insights-device-profile.md#query-a-profile)


# Create a Profile

Create a device profile

```python
def create_a_profile(self,
                    body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfile`](../../doc/models/dto-configuration-profile.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[DtoProfileResponse]`](../../doc/models/dto-profile-response.md).

## Example Usage

```python
body = DtoConfigurationProfile(
    additional_properties=None,
    accountname='0000123456-00001',
    profiles=[
        DtoProfile(
            additional_properties=None,
            kind='the kind of profile being created',
            version='1.0',
            modelid='00000000-0000-0000-0000-000000000019',
            name='Demo Entry sensor 1730928792',
            configuration={"randomInt":21,"resportingInterval":24}
        )
    ]
)

result = sensor_insights_device_profile_api.create_a_profile(body)

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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Delete a Profile

Delete a device profile

```python
def delete_a_profile(self,
                    deleterequest)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequest` | [`DtoConfigurationProfileDelete`](../../doc/models/dto-configuration-profile-delete.md) | Header, Required | payload for the delete request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[DtoProfileResponse]`](../../doc/models/dto-profile-response.md).

## Example Usage

```python
deleterequest = DtoConfigurationProfileDelete(
    additional_properties=None,
    account_name='0000123456-00001'
)

result = sensor_insights_device_profile_api.delete_a_profile(deleterequest)

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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Update a Profile

Partially update a device profile

```python
def update_a_profile(self,
                    body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfilePath`](../../doc/models/dto-configuration-profile-path.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[DtoProfileResponse]`](../../doc/models/dto-profile-response.md).

## Example Usage

```python
body = DtoConfigurationProfilePath(
    additional_properties={
        'accountname': jsonpickle.decode('"0000123456-00001"'),
        'profiles': jsonpickle.decode('[{"kind":"the kind of profile being created","version":"1.0","modelid":"00000000-0000-0000-0000-000000000019","name":"Demo Entry sensor 1730928792","configuration":{"randomInt":21,"resportingInterval":24}}]')
    }
)

result = sensor_insights_device_profile_api.update_a_profile(body)

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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Query a Profile

Query a device profile for an individual device

```python
def query_a_profile(self,
                   body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourceResourceQuery`](../../doc/models/resource-resource-query.md) | Body, Required | body |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[DtoProfileResponse]`](../../doc/models/dto-profile-response.md).

## Example Usage

```python
body = ResourceResourceQuery(
    filter=Devicepropertyfilter(
        additional_properties=None,
        m_selection=Devicepropertyselection(
            additional_properties=None,
            modelid='00000000-0000-0000-0000-000000000019'
        ),
        m_querytotalcount=True
    )
)

result = sensor_insights_device_profile_api.query_a_profile(body)

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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

