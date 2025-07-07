# App Config Service

```ts
const appConfigServiceApi = new AppConfigServiceApi(client);
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

```ts
async getConfigurationList(
  vendorId: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<ConfigurationListItem[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ConfigurationListItem[]](../../doc/models/configuration-list-item.md).

## Example Usage

```ts
const vendorId = 'VerizonETX';

try {
  const { result, ...httpResponse } = await appConfigServiceApi.getConfigurationList(vendorId);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 404 | Configuration not found | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 429 | Too many requests | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| Default | unexpected error | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |


# Get Configuration

This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ts
async getConfiguration(
  id: string,
  vendorId: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GeoFenceConfigurationResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GeoFenceConfigurationResponse](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```ts
const id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713';

const vendorId = 'VerizonETX';

try {
  const { result, ...httpResponse } = await appConfigServiceApi.getConfiguration(
  id,
  vendorId
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 404 | Configuration not found | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 429 | Too many requests | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| Default | unexpected error | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |


# Create Configuration

This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ts
async createConfiguration(
  vendorId: string,
  body: GeoFenceConfigurationRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GeoFenceConfigurationResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`GeoFenceConfigurationRequest`](../../doc/models/geo-fence-configuration-request.md) | Body, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GeoFenceConfigurationResponse](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```ts
const vendorId = 'VerizonETX';

const body: GeoFenceConfigurationRequest = {
  geoFence: {
    type: FeatureCollectionType.FeatureCollection,
    features: [
      {
        type: FeatureType.Feature,
        geometry: { 'key1': 'val1', 'key2': 'val2' },
        properties: { 'key1': 'val1', 'key2': 'val2' },
      }
    ],
  },
  messages: [
    { 'key1': 'val1', 'key2': 'val2' }
  ],
  isActive: false,
};

try {
  const { result, ...httpResponse } = await appConfigServiceApi.createConfiguration(
  vendorId,
  body
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 403 | Forbidden | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 429 | Too many requests | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| Default | unexpected error | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |


# Update Configuration

This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ts
async updateConfiguration(
  vendorId: string,
  id: string,
  body: GeoFenceConfigurationUpdateRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `body` | [`GeoFenceConfigurationUpdateRequest`](../../doc/models/geo-fence-configuration-update-request.md) | Body, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const vendorId = 'VerizonETX';

const id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713';

const body: GeoFenceConfigurationUpdateRequest = {
};

try {
  const { result, ...httpResponse } = await appConfigServiceApi.updateConfiguration(
  vendorId,
  id,
  body
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 403 | Forbidden | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 404 | Configuration not found | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 429 | Too many requests | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| Default | unexpected error | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |


# Delete Configuration

This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ts
async deleteConfiguration(
  vendorId: string,
  id: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const vendorId = 'VerizonETX';

const id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713';

try {
  const { result, ...httpResponse } = await appConfigServiceApi.deleteConfiguration(
  vendorId,
  id
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| 429 | Too many requests | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |
| Default | unexpected error | [`AppConfigResponseError`](../../doc/models/app-config-response-error.md) |

