# Diagnostics History

```java
DiagnosticsHistoryApi diagnosticsHistoryApi = client.getDiagnosticsHistoryApi();
```

## Class Name

`DiagnosticsHistoryApi`


# Get Diagnostics History

This endpoint allows the user to get the history data.

```java
CompletableFuture<ApiResponse<List<History>>> getDiagnosticsHistoryAsync(
    final HistorySearchRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`HistorySearchRequest`](../../doc/models/history-search-request.md) | Body, Required | History data information. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<History>`](../../doc/models/history.md).

## Example Usage

```java
HistorySearchRequest body = new HistorySearchRequest.Builder(
    new HistorySearchFilter.Builder(
        "0000123456-00001",
        new Device.Builder(
            "15-digit IMEI",
            "IMEI"
        )
        .build()
    )
    .attributes(new HistorySearchFilterAttributes.Builder()
            .name(AttributeIdentifier.LINK_QUALITY)
            .build())
    .build()
)
.build();

diagnosticsHistoryApi.getDiagnosticsHistoryAsync(body).thenAccept(result -> {
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
    "accountName": "0000123456-00001",
    "attributes": {
      "createdOn": "2022-02-10T16:02:21.406Z",
      "name": "LINK_QUALITY",
      "value": "47"
    },
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI"
    }
  },
  {
    "accountName": "0000123456-00001",
    "attributes": {
      "createdOn": "2022-02-10T16:02:05.316Z",
      "name": "LINK_QUALITY",
      "value": "47"
    },
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

