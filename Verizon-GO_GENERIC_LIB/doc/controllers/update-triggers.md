# Update Triggers

```go
updateTriggersApi := client.UpdateTriggersApi()
```

## Class Name

`UpdateTriggersApi`


# Update All Available Triggers

Updates the promotional triggers for pseudo-MDN.

```go
UpdateAllAvailableTriggers(
    ctx context.Context,
    body *models.RequestTrigger) (
    models.ApiResponse[models.Success],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`*models.RequestTrigger`](../../doc/models/request-trigger.md) | Body, Optional | Update the triggers |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.Success](../../doc/models/success.md).

## Example Usage

```go
ctx := context.Background()

body := models.RequestTrigger{
    TriggerId:             models.ToPointer("2874DEC7-26CF-4797-9C6A-B5A2AC72D526"),
    TriggerName:           models.ToPointer("PromoAlerts_0000000000-00001_23456789"),
    AccountName:           models.ToPointer("0000123456-000001"),
    OrganizationName:      models.ToPointer("Optional group name"),
    TriggerCategory:       models.ToPointer("PromoAlerts"),
}

apiResponse, err := updateTriggersApi.UpdateAllAvailableTriggers(ctx, &body)
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
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

