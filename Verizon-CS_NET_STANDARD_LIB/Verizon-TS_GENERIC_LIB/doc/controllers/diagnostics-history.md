# Diagnostics History

```ts
const diagnosticsHistoryApi = new DiagnosticsHistoryApi(client);
```

## Class Name

`DiagnosticsHistoryApi`


# Get Diagnostics History

This endpoint allows the user to get the history data.

```ts
async getDiagnosticsHistory(
  body: HistorySearchRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<History[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`HistorySearchRequest`](../../doc/models/history-search-request.md) | Body, Required | History data information. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [History[]](../../doc/models/history.md).

## Example Usage

```ts
const body: HistorySearchRequest = {
  mFilter: {
    accountName: '0000123456-00001',
    device: {
      id: '15-digit IMEI',
      kind: 'IMEI',
    },
    attributes: {
      name: AttributeIdentifier.LinkQuality,
    },
  },
};

try {
  const { result, ...httpResponse } = await diagnosticsHistoryApi.getDiagnosticsHistory(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
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
| Default | Error response. | [`DeviceDiagnosticsResultError`](../../doc/models/device-diagnostics-result-error.md) |

