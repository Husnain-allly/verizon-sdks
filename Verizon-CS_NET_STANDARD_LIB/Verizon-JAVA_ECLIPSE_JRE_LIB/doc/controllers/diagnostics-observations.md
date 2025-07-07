# Diagnostics Observations

```java
DiagnosticsObservationsApi diagnosticsObservationsApi = client.getDiagnosticsObservationsApi();
```

## Class Name

`DiagnosticsObservationsApi`

## Methods

* [Start Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#start-diagnostics-observation)
* [Stop Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#stop-diagnostics-observation)


# Start Diagnostics Observation

This endpoint allows the user to start or change observe diagnostics.

```java
CompletableFuture<ApiResponse<DiagnosticsObservationResult>> startDiagnosticsObservationAsync(
    final ObservationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ObservationRequest`](../../doc/models/observation-request.md) | Body, Required | Request for device observation information. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DiagnosticsObservationResult`](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```java
ObservationRequest body = new ObservationRequest.Builder(
    "TestQAAccount",
    Arrays.asList(
        new Device.Builder(
            "864508030026238",
            "IMEI"
        )
        .build()
    ),
    Arrays.asList(
        new ObservationRequestAttribute.Builder()
            .name(AttributeIdentifier.RADIO_SIGNAL_STRENGTH)
            .build(),
        new ObservationRequestAttribute.Builder()
            .name(AttributeIdentifier.LINK_QUALITY)
            .build(),
        new ObservationRequestAttribute.Builder()
            .name(AttributeIdentifier.NETWORK_BEARER)
            .build(),
        new ObservationRequestAttribute.Builder()
            .name(AttributeIdentifier.CELL_ID)
            .build()
    )
)
.frequency(new NumericalData.Builder()
        .value(15)
        .unit(NumericalDataUnit.SECOND)
        .build())
.duration(new NumericalData.Builder()
        .value(15)
        .unit(NumericalDataUnit.SECOND)
        .build())
.build();

diagnosticsObservationsApi.startDiagnosticsObservationAsync(body).thenAccept(result -> {
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Stop Diagnostics Observation

This endpoint allows the user to stop or reset observe diagnostics.

```java
CompletableFuture<ApiResponse<DiagnosticsObservationResult>> stopDiagnosticsObservationAsync(
    final String transactionId,
    final String accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `String` | Query, Required | The ID value associated with the transaction. |
| `accountName` | `String` | Query, Required | The numeric account name. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DiagnosticsObservationResult`](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```java
String transactionId = "5f4bd2ff-5d7f-444d-af17-3f6a80bb2a94";
String accountName = "0000123456-00001";

diagnosticsObservationsApi.stopDiagnosticsObservationAsync(transactionId, accountName).thenAccept(result -> {
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

