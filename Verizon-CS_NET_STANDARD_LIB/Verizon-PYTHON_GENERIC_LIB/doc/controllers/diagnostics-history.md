# Diagnostics History

```python
diagnostics_history_api = client.diagnostics_history
```

## Class Name

`DiagnosticsHistoryApi`


# Get Diagnostics History

This endpoint allows the user to get the history data.

```python
def get_diagnostics_history(self,
                           body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`HistorySearchRequest`](../../doc/models/history-search-request.md) | Body, Required | History data information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[History]`](../../doc/models/history.md).

## Example Usage

```python
body = HistorySearchRequest(
    m_filter=HistorySearchFilter(
        account_name='0000123456-00001',
        device=Device(
            id='15-digit IMEI',
            kind='IMEI',
            additional_properties=None
        ),
        additional_properties=None,
        attributes=HistorySearchFilterAttributes(
            additional_properties=None,
            name=AttributeIdentifier.LINK_QUALITY
        )
    ),
    additional_properties=None
)

result = diagnostics_history_api.get_diagnostics_history(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
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

