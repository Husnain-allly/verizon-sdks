# Device Groups

```go
deviceGroupsApi := client.DeviceGroupsApi()
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

```go
CreateDeviceGroup(
    ctx context.Context,
    body models.CreateDeviceGroupRequest) (
    models.ApiResponse[models.ConnectivityManagementSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.CreateDeviceGroupRequest`](../../doc/models/create-device-group-request.md) | Body, Required | A request to create a new device group. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConnectivityManagementSuccessResult](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.CreateDeviceGroupRequest{
    AccountName:           "0000123456-00001",
    GroupDescription:      "descriptive string",
    GroupName:             "group name",
    DevicesToAdd:          []models.DeviceId{
        models.DeviceId{
            Id:                    "15-digit IMEI",
            Kind:                  "imei",
        },
    },
}

apiResponse, err := deviceGroupsApi.CreateDeviceGroup(ctx, body)
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Device Groups

Returns a list of all device groups in a specified account.

```go
ListDeviceGroups(
    ctx context.Context,
    aname string) (
    models.ApiResponse[[]models.DeviceGroup],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DeviceGroup](../../doc/models/device-group.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

apiResponse, err := deviceGroupsApi.ListDeviceGroups(ctx, aname)
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

```go
GetDeviceGroupInformation(
    ctx context.Context,
    aname string,
    gname string,
    next *int64) (
    models.ApiResponse[models.DeviceGroupDevicesData],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `gname` | `string` | Template, Required | Group name. |
| `next` | `*int64` | Query, Optional | Continue the previous query from the pageUrl pagetoken. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceGroupDevicesData](../../doc/models/device-group-devices-data.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

gname := "gname2"



apiResponse, err := deviceGroupsApi.GetDeviceGroupInformation(ctx, aname, gname, nil)
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

```go
UpdateDeviceGroup(
    ctx context.Context,
    aname string,
    gname string,
    body models.DeviceGroupUpdateRequest) (
    models.ApiResponse[models.ConnectivityManagementSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `gname` | `string` | Template, Required | Group name. |
| `body` | [`models.DeviceGroupUpdateRequest`](../../doc/models/device-group-update-request.md) | Body, Required | Request to update device group. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConnectivityManagementSuccessResult](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

gname := "gname2"

body := models.DeviceGroupUpdateRequest{
    DevicesToAdd:          []models.DeviceId{
        models.DeviceId{
            Id:                    "990003420535537",
            Kind:                  "imei",
        },
    },
    NewGroupDescription:   models.ToPointer("All western region tank level monitors."),
    NewGroupName:          models.ToPointer("Western region tanks"),
}

apiResponse, err := deviceGroupsApi.UpdateDeviceGroup(ctx, aname, gname, body)
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Delete Device Group

Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.

```go
DeleteDeviceGroup(
    ctx context.Context,
    aname string,
    gname string) (
    models.ApiResponse[models.ConnectivityManagementSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `gname` | `string` | Template, Required | Group name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConnectivityManagementSuccessResult](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

gname := "gname2"

apiResponse, err := deviceGroupsApi.DeleteDeviceGroup(ctx, aname, gname)
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

