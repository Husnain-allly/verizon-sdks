# Devices Locations

```java
DevicesLocationsApi devicesLocationsApi = client.getDevicesLocationsApi();
```

## Class Name

`DevicesLocationsApi`

## Methods

* [List Devices Locations Synchronous](../../doc/controllers/devices-locations.md#list-devices-locations-synchronous)
* [List Devices Locations Asynchronous](../../doc/controllers/devices-locations.md#list-devices-locations-asynchronous)
* [Create Location Report](../../doc/controllers/devices-locations.md#create-location-report)
* [Retrieve Location Report](../../doc/controllers/devices-locations.md#retrieve-location-report)
* [Get Location Report Status](../../doc/controllers/devices-locations.md#get-location-report-status)
* [Cancel Queued Location Report Generation](../../doc/controllers/devices-locations.md#cancel-queued-location-report-generation)


# List Devices Locations Synchronous

This locations endpoint retrieves the locations for a list of devices.

```java
CompletableFuture<ApiResponse<List<Location>>> listDevicesLocationsSynchronousAsync(
    final LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request to obtain location of devices. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<Location>`](../../doc/models/location.md).

## Example Usage

```java
LocationRequest body = new LocationRequest.Builder(
    "1234567890-00001",
    Arrays.asList(
        new DeviceInfo.Builder(
            "980003420535573",
            "imei",
            "7892345678"
        )
        .build(),
        new DeviceInfo.Builder(
            "375535024300089",
            "imei",
            "7897654321"
        )
        .build()
    )
)
.accuracyMode(AccuracyMode.ENUM_0)
.cacheMode(CacheMode.ENUM_1)
.build();

devicesLocationsApi.listDevicesLocationsSynchronousAsync(body).thenAccept(result -> {
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
    "msid": "7892345678",
    "pd": {
      "time": "20170520004421",
      "x": "33.45324",
      "y": "-84.59621",
      "radius": "5571",
      "qos": false
    },
    "error": {}
  },
  {
    "msid": "8583239709",
    "pd": {
      "time": "20170525214342",
      "x": "38.8408694",
      "y": "-105.0422583",
      "radius": "3866",
      "qos": false
    },
    "error": {}
  },
  {
    "msid": "7897654321",
    "pd": {},
    "error": {
      "time": "20170525214342",
      "type": "POSITION METHOD FAILURE",
      "info": "Exception code=ABSENT SUBSCRIBER"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Devices Locations Asynchronous

Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.

```java
CompletableFuture<ApiResponse<SynchronousLocationRequestResult>> listDevicesLocationsAsynchronousAsync(
    final LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | An asynchronous request to obtain locations of devices. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`SynchronousLocationRequestResult`](../../doc/models/synchronous-location-request-result.md).

## Example Usage

```java
LocationRequest body = new LocationRequest.Builder(
    "2234434445-32333",
    Arrays.asList(
        new DeviceInfo.Builder(
            "354677790348290",
            "imei",
            "5557337468"
        )
        .build()
    )
)
.accuracyMode(AccuracyMode.ENUM_0)
.cacheMode(CacheMode.ENUM_2)
.build();

devicesLocationsApi.listDevicesLocationsAsynchronousAsync(body).thenAccept(result -> {
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
  "txid": "4be7c858-eeee-ffff-gggg-95061456d835",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Create Location Report

Request an asynchronous device location report.

```java
CompletableFuture<ApiResponse<AsynchronousLocationRequestResult>> createLocationReportAsync(
    final LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request for device location report. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`AsynchronousLocationRequestResult`](../../doc/models/asynchronous-location-request-result.md).

## Example Usage

```java
LocationRequest body = new LocationRequest.Builder(
    "1234567890-00001",
    Arrays.asList(
        new DeviceInfo.Builder(
            "980003420535573",
            "imei",
            "7892345678"
        )
        .build(),
        new DeviceInfo.Builder(
            "375535024300089",
            "imei",
            "7897654321"
        )
        .build(),
        new DeviceInfo.Builder(
            "A100003861E585",
            "meid",
            "7897650914"
        )
        .build()
    )
)
.accuracyMode(AccuracyMode.ENUM_0)
.cacheMode(CacheMode.ENUM_1)
.build();

devicesLocationsApi.createLocationReportAsync(body).thenAccept(result -> {
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Retrieve Location Report

Download a completed asynchronous device location report.

```java
CompletableFuture<ApiResponse<LocationReport>> retrieveLocationReportAsync(
    final String accountName,
    final String txid,
    final int startindex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `String` | Template, Required | Transaction ID from POST /locationreports response. |
| `startindex` | `int` | Template, Required | Zero-based number of the first record to return. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`LocationReport`](../../doc/models/location-report.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String txid = "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9";
int startindex = 0;

devicesLocationsApi.retrieveLocationReportAsync(accountName, txid, startindex).thenAccept(result -> {
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
  "startIndex": "0",
  "txid": "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9",
  "totalCount": 3,
  "hasMoreData": false,
  "devLocationList": [
    {
      "error": {},
      "msid": "7892345678",
      "pd": {
        "qos": false,
        "radius": "5571",
        "time": "20170520004421",
        "x": "33.45324",
        "y": "-84.59621"
      }
    },
    {
      "error": {},
      "msid": "8583239709",
      "pd": {
        "qos": false,
        "radius": "3866",
        "time": "20170525214342",
        "x": "38.8408694",
        "y": "-105.0422583"
      }
    },
    {
      "error": {
        "time": "20170525214342",
        "type": "POSITION METHOD FAILURE",
        "info": "Exception code=ABSENT SUBSCRIBER"
      },
      "msid": "7897654321",
      "pd": {}
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Get Location Report Status

Returns the current status of a requested device location report.

```java
CompletableFuture<ApiResponse<LocationReportStatus>> getLocationReportStatusAsync(
    final String accountName,
    final String txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `String` | Template, Required | Transaction ID of the report. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`LocationReportStatus`](../../doc/models/location-report-status.md).

## Example Usage

```java
String accountName = "0252012345-00001";
String txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33";

devicesLocationsApi.getLocationReportStatusAsync(accountName, txid).thenAccept(result -> {
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "INPROGRESS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Cancel Queued Location Report Generation

Cancel a queued device location report.

```java
CompletableFuture<ApiResponse<TransactionId>> cancelQueuedLocationReportGenerationAsync(
    final String accountName,
    final String txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `String` | Template, Required | Transaction ID of the report to cancel. |

## Server

`Server.DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`TransactionId`](../../doc/models/transaction-id.md).

## Example Usage

```java
String accountName = "0252012345-00001";
String txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33";

devicesLocationsApi.cancelQueuedLocationReportGenerationAsync(accountName, txid).thenAccept(result -> {
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

