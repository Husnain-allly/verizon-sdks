
# Device Diagnostics Callback

Callback information of an existing diagnostics subscription.

*This model accepts additional fields of type Object.*

## Structure

`DeviceDiagnosticsCallback`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | The name of the billing account for which callback messages will be sent. Format: "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `ServiceName` | `String` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. | String getServiceName() | setServiceName(String serviceName) |
| `Endpoint` | `String` | Required | The URL for your web server. | String getEndpoint() | setEndpoint(String endpoint) |
| `CreatedOn` | `LocalDateTime` | Required | The date and time of when this request was created. | LocalDateTime getCreatedOn() | setCreatedOn(LocalDateTime createdOn) |
| `HttpHeaders` | `Object` | Optional | Your HTTP headers. | Object getHttpHeaders() | setHttpHeaders(Object httpHeaders) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

