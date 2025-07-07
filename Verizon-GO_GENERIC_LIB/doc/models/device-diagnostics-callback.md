
# Device Diagnostics Callback

Callback information of an existing diagnostics subscription.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceDiagnosticsCallback`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The name of the billing account for which callback messages will be sent. Format: "##########-#####". |
| `ServiceName` | `string` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. |
| `Endpoint` | `string` | Required | The URL for your web server. |
| `CreatedOn` | `time.Time` | Required | The date and time of when this request was created. |
| `HttpHeaders` | `*interface{}` | Optional | Your HTTP headers. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "TestQAAccount",
  "serviceName": "Diagnostics",
  "endpoint": "https://yourwebsite.com",
  "createdOn": "2019-09-07T23:57:53.292Z",
  "httpHeaders": {
    "key1": "val1",
    "key2": "val2"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

