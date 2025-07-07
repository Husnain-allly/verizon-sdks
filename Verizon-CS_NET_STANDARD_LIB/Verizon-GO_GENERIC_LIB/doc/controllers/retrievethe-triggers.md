# Retrievethe Triggers

```go
retrievetheTriggersApi := client.RetrievetheTriggersApi()
```

## Class Name

`RetrievetheTriggersApi`

## Methods

* [Get All Available Triggers](../../doc/controllers/retrievethe-triggers.md#get-all-available-triggers)
* [Get All Triggers by Account Name](../../doc/controllers/retrievethe-triggers.md#get-all-triggers-by-account-name)
* [Get All Triggers by Trigger Category](../../doc/controllers/retrievethe-triggers.md#get-all-triggers-by-trigger-category)
* [Get Triggers by Id](../../doc/controllers/retrievethe-triggers.md#get-triggers-by-id)


# Get All Available Triggers

Retrieves all of the available triggers for pseudo-MDN.

```go
GetAllAvailableTriggers(
    ctx context.Context) (
    models.ApiResponse[models.TriggerValueResponse],
    error)
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerValueResponse](../../doc/models/trigger-value-response.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := retrieveTheTriggersApi.GetAllAvailableTriggers(ctx)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get All Triggers by Account Name

Retrieve the triggers associated with an account name.

```go
GetAllTriggersByAccountName(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.TriggerValueResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The account name |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerValueResponse](../../doc/models/trigger-value-response.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-000001"

apiResponse, err := retrieveTheTriggersApi.GetAllTriggersByAccountName(ctx, accountName)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get All Triggers by Trigger Category

Retrieves all of the triggers for the specified account associated with the PromoAlert category

```go
GetAllTriggersByTriggerCategory(
    ctx context.Context) (
    models.ApiResponse[models.TriggerValueResponse2],
    error)
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerValueResponse2](../../doc/models/trigger-value-response-2.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := retrieveTheTriggersApi.GetAllTriggersByTriggerCategory(ctx)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |


# Get Triggers by Id

Retrives a specific trigger by its ID.

```go
GetTriggersById(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[models.TriggerValueResponse2],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | The ID of a specific trigger |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerValueResponse2](../../doc/models/trigger-value-response-2.md).

## Example Usage

```go
ctx := context.Background()

triggerId := "2874DEC7-26CF-4797-9C6A-B5A2AC72D526"

apiResponse, err := retrieveTheTriggersApi.GetTriggersById(ctx, triggerId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

