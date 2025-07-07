# Devices Locations

```csharp
DevicesLocationsApi devicesLocationsApi = client.DevicesLocationsApi;
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

```csharp
ListDevicesLocationsSynchronousAsync(
    Models.LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request to obtain location of devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.Location>](../../doc/models/location.md).

## Example Usage

```csharp
LocationRequest body = new LocationRequest
{
    AccountName = "1234567890-00001",
    DeviceList = new List<DeviceInfo>
    {
        new DeviceInfo
        {
            Id = "980003420535573",
            Kind = "imei",
            Mdn = "7892345678",
        },
        new DeviceInfo
        {
            Id = "375535024300089",
            Kind = "imei",
            Mdn = "7897654321",
        },
    },
    AccuracyMode = AccuracyMode.Enum0,
    CacheMode = CacheMode.Enum1,
};

try
{
    ApiResponse<List<Location>> result = await devicesLocationsApi.ListDevicesLocationsSynchronousAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
ListDevicesLocationsAsynchronousAsync(
    Models.LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | An asynchronous request to obtain locations of devices. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SynchronousLocationRequestResult](../../doc/models/synchronous-location-request-result.md).

## Example Usage

```csharp
LocationRequest body = new LocationRequest
{
    AccountName = "2234434445-32333",
    DeviceList = new List<DeviceInfo>
    {
        new DeviceInfo
        {
            Id = "354677790348290",
            Kind = "imei",
            Mdn = "5557337468",
        },
    },
    AccuracyMode = AccuracyMode.Enum0,
    CacheMode = CacheMode.Enum2,
};

try
{
    ApiResponse<SynchronousLocationRequestResult> result = await devicesLocationsApi.ListDevicesLocationsAsynchronousAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
CreateLocationReportAsync(
    Models.LocationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request for device location report. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AsynchronousLocationRequestResult](../../doc/models/asynchronous-location-request-result.md).

## Example Usage

```csharp
LocationRequest body = new LocationRequest
{
    AccountName = "1234567890-00001",
    DeviceList = new List<DeviceInfo>
    {
        new DeviceInfo
        {
            Id = "980003420535573",
            Kind = "imei",
            Mdn = "7892345678",
        },
        new DeviceInfo
        {
            Id = "375535024300089",
            Kind = "imei",
            Mdn = "7897654321",
        },
        new DeviceInfo
        {
            Id = "A100003861E585",
            Kind = "meid",
            Mdn = "7897650914",
        },
    },
    AccuracyMode = AccuracyMode.Enum0,
    CacheMode = CacheMode.Enum1,
};

try
{
    ApiResponse<AsynchronousLocationRequestResult> result = await devicesLocationsApi.CreateLocationReportAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
RetrieveLocationReportAsync(
    string accountName,
    string txid,
    int startindex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID from POST /locationreports response. |
| `startindex` | `int` | Template, Required | Zero-based number of the first record to return. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.LocationReport](../../doc/models/location-report.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
string txid = "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9";
int startindex = 0;
try
{
    ApiResponse<LocationReport> result = await devicesLocationsApi.RetrieveLocationReportAsync(
        accountName,
        txid,
        startindex
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
GetLocationReportStatusAsync(
    string accountName,
    string txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID of the report. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.LocationReportStatus](../../doc/models/location-report-status.md).

## Example Usage

```csharp
string accountName = "0252012345-00001";
string txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33";
try
{
    ApiResponse<LocationReportStatus> result = await devicesLocationsApi.GetLocationReportStatusAsync(
        accountName,
        txid
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
CancelQueuedLocationReportGenerationAsync(
    string accountName,
    string txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | Transaction ID of the report to cancel. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionId](../../doc/models/transaction-id.md).

## Example Usage

```csharp
string accountName = "0252012345-00001";
string txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33";
try
{
    ApiResponse<TransactionId> result = await devicesLocationsApi.CancelQueuedLocationReportGenerationAsync(
        accountName,
        txid
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

