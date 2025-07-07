# App Config Service

```java
AppConfigServiceApi appConfigServiceApi = client.getAppConfigServiceApi();
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

```java
CompletableFuture<ApiResponse<List<ConfigurationListItem>>> getConfigurationListAsync(
    final String vendorId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<ConfigurationListItem>`](../../doc/models/configuration-list-item.md).

## Example Usage

```java
String vendorId = "VerizonETX";

appConfigServiceApi.getConfigurationListAsync(vendorId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<GeoFenceConfigurationResponse>> getConfigurationAsync(
    final String id,
    final String vendorId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `vendorId` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`GeoFenceConfigurationResponse`](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```java
String id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713";
String vendorId = "VerizonETX";

appConfigServiceApi.getConfigurationAsync(id, vendorId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<GeoFenceConfigurationResponse>> createConfigurationAsync(
    final String vendorId,
    final GeoFenceConfigurationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`GeoFenceConfigurationRequest`](../../doc/models/geo-fence-configuration-request.md) | Body, Required | - |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`GeoFenceConfigurationResponse`](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```java
String vendorId = "VerizonETX";
GeoFenceConfigurationRequest body = new GeoFenceConfigurationRequest.Builder(
    new EtxGeofence.Builder(
        FeatureCollectionType.FEATURECOLLECTION,
        Arrays.asList(
            new GeoFeature.Builder(
                FeatureType.FEATURE,
                Geometry.fromLineString(
                    new LineString.Builder(
                        LineStringType.LINESTRING,
                        Arrays.asList(
                            Arrays.asList(
                                51.53D,
                                51.54D
                            ),
                            Arrays.asList(
                                51.53D,
                                51.54D
                            )
                        )
                    )
                    .build()
                ),
                ApiHelper.deserialize("{\"key1\":\"val1\",\"key2\":\"val2\"}")
            )
            .build()
        )
    )
    .build(),
    Arrays.asList(
        Message3.fromMessage(
            new Message.Builder(
                false,
                Arrays.asList(
                    RoadUserTypes.VULNERABLEROADUSER
                ),
                Arrays.asList(
                    TriggerCondition.CROSSING
                ),
                new Generic.Builder(
                    "messageType4",
                    "messageFormat6",
                    "payload0"
                )
                .build()
            )
            .build()
        )
    ),
    false
)
.build();

appConfigServiceApi.createConfigurationAsync(vendorId, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<Void>> updateConfigurationAsync(
    final String vendorId,
    final String id,
    final GeoFenceConfigurationUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `String` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `body` | [`GeoFenceConfigurationUpdateRequest`](../../doc/models/geo-fence-configuration-update-request.md) | Body, Required | - |

## Server

`Server.IMP_SERVER`

## Response Type

`void`

## Example Usage

```java
String vendorId = "VerizonETX";
String id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713";
GeoFenceConfigurationUpdateRequest body = new GeoFenceConfigurationUpdateRequest.Builder()
    .build();

appConfigServiceApi.updateConfigurationAsync(vendorId, id, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<Void>> deleteConfigurationAsync(
    final String vendorId,
    final String id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `String` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `String` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |

## Server

`Server.IMP_SERVER`

## Response Type

`void`

## Example Usage

```java
String vendorId = "VerizonETX";
String id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713";

appConfigServiceApi.deleteConfigurationAsync(vendorId, id).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |

