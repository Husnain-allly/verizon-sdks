# App Config Service

```ruby
app_config_service_api = client.app_config_service
```

## Class Name

`AppConfigServiceApi`

## Methods

* [Get Configuration List](../../doc/controllers/app-config-service.md#get-configuration-list)
* [Get Configuration](../../doc/controllers/app-config-service.md#get-configuration)
* [Create Configuration](../../doc/controllers/app-config-service.md#create-configuration)
* [Update Configuration](../../doc/controllers/app-config-service.md#update-configuration)
* [Delete Configuration](../../doc/controllers/app-config-service.md#delete-configuration)


# Get Configuration List

This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ruby
def get_configuration_list(vendor_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendor_id` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Server

`Server::IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<ConfigurationListItem>`](../../doc/models/configuration-list-item.md).

## Example Usage

```ruby
vendor_id = 'VerizonETX'

result = app_config_service_api.get_configuration_list(vendor_id)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 404 | Configuration not found | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Get Configuration

This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ruby
def get_configuration(id,
                      vendor_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `vendor_id` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Server

`Server::IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GeoFenceConfigurationResponse`](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```ruby
id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713'

vendor_id = 'VerizonETX'

result = app_config_service_api.get_configuration(
  id,
  vendor_id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 404 | Configuration not found | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Create Configuration

This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ruby
def create_configuration(vendor_id,
                         body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendor_id` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`GeoFenceConfigurationRequest`](../../doc/models/geo-fence-configuration-request.md) | Body, Required | - |

## Server

`Server::IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GeoFenceConfigurationResponse`](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```ruby
vendor_id = 'VerizonETX'

body = GeoFenceConfigurationRequest.new(
  geo_fence: EtxGeofence.new(
    type: FeatureCollectionType::FEATURECOLLECTION,
    features: [
      GeoFeature.new(
        type: FeatureType::FEATURE,
        geometry: JSON.parse('{"key1":"val1","key2":"val2"}'),
        properties: { 'key1' => 'val1', 'key2' => 'val2' }
      )
    ]
  ),
  messages: [
    JSON.parse('{"key1":"val1","key2":"val2"}')
  ],
  is_active: false
)

result = app_config_service_api.create_configuration(
  vendor_id,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Update Configuration

This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ruby
def update_configuration(vendor_id,
                         id,
                         body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendor_id` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `String` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `body` | [`GeoFenceConfigurationUpdateRequest`](../../doc/models/geo-fence-configuration-update-request.md) | Body, Required | - |

## Server

`Server::IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
vendor_id = 'VerizonETX'

id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713'

body = GeoFenceConfigurationUpdateRequest.new

result = app_config_service_api.update_configuration(
  vendor_id,
  id,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 404 | Configuration not found | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Delete Configuration

This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ruby
def delete_configuration(vendor_id,
                         id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendor_id` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `String` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |

## Server

`Server::IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
vendor_id = 'VerizonETX'

id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713'

result = app_config_service_api.delete_configuration(
  vendor_id,
  id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |

