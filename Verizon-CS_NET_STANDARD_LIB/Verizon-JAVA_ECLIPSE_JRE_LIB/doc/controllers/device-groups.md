# Device Groups

```java
DeviceGroupsApi deviceGroupsApi = client.getDeviceGroupsApi();
```

## Class Name

`DeviceGroupsApi`

## Methods

* [Create Device Group](../../doc/controllers/device-groups.md#create-device-group)
* [List Device Groups](../../doc/controllers/device-groups.md#list-device-groups)
* [Get Device Group Information](../../doc/controllers/device-groups.md#get-device-group-information)
* [Update Device Group](../../doc/controllers/device-groups.md#update-device-group)
* [Delete Device Group](../../doc/controllers/device-groups.md#delete-device-group)


# Create Device Group

Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.

```java
CompletableFuture<ApiResponse<ConnectivityManagementSuccessResult>> createDeviceGroupAsync(
    final CreateDeviceGroupRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateDeviceGroupRequest`](../../doc/models/create-device-group-request.md) | Body, Required | A request to create a new device group. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ConnectivityManagementSuccessResult`](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```java
CreateDeviceGroupRequest body = new CreateDeviceGroupRequest.Builder(
    "0000123456-00001",
    "descriptive string",
    "group name"
)
.devicesToAdd(Arrays.asList(
        new DeviceId.Builder(
            "15-digit IMEI",
            "imei"
        )
        .build()
    ))
.build();

deviceGroupsApi.createDeviceGroupAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Device Groups

Returns a list of all device groups in a specified account.

```java
CompletableFuture<ApiResponse<List<DeviceGroup>>> listDeviceGroupsAsync(
    final String aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DeviceGroup>`](../../doc/models/device-group.md).

## Example Usage

```java
String aname = "0252012345-00001";

deviceGroupsApi.listDeviceGroupsAsync(aname).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
[
  {
    "name": "Unassigned Devices",
    "description": "All devices that are not in another device group.",
    "isDefaultGroup": true,
    "extendedAttributes": []
  },
  {
    "name": "West Coast Devices",
    "description": "",
    "isDefaultGroup": false,
    "extendedAttributes": []
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Get Device Group Information

When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.

```java
CompletableFuture<ApiResponse<DeviceGroupDevicesData>> getDeviceGroupInformationAsync(
    final String aname,
    final String gname,
    final Long next)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |
| `gname` | `String` | Template, Required | Group name. |
| `next` | `Long` | Query, Optional | Continue the previous query from the pageUrl pagetoken. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceGroupDevicesData`](../../doc/models/device-group-devices-data.md).

## Example Usage

```java
String aname = "0252012345-00001";
String gname = "gname2";

deviceGroupsApi.getDeviceGroupInformationAsync(aname, gname, null).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "name": "Nebraska Trucks",
  "description": "All service trucks in Nebraska.",
  "hasMoreData": false,
  "devices": [
    {
      "deviceIds": [
        {
          "id": "12345",
          "kind": "meid"
        },
        {
          "id": "54321",
          "kind": "mdn"
        }
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Update Device Group

Make changes to a device group, including changing the name and description, and adding or removing devices.

```java
CompletableFuture<ApiResponse<ConnectivityManagementSuccessResult>> updateDeviceGroupAsync(
    final String aname,
    final String gname,
    final DeviceGroupUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |
| `gname` | `String` | Template, Required | Group name. |
| `body` | [`DeviceGroupUpdateRequest`](../../doc/models/device-group-update-request.md) | Body, Required | Request to update device group. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ConnectivityManagementSuccessResult`](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```java
String aname = "0252012345-00001";
String gname = "gname2";
DeviceGroupUpdateRequest body = new DeviceGroupUpdateRequest.Builder()
    .devicesToAdd(Arrays.asList(
        new DeviceId.Builder(
            "990003420535537",
            "imei"
        )
        .build()
    ))
    .newGroupDescription("All western region tank level monitors.")
    .newGroupName("Western region tanks")
    .build();

deviceGroupsApi.updateDeviceGroupAsync(aname, gname, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Delete Device Group

Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.

```java
CompletableFuture<ApiResponse<ConnectivityManagementSuccessResult>> deleteDeviceGroupAsync(
    final String aname,
    final String gname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |
| `gname` | `String` | Template, Required | Group name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ConnectivityManagementSuccessResult`](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```java
String aname = "0252012345-00001";
String gname = "gname2";

deviceGroupsApi.deleteDeviceGroupAsync(aname, gname).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

