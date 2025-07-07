# Diagnostics Observations

```go
diagnosticsObservationsApi := client.DiagnosticsObservationsApi()
```

## Class Name

`DiagnosticsObservationsApi`

## Methods

* [Start Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#start-diagnostics-observation)
* [Stop Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#stop-diagnostics-observation)


# Start Diagnostics Observation

This endpoint allows the user to start or change observe diagnostics.

```go
StartDiagnosticsObservation(
    ctx context.Context,
    body models.ObservationRequest) (
    models.ApiResponse[models.DiagnosticsObservationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ObservationRequest`](../../doc/models/observation-request.md) | Body, Required | Request for device observation information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DiagnosticsObservationResult](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.ObservationRequest{
    AccountName:           "TestQAAccount",
    Devices:               []models.Device{
        models.Device{
            Id:                    "864508030026238",
            Kind:                  "IMEI",
        },
    },
    Attributes:            []models.ObservationRequestAttribute{
        models.ObservationRequestAttribute{
            Name:                  models.ToPointer(models.AttributeIdentifier_RadioSignalStrength),
        },
        models.ObservationRequestAttribute{
            Name:                  models.ToPointer(models.AttributeIdentifier_LinkQuality),
        },
        models.ObservationRequestAttribute{
            Name:                  models.ToPointer(models.AttributeIdentifier_NetworkBearer),
        },
        models.ObservationRequestAttribute{
            Name:                  models.ToPointer(models.AttributeIdentifier_CellId),
        },
    },
    Frequency:             models.ToPointer(models.NumericalData{
        Value:                 models.ToPointer(15),
        Unit:                  models.ToPointer(models.NumericalDataUnit_Second),
    }),
    Duration:              models.ToPointer(models.NumericalData{
        Value:                 models.ToPointer(15),
        Unit:                  models.ToPointer(models.NumericalDataUnit_Second),
    }),
}

apiResponse, err := diagnosticsObservationsApi.StartDiagnosticsObservation(ctx, body)
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

```go
StopDiagnosticsObservation(
    ctx context.Context,
    transactionId string,
    accountName string) (
    models.ApiResponse[models.DiagnosticsObservationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `string` | Query, Required | The ID value associated with the transaction. |
| `accountName` | `string` | Query, Required | The numeric account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DiagnosticsObservationResult](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```go
ctx := context.Background()

transactionId := "5f4bd2ff-5d7f-444d-af17-3f6a80bb2a94"

accountName := "0000123456-00001"

apiResponse, err := diagnosticsObservationsApi.StopDiagnosticsObservation(ctx, transactionId, accountName)
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

